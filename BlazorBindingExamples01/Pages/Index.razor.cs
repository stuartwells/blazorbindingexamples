using BlazorBindingExamples.Models;
using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;

namespace BlazorBindingExamples.Pages
{
    public partial class Index : ComponentBase
    {
        [Inject]
        private HttpClient Http { get; init; }

        public bool Initialised { get; set; } = false;
        public Model Model { get; private set; }
        public IReadOnlyList<Country> Countries { get; private set; }

        protected override async Task OnInitializedAsync()
        {
            Model = new(Guid.NewGuid());

            Country[]? countries = await Http.GetFromJsonAsync<Country[]>("sample-data/countries.json");
            Countries = countries ?? Array.Empty<Country>();

            await base.OnInitializedAsync();

            // Set this when fully initialised as we use this to prevent premature rendering
            Initialised = true;
        }
    }
}
