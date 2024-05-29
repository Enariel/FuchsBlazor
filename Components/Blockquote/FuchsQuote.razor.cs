using Microsoft.AspNetCore.Components;

namespace FuchsBlazor
{
    public partial class FuchsQuote
    {
        [Parameter] public RenderFragment? Quote { get; set; }
        [Parameter] public RenderFragment? Citation { get; set; }
    }
}