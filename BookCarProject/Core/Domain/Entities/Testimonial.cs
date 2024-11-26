namespace Domain.Entities
{
    public sealed class Testimonial
    {
        public int TestimonialId { get; set; }
        public string TestimonialName { get; set; }
        public string TestimonialTitle { get; set; }
        public string TestimonialDescription { get; set; }
        public string ImageUrl { get; set; }
    }
}
