namespace BlazorBindingExamples.Models
{
    public class Model
    {
        public Model(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; init; }
        public string? Name { get; set; }
        public Gender? Gender { get; set; }
        public string? Nationality { get; set; }
        public int? Age { get; set; }
        public decimal? Salary { get; set; }
        public MarketingOption? MarketingOptions { get; set; }
    }
}
