#pragma checksum "/Users/johanlitsfeldt/blazor/jhn/Shared/NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dbfdbd3e407e95f5d1be4d67c738caa44a2548fe"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace jhn.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "/Users/johanlitsfeldt/blazor/jhn/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "/Users/johanlitsfeldt/blazor/jhn/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 3 "/Users/johanlitsfeldt/blazor/jhn/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 4 "/Users/johanlitsfeldt/blazor/jhn/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 5 "/Users/johanlitsfeldt/blazor/jhn/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 6 "/Users/johanlitsfeldt/blazor/jhn/_Imports.razor"
using jhn;

#line default
#line hidden
#line 7 "/Users/johanlitsfeldt/blazor/jhn/_Imports.razor"
using jhn.Shared;

#line default
#line hidden
    public class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#line 28 "/Users/johanlitsfeldt/blazor/jhn/Shared/NavMenu.razor"
       
    bool collapseNavMenu = true;

    string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }

#line default
#line hidden
    }
}
#pragma warning restore 1591
