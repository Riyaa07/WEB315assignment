#pragma checksum "C:\Users\riyak\Downloads\ASP.NET\Food\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "576d6fdd744b0a8e5bbf0349ac4830305f4db50c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Food.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace Food.Pages
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
#line 1 "C:\Users\riyak\Downloads\ASP.NET\Food\Pages\_ViewImports.cshtml"
using Food;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"576d6fdd744b0a8e5bbf0349ac4830305f4db50c", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"366608645be6eeaa0ca5eeb131a4a1f3cf0bdc53", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\riyak\Downloads\ASP.NET\Food\Pages\Index.cshtml"
  
    ViewData["Title"] = "Food";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\riyak\Downloads\ASP.NET\Food\Pages\Index.cshtml"
  
    var quote = "Good Food Good Mood";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div>");
#nullable restore
#line 10 "C:\Users\riyak\Downloads\ASP.NET\Food\Pages\Index.cshtml"
Write(quote);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 11 "C:\Users\riyak\Downloads\ASP.NET\Food\Pages\Index.cshtml"
  
    quote=" 7 Billion people but what shall I do I care only about food. -  Foodieeria";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div>");
#nullable restore
#line 14 "C:\Users\riyak\Downloads\ASP.NET\Food\Pages\Index.cshtml"
Write(quote);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n");
#nullable restore
#line 16 "C:\Users\riyak\Downloads\ASP.NET\Food\Pages\Index.cshtml"
  
    var Foodblog = new []{
        new{
            name = "panipuri",
            calories = "150-180",
            origin = "India"
        },
        new{
            name = "fafda jalebi",
            calories = "750",
            origin = "Gujarat,India"
        },
        new{
            name = "aloo paratha",
            calories = "180",
            origin = "Punjab,India"
        },
        new{
            name = "idli sambhar",
            calories = "130",
            origin = "Tamil Nadu,India"
        },
        new{
            name = "rosogolla",
            calories = "186",
            origin = "West Bengal,India"
        }
    };

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 46 "C:\Users\riyak\Downloads\ASP.NET\Food\Pages\Index.cshtml"
 for (var i =0; i < Foodblog.Length; i++)
{
    var Food = Foodblog[i];
    

#line default
#line hidden
#nullable disable
            WriteLiteral("Food name : ");
#nullable restore
#line 49 "C:\Users\riyak\Downloads\ASP.NET\Food\Pages\Index.cshtml"
                 Write(Food.name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br>");
#nullable restore
#line 49 "C:\Users\riyak\Downloads\ASP.NET\Food\Pages\Index.cshtml"
                                            
    var Calories = Foodblog[i];
    

#line default
#line hidden
#nullable disable
            WriteLiteral("Calories : ");
#nullable restore
#line 51 "C:\Users\riyak\Downloads\ASP.NET\Food\Pages\Index.cshtml"
                Write(Calories.calories);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br>");
#nullable restore
#line 51 "C:\Users\riyak\Downloads\ASP.NET\Food\Pages\Index.cshtml"
                                                   
    var Origin = Foodblog[i];
    

#line default
#line hidden
#nullable disable
            WriteLiteral("Origin : ");
#nullable restore
#line 53 "C:\Users\riyak\Downloads\ASP.NET\Food\Pages\Index.cshtml"
              Write(Origin.origin);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br>");
#nullable restore
#line 53 "C:\Users\riyak\Downloads\ASP.NET\Food\Pages\Index.cshtml"
                                             
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\"><strong>Welcome</strong></h1>\r\n    <p>The current time on server is ");
#nullable restore
#line 58 "C:\Users\riyak\Downloads\ASP.NET\Food\Pages\Index.cshtml"
                                Write(Model.todaysDate);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n    <p>");
            WriteLiteral("@Username</p>\r\n    <p>email me at RS374");
            WriteLiteral("@myscc.ca </p>\r\n    &nbsp;\r\n    &lt;\r\n    <p>");
#nullable restore
#line 63 "C:\Users\riyak\Downloads\ASP.NET\Food\Pages\Index.cshtml"
  Write(DateTime.IsLeapYear(2016));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>Last week this time: ");
#nullable restore
#line 64 "C:\Users\riyak\Downloads\ASP.NET\Food\Pages\Index.cshtml"
                        Write(DateTime.Now - TimeSpan.FromDays(7));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    ");
#nullable restore
#line 65 "C:\Users\riyak\Downloads\ASP.NET\Food\Pages\Index.cshtml"
Write("<span>Hello span</span>");

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
