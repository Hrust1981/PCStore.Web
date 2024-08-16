using PCStore.Web.Core.EntitiesDTO.Create;
using PCStore.Web.Core.EntitiesDTO.Output;

namespace PCStore.Web.Core.Abstractions.DiscountCards
{
    public interface IDiscountCardsService
    {
        Task<DiscountCardsEntityDTO?> GetDiscountCardByIdAsync(Guid id);
        Task<DiscountCardsEntityDTO> CreateDiscountCardAsync(CreateDiscountCardsEntity createDiscountCard);
    }
}
