using AutoMapper;
using PCStore.Web.Core.Abstractions.DiscountCards;
using PCStore.Web.Core.EntitiesDTO.Create;
using PCStore.Web.Core.EntitiesDTO.Output;
using PCStore.Web.Core.Models;

namespace PCStore.Web.Application.Services
{
    public class DiscountCardsService(IDiscountCardsRepository discountCardRepository, IMapper mapper)
        : IDiscountCardsService
    {
        public async Task<DiscountCardsEntityDTO?> GetDiscountCardByIdAsync(Guid id)
        {
            var discountCard = await discountCardRepository.GetAsync(id);
            return mapper.Map<DiscountCardsEntityDTO>(discountCard);
        }

        public async Task<DiscountCardsEntityDTO> CreateDiscountCardAsync(CreateDiscountCardsEntity createDiscountCard)
        {
            var discountCard = mapper.Map<DiscountCard>(createDiscountCard);
            discountCard.CreatedDate = DateTime.Now;
            await discountCardRepository.CreateAsync(discountCard);
            return mapper.Map<DiscountCardsEntityDTO>(discountCard);
        }
    }
}
