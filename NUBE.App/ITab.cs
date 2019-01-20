using Microsoft.AspNetCore.Blazor;

namespace NUBE.App
{
    public interface ITab
    {
        RenderFragment ChildContent { get; }
    }
}
