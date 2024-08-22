using AutoMapper;
using PCStore.Web.Core.ModelsDto.Create;
using PCStore.Web.Core.ModelsDto.Output;
using PCStore.Web.Core.ModelsDto.Update;
using PCStore.Web.Core.Models;

namespace PCStore.Web.Host
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile() 
        {
            CreateMap<User, CreateUsersDto>().ReverseMap();
            CreateMap<User, UpdateUsersDto>().ReverseMap();

            CreateMap<Product, CreateProductsDto>().ReverseMap();
            CreateMap<Product, UpdateProductsDto>().ReverseMap();

            CreateMap<Order, CreateOrdersDto>().ReverseMap();

            CreateMap<ShoppingCart, CreateShoppingCartsDto>().ReverseMap();

            CreateMap<DiscountCard, CreateDiscountCardsDto>().ReverseMap();

            CreateMap<User, UsersDto>().ReverseMap();

            CreateMap<ShoppingCart, ShoppingCartsDto>().ReverseMap();

            CreateMap<Product, ProductsDto>().ReverseMap();

            CreateMap<Order, OrdersDto>().ReverseMap();

            CreateMap<DiscountCard, DiscountCardsDto>().ReverseMap();
        }
    }
}
