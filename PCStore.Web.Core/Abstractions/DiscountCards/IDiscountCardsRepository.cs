using PCStore.Web.Core.Models;

namespace PCStore.Web.Core.Abstractions.DiscountCards
{
    public interface IDiscountCardsRepository
    {
        Task<DiscountCard?> GetAsync(Guid id);
        Task<DiscountCard> CreateAsync(DiscountCard discountCard);
    }
}
