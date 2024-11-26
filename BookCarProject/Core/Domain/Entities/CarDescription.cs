namespace Domain.Entities
{
    public sealed class CarDescription
    {
        public int CarDescriptionId { get; set; }
        public string Detail { get; set; }
        public int CarId { get; set; }
        public Car Car { get; set; }
    }
}
