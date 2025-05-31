using challenge9.Shared.Domain;
using challenge9.ShopContext.Domain.Models.Commands;
using challenge9.ShopContext.Domain.Models.Entities;
using challenge9.ShopContext.Domain.Services;

namespace challenge9.ShopContext.Application.QueryServices;

public class DiscountQueryService : IDiscountQueryService
{
    private IDiscountRepository _discountRepository;

    public DiscountQueryService(IDiscountRepository DiscountRepository)
    {
        _discountRepository = DiscountRepository;
    }
    public async Task<IEnumerable<Discount>> Handler(GetAllMemberships query)
    {
        return await _discountRepository.GetAllAsync();
    }

}