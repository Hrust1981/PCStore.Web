using AutoMapper;
using PCStore.Web.Core.EntitiesDTO.Create;
using PCStore.Web.Core.EntitiesDTO.Output;
using PCStore.Web.Core.EntitiesDTO.Update;
using PCStore.Web.Core.Models;

namespace PCStore.Web.Host
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile() 
        {
            CreateMap<User, CreateUsersEntity>().ReverseMap();
            CreateMap<User, UpdateUsersEntity>().ReverseMap();

            CreateMap<Product, CreateProductsEntity>().ReverseMap();
            CreateMap<Product, UpdateProductsEntity>().ReverseMap();

            CreateMap<Order, CreateOrdersEntity>().ReverseMap();

            CreateMap<ShoppingCart, CreateShoppingCartsEntity>().ReverseMap();

            CreateMap<DiscountCard, CreateDiscountCardsEntity>().ReverseMap();

            CreateMap<User, UsersEntityDTO>().ReverseMap();

            CreateMap<ShoppingCart, ShoppingCartsEntityDTO>().ReverseMap();

            CreateMap<Product, ProductsEntityDTO>().ReverseMap();

            CreateMap<Order, OrdersEntityDTO>().ReverseMap();

            CreateMap<DiscountCard, DiscountCardsEntityDTO>().ReverseMap();
        }
    }
}
