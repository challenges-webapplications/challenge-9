using challenge9.ShopContext.Domain.Models.Entities;
using challenge9.ShopContext.Domain.Models.Commands;

namespace challenge9.ShopContext.Domain.Services;

public interface IDiscountQueryService
{
    Task<IEnumerable<Discount>> Handler(GetAllMemberships query);
    
}