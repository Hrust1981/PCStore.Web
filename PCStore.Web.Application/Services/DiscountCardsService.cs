using AutoMapper;
using PCStore.Web.Core.Abstractions.DiscountCards;
using PCStore.Web.Core.ModelsDto.Create;
using PCStore.Web.Core.ModelsDto.Output;
using PCStore.Web.Core.Models;

namespace PCStore.Web.Application.Services
{
    public class DiscountCardsService(IDiscountCardsRepository discountCardRepository, IMapper mapper)
        : IDiscountCardsService
    {
        public async Task<DiscountCardsDto?> GetDiscountCardByIdAsync(Guid id)
        {
            var discountCard = await discountCardRepository.GetAsync(id);
            return mapper.Map<DiscountCardsDto>(discountCard);
        }

        public async Task<DiscountCardsDto> CreateDiscountCardAsync(CreateDiscountCardsDto createDiscountCard)
        {
            var discountCard = mapper.Map<DiscountCard>(createDiscountCard);
            discountCard.CreatedDate = DateTime.Now;
            await discountCardRepository.CreateAsync(discountCard);
            return mapper.Map<DiscountCardsDto>(discountCard);
        }
    }
}
