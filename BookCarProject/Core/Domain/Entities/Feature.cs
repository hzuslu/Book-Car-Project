namespace Domain.Entities
{
    public sealed class Feature
    {
        public int FeatureId { get; set; }
        public string FeatureName { get; set; }
        public List<CarFeature> CarFeatures { get; set; }
    }
}

