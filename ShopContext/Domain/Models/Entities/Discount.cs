using challenge9.Shared.Domain.Model.Entities;

namespace challenge9.ShopContext.Domain.Models.Entities;

public class Discount : BaseEntity
    {
        public int DiscountPercentage { get; set; }

        public Membership membershipStatus { get; set; } = new Membership();

        public Product productPrice { get; set; } = new Product();

        public Product productType { get; set; } = new Product();
    }

