using challenge9.Shared.Domain.Model.Entities;

namespace challenge9.ShopContext.Domain.Models.Entities;

public class Product : BaseEntity
{
    public string Name { get; set; }
    public string productType { get; set; }
    public int productPrice { get; set; }
    

}