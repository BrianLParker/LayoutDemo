namespace LayoutDemo.Views.Components
{
    using LayoutDemo.Shared;
    using Microsoft.AspNetCore.Components;

    public class LayoutSetter : ComponentBase
    {
        [CascadingParameter]
        public MainLayout Layout { get; set; }

        [Parameter]
        public RenderFragment Header { get; set; }

        [Parameter]
        public RenderFragment Footer { get; set; }

        protected override void OnInitialized()
        {
            Layout.SetHeaderAndFooter(Header, Footer);
        }
    }
}
