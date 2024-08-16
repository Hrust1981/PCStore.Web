using PCStore.Web.Core.Abstractions.DiscountCards;
using PCStore.Web.Core.Models;

namespace PCStore.Web.DataAccess.Repositories
{
    public class DiscountCardsRepository(ApplicationDbContext dbContext) : IDiscountCardsRepository
    {
        public async Task<DiscountCard?> GetAsync(Guid id)
        {
            return await dbContext.Discounts.FindAsync(id);
        }

        public async Task<DiscountCard> CreateAsync(DiscountCard discountCard)
        {
            await dbContext.Discounts.AddAsync(discountCard);
            await dbContext.SaveChangesAsync();
            return discountCard;
        }
    }
}
