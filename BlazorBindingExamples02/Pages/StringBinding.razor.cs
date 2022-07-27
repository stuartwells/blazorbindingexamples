using BlazorBindingExamples.Models;
using Microsoft.AspNetCore.Components;

namespace BlazorBindingExamples.Pages
{
    public partial class StringBinding : ComponentBase
    {
        public bool Initialised { get; set; } = false;
        public Model Model { get; private set; }

        protected override async Task OnInitializedAsync()
        {
            Model = new(Guid.NewGuid());
            Model.Name = "Stuart Wells";

            await base.OnInitializedAsync();

            // Set this when fully initialised as we use this to prevent premature rendering
            Initialised = true;
        }
    }
}
