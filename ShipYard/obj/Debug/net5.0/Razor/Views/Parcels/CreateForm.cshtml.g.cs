#pragma checksum "C:\Users\coltt\OneDrive\Desktop\ParcelC#\ShipYard.Solution\ShipYard\Views\Parcels\CreateForm.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6774a67795631ebf4889e7dd48abdd77eb6fff20"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Parcels_CreateForm), @"mvc.1.0.view", @"/Views/Parcels/CreateForm.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6774a67795631ebf4889e7dd48abdd77eb6fff20", @"/Views/Parcels/CreateForm.cshtml")]
    public class Views_Parcels_CreateForm : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<form action=""/parcels"" method=""post"">
  <label for=""length"">Add the length of you parcel in inches</label>
  <input id=""length"" name=""length"" type=""text"">

  <label for=""width"">Add the width of you parcel in inches</label>
  <input id=""width"" name=""width"" type=""text"">

  <label for=""height"">Add the height of you parcel in inches</label>
  <input id=""height"" name=""height"" type=""text"">

  <label for=""weight"">Add the weight of you parcel in pounds</label>
  <input id=""weight"" name=""weight"" type=""text"">

  <button type=""submit"">Submit</button>
</form>");
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
