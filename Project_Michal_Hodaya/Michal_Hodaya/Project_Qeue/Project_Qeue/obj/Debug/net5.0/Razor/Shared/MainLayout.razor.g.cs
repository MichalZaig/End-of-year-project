#pragma checksum "C:\מיכל פרטי\פרוייקט סוף שנה\Project_Michal_Hodaya\Michal_Hodaya\Project_Qeue\Project_Qeue\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f49e1d498a9987ec42b76a99c4ea5f80d0711f9a"
// <auto-generated/>
#pragma warning disable 1591
namespace Project_Qeue.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\מיכל פרטי\פרוייקט סוף שנה\Project_Michal_Hodaya\Michal_Hodaya\Project_Qeue\Project_Qeue\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\מיכל פרטי\פרוייקט סוף שנה\Project_Michal_Hodaya\Michal_Hodaya\Project_Qeue\Project_Qeue\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\מיכל פרטי\פרוייקט סוף שנה\Project_Michal_Hodaya\Michal_Hodaya\Project_Qeue\Project_Qeue\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\מיכל פרטי\פרוייקט סוף שנה\Project_Michal_Hodaya\Michal_Hodaya\Project_Qeue\Project_Qeue\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\מיכל פרטי\פרוייקט סוף שנה\Project_Michal_Hodaya\Michal_Hodaya\Project_Qeue\Project_Qeue\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\מיכל פרטי\פרוייקט סוף שנה\Project_Michal_Hodaya\Michal_Hodaya\Project_Qeue\Project_Qeue\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\מיכל פרטי\פרוייקט סוף שנה\Project_Michal_Hodaya\Michal_Hodaya\Project_Qeue\Project_Qeue\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\מיכל פרטי\פרוייקט סוף שנה\Project_Michal_Hodaya\Michal_Hodaya\Project_Qeue\Project_Qeue\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\מיכל פרטי\פרוייקט סוף שנה\Project_Michal_Hodaya\Michal_Hodaya\Project_Qeue\Project_Qeue\_Imports.razor"
using Project_Qeue;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\מיכל פרטי\פרוייקט סוף שנה\Project_Michal_Hodaya\Michal_Hodaya\Project_Qeue\Project_Qeue\_Imports.razor"
using Project_Qeue.Shared;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "main");
            __builder.AddAttribute(2, "b-meh1nhdjp4");
            __builder.OpenComponent<Project_Qeue.Shared.NavMenu>(3);
            __builder.CloseComponent();
            __builder.AddMarkupContent(4, "\r\n    ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "content px-4");
            __builder.AddAttribute(7, "b-meh1nhdjp4");
            __builder.OpenComponent<Project_Qeue.Shared.LoginDisplay>(8);
            __builder.CloseComponent();
            __builder.AddMarkupContent(9, "\r\n        ");
#nullable restore
#line 8 "C:\מיכל פרטי\פרוייקט סוף שנה\Project_Michal_Hodaya\Michal_Hodaya\Project_Qeue\Project_Qeue\Shared\MainLayout.razor"
__builder.AddContent(10, Body);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
