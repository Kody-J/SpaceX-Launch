#pragma checksum "C:\SpaceX-Launch\SpaceX-Launch\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c1c2e21bafe1fe865c3788795580de1a99fb8c09"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\SpaceX-Launch\SpaceX-Launch\Views\_ViewImports.cshtml"
using SpaceX_Launch;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\SpaceX-Launch\SpaceX-Launch\Views\_ViewImports.cshtml"
using SpaceX_Launch.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c1c2e21bafe1fe865c3788795580de1a99fb8c09", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3fc127e7706db90648bae09923b01eb775151f92", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\SpaceX-Launch\SpaceX-Launch\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>

    #launchTable {
        font-size: 14pt;
        text-align: center;
        box-shadow: 5px 5px 20px #808080;
    }

        #launchTable th {
            background-color: blue;
            color: white;
        }
</style>



");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c1c2e21bafe1fe865c3788795580de1a99fb8c093473", async() => {
                WriteLiteral(@"
    <div class=""text-center"">
        <h1 class=""display-4"">SpaceX Launch</h1>
        <p>Learn about each mission SpaceX conducts and get excited about space travel with SpaceX Launch!</p>
    </div>

    <div class=""row"">
        <div class=""col-md-12"">
            <table class=""table table-striped table-bordered table-sm"" id=""launchTable"" cellspacing=""0"">
                <thead>
                    <tr>
                        <th class=""th-md"" style=""text-align: center"">Launch Date</th>
                        <th class=""th-md"" style=""text-align: center"">Launch Time (CDT/CST)</th>
                        <th class=""th-md"" style=""text-align: center"">Rocket Name</th>
                        <th class=""th-md"" style=""text-align: center"">Launch Success</th>
                        <th class=""th-md"" style=""text-align: center"">Payload Mass (kg)</th>
                        <th class=""th-md"" style=""text-align: center"">Payload Rank</th>
                    </tr>
                </thead>
       ");
                WriteLiteral("         <tbody>\r\n");
#nullable restore
#line 42 "C:\SpaceX-Launch\SpaceX-Launch\Views\Home\Index.cshtml"
                     for (var index = (ViewBag.launchDetails.Count - 1); index >= 0; index--)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <tr>\r\n                            <td>\r\n                                ");
#nullable restore
#line 46 "C:\SpaceX-Launch\SpaceX-Launch\Views\Home\Index.cshtml"
                           Write(ViewBag.launchDetails[index].LaunchDate);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 49 "C:\SpaceX-Launch\SpaceX-Launch\Views\Home\Index.cshtml"
                           Write(ViewBag.launchDetails[index].LaunchTime);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 52 "C:\SpaceX-Launch\SpaceX-Launch\Views\Home\Index.cshtml"
                           Write(ViewBag.launchDetails[index].RocketName);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 55 "C:\SpaceX-Launch\SpaceX-Launch\Views\Home\Index.cshtml"
                           Write(ViewBag.launchDetails[index].LaunchStatus);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n");
#nullable restore
#line 58 "C:\SpaceX-Launch\SpaceX-Launch\Views\Home\Index.cshtml"
                                 if (ViewBag.launchDetails[index].PayloadMass != 0)
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 59 "C:\SpaceX-Launch\SpaceX-Launch\Views\Home\Index.cshtml"
                               Write(ViewBag.launchDetails[index].PayloadMass);

#line default
#line hidden
#nullable disable
                WriteLiteral("                            </td>\r\n                            <td id=\"payLoadRank\">\r\n");
#nullable restore
#line 62 "C:\SpaceX-Launch\SpaceX-Launch\Views\Home\Index.cshtml"
                                 if (ViewBag.launchDetails[index].PayloadRank != 0)
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 63 "C:\SpaceX-Launch\SpaceX-Launch\Views\Home\Index.cshtml"
                               Write(ViewBag.launchDetails[index].PayloadRank);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 67 "C:\SpaceX-Launch\SpaceX-Launch\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                </tbody>
                <tfoot>
                    <tr>
                        <th></th>
                        <th></th>
                        <th></th>
                        <th></th>
                        <th></th>
                        <th></th>
                    </tr>
                </tfoot>
            </table>
        </div>
    </div>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
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
