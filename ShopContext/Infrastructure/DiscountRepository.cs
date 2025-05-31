using challenge9.Shared.Domain;
using challenge9.Shared.Infraestructure.Persistence.Configuration;
using challenge9.Shared.Infraestructure.Persistence.Repositories;
using challenge9.ShopContext.Domain.Models.Entities;

namespace challenge9.ShopContext.Infrastructure;

public class DiscountRepository(Challenge9Context context) : BaseRepository<Discount>(context), IDiscountRepository
{
    
    
}