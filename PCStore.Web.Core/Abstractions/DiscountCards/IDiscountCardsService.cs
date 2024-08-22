using PCStore.Web.Core.ModelsDto.Create;
using PCStore.Web.Core.ModelsDto.Output;

namespace PCStore.Web.Core.Abstractions.DiscountCards
{
    public interface IDiscountCardsService
    {
        Task<DiscountCardsDto?> GetDiscountCardByIdAsync(Guid id);
        Task<DiscountCardsDto> CreateDiscountCardAsync(CreateDiscountCardsDto createDiscountCard);
    }
}
