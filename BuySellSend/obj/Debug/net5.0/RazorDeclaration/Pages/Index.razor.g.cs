// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BuySellSend.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Yauch\Documents\GitHub\BuySell\BuySellSend\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Yauch\Documents\GitHub\BuySell\BuySellSend\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Yauch\Documents\GitHub\BuySell\BuySellSend\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Yauch\Documents\GitHub\BuySell\BuySellSend\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Yauch\Documents\GitHub\BuySell\BuySellSend\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Yauch\Documents\GitHub\BuySell\BuySellSend\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Yauch\Documents\GitHub\BuySell\BuySellSend\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Yauch\Documents\GitHub\BuySell\BuySellSend\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Yauch\Documents\GitHub\BuySell\BuySellSend\_Imports.razor"
using BuySellSend;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Yauch\Documents\GitHub\BuySell\BuySellSend\_Imports.razor"
using BuySellSend.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Yauch\Documents\GitHub\BuySell\BuySellSend\Pages\Index.razor"
using BuySell.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Yauch\Documents\GitHub\BuySell\BuySellSend\Pages\Index.razor"
using BuySell;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Yauch\Documents\GitHub\BuySell\BuySellSend\Pages\Index.razor"
using BuySellSend.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 24 "C:\Users\Yauch\Documents\GitHub\BuySell\BuySellSend\Pages\Index.razor"
      
    private StockRequestModel stockRequest = new StockRequestModel();
    
    private async Task PublishMesage()
    {
        stockRequest.StockWebsiteRequest();
        DataStoreModel dataStore = stockRequest.outputStock;
        ImplementInvest investor = new ImplementInvest(dataStore);
        string result = investor.BuySellStorage();
        //Call it stock for general stock
        await queue.SendMessageAsync(result, "Stock");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IQueueService queue { get; set; }
    }
}
#pragma warning restore 1591
