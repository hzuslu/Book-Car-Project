namespace Domain.Entities
{
    public sealed class Pricing
    {
        public int PricingId { get; set; }
        public string Period { get; set; }
        public List<CarPricing> CarPricings { get; set; }
    }
}
