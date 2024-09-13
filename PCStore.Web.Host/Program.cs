using Asp.Versioning;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using PCStore.Web.Application.Extensions;
using PCStore.Web.Application.Services;
using PCStore.Web.Core.Abstractions.DiscountCards;
using PCStore.Web.Core.Abstractions.Orders;
using PCStore.Web.Core.Abstractions.Products;
using PCStore.Web.Core.Abstractions.ShoppingCarts;
using PCStore.Web.Core.Abstractions.Users;
using PCStore.Web.DataAccess;
using PCStore.Web.DataAccess.Repositories;
using PCStore.Web.Host;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddScoped<IUsersService, UsersService>();
        builder.Services.AddScoped<IUsersRepository, UsersRepository>();
        builder.Services.AddScoped<IProductsService, ProductsService>();
        builder.Services.AddScoped<IProductsRepository, ProductsRepository>();
        builder.Services.AddScoped<IShoppingCartsService, ShoppingCartsService>();
        builder.Services.AddScoped<IShoppingCartsRepository, ShoppingCartsRepository>();
        builder.Services.AddScoped<IOrdersService, OrdersService>();
        builder.Services.AddScoped<IOrdersRepository, OrdersRepository>();
        builder.Services.AddScoped<IDiscountCardsService, DiscountCardsService>();
        builder.Services.AddScoped<IDiscountCardsRepository, DiscountCardsRepository>();

        var connectionString = builder.Configuration.GetConnectionString("ConnectionMySQL");
        var redisConnectionString = builder.Configuration.GetConnectionString("RedisCache");

        builder.Services.AddDbContext<ApplicationDbContext>(options =>
        {
            options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
            options.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
        });

        builder.Services.AddStackExchangeRedisOutputCache(options => options.Configuration = redisConnectionString);

        builder.Services.AddOutputCache(options =>
        {
            options.AddBasePolicy(x
                => x.Expire(TimeSpan.FromSeconds(20)));
        });

        builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer();

        builder.Services.AddAuthorization();

        builder.Services.AddAutoMapper(typeof(AutoMapperProfile).Assembly);

        builder.Services.AddApiVersioning(options =>
        {
            options.DefaultApiVersion = new ApiVersion(1, 0);
            options.AssumeDefaultVersionWhenUnspecified = true;
            options.ReportApiVersions = true;
        })
        .AddApiExplorer(options =>
        {
            options.GroupNameFormat = "'v'VVV";
            options.SubstituteApiVersionInUrl = true;
        });

        builder.Services.AddDatabaseDeveloperPageExceptionFilter();

        builder.Services.AddRouting(options => options.LowercaseUrls = true);

        builder.Services.AddControllers();
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen(options =>
        {
            var basePath = AppContext.BaseDirectory;
            var xmlPath = Path.Combine(basePath, "PCStoreAPI.xml");
            options.IncludeXmlComments(xmlPath);
        });

        var app = builder.Build();

        app.UseExceptionHandler("/error");

        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();

            app.ApplyMigrations();
        }

        app.UseOutputCache();

        app.UseHttpsRedirection();

        app.UseRouting();

        app.UseAuthentication();

        app.UseAuthorization();

        app.MapControllers();

        app.Run();
    }
}