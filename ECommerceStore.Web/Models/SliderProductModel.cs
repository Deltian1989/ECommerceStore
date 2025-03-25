namespace ECommerceStore.Web.Models
{
    public class SliderProductModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImagePath { get; set; }
        public decimal UnitPrice { get; set; }
        public int DiscountPercentage { get; set; }
        public decimal PriceWithDiscount { get; set; }
    }
}
