namespace BlazorBindingExamples.Models
{
    public class Country
    {
        public Country(string name, string code)
        {
            Name = name;
            Code = code;
        }

        public string Name { get; init; }
        public string Code { get; init; }
    }
}
