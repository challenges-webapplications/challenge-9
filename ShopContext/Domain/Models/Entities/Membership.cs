using challenge9.Shared.Domain.Model.Entities;

namespace challenge9.ShopContext.Domain.Models.Entities;

public class Membership : BaseEntity{
    public string membershipStatus { get; set; }
    public string membershipType { get; set; }
    
}