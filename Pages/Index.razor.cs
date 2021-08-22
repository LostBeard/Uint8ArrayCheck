
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace Uint8ArrayCheck.Pages;
public class IndexBase : ComponentBase
{
    [Inject]
    IJSRuntime js { get; set; }
    protected override void OnAfterRender(bool firstRender)
    {
        base.OnAfterRender(firstRender);
        if (firstRender)
        {
            var byteArray = new byte[] { 1, 3, 5  };
            js.InvokeVoidAsync("uint8arrayTest", byteArray);
        }
    }
}
