namespace ECommerceStore.Core.Entities
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string ImagePath { get; set; }

        public decimal UnitPrice { get; set; }

        public decimal Discount { get; set; }

        public float? PopularityScore { get; set; }

        public int Amount { get; set; }

        public DateTime? AddedDate { get; set; }
    }
}
