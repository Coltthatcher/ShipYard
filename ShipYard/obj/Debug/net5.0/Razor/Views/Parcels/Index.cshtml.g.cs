#pragma checksum "C:\Users\coltt\OneDrive\Desktop\ParcelC#\ShipYard.Solution\ShipYard\Views\Parcels\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f276b64156ba6866198d71628df3f2d30f790d00"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Parcels_Index), @"mvc.1.0.view", @"/Views/Parcels/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\coltt\OneDrive\Desktop\ParcelC#\ShipYard.Solution\ShipYard\Views\Parcels\Index.cshtml"
using ShipYard.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f276b64156ba6866198d71628df3f2d30f790d00", @"/Views/Parcels/Index.cshtml")]
    public class Views_Parcels_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1>Ship Yard Parcels</h1>\r\n");
#nullable restore
#line 4 "C:\Users\coltt\OneDrive\Desktop\ParcelC#\ShipYard.Solution\ShipYard\Views\Parcels\Index.cshtml"
 if (Model.Count == 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("  <p>There are no parcels in your order</p>\r\n");
#nullable restore
#line 7 "C:\Users\coltt\OneDrive\Desktop\ParcelC#\ShipYard.Solution\ShipYard\Views\Parcels\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<ul>\r\n");
#nullable restore
#line 9 "C:\Users\coltt\OneDrive\Desktop\ParcelC#\ShipYard.Solution\ShipYard\Views\Parcels\Index.cshtml"
   foreach (Parcel parcel in Model)
  { 

#line default
#line hidden
#nullable disable
            WriteLiteral("    <li>Length: ");
#nullable restore
#line 11 "C:\Users\coltt\OneDrive\Desktop\ParcelC#\ShipYard.Solution\ShipYard\Views\Parcels\Index.cshtml"
           Write(parcel.Length);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </li>\r\n    <li>Width: ");
#nullable restore
#line 12 "C:\Users\coltt\OneDrive\Desktop\ParcelC#\ShipYard.Solution\ShipYard\Views\Parcels\Index.cshtml"
          Write(parcel.Width);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </li>\r\n    <li>Height: ");
#nullable restore
#line 13 "C:\Users\coltt\OneDrive\Desktop\ParcelC#\ShipYard.Solution\ShipYard\Views\Parcels\Index.cshtml"
           Write(parcel.Height);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </li>\r\n    <li>Weight: ");
#nullable restore
#line 14 "C:\Users\coltt\OneDrive\Desktop\ParcelC#\ShipYard.Solution\ShipYard\Views\Parcels\Index.cshtml"
           Write(parcel.Weight);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </li>\r\n    <li>Volume: ");
#nullable restore
#line 15 "C:\Users\coltt\OneDrive\Desktop\ParcelC#\ShipYard.Solution\ShipYard\Views\Parcels\Index.cshtml"
           Write(parcel.Volume);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n    <li>The cost to ship your parcel is <br> $");
#nullable restore
#line 16 "C:\Users\coltt\OneDrive\Desktop\ParcelC#\ShipYard.Solution\ShipYard\Views\Parcels\Index.cshtml"
                                         Write(parcel.Cost);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n    <h2>===========</h2>\r\n");
#nullable restore
#line 18 "C:\Users\coltt\OneDrive\Desktop\ParcelC#\ShipYard.Solution\ShipYard\Views\Parcels\Index.cshtml"
    
  }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>\r\n<a href=\"/parcels/new\">Add a new parcel.</a>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
