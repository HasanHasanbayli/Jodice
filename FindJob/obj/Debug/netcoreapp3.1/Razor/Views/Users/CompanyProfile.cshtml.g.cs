#pragma checksum "C:\Users\Hasan Hasanbayli\Desktop\FindJob\FindJob\Views\Users\CompanyProfile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "105cbd096d1cfafebf3cbb97b256c48dcfd2e15d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Users_CompanyProfile), @"mvc.1.0.view", @"/Views/Users/CompanyProfile.cshtml")]
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
#line 2 "C:\Users\Hasan Hasanbayli\Desktop\FindJob\FindJob\Views\_ViewImports.cshtml"
using FindJob.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Hasan Hasanbayli\Desktop\FindJob\FindJob\Views\_ViewImports.cshtml"
using FindJob.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"105cbd096d1cfafebf3cbb97b256c48dcfd2e15d", @"/Views/Users/CompanyProfile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c244eaceb285b2f481d71d6b8938f7e88b2ee52e", @"/Views/_ViewImports.cshtml")]
    public class Views_Users_CompanyProfile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AppUser>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/images/Users/prof.PNG"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("brand logo"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/images/c-logo-01.webp"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/images/c-logo-02.webp"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Hasan Hasanbayli\Desktop\FindJob\FindJob\Views\Users\CompanyProfile.cshtml"
  
    ViewData["Title"] = "CompanyProfile";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<header class=""header_01 header_inner"">
    <div class=""header_main header_job_single_main"">
        <div class=""header_btm header_job_single"">
            <div class=""header_job_single_inner container"">
                <div class=""poster_company"">
");
#nullable restore
#line 11 "C:\Users\Hasan Hasanbayli\Desktop\FindJob\FindJob\Views\Users\CompanyProfile.cshtml"
                     if (Model.Image != null)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "105cbd096d1cfafebf3cbb97b256c48dcfd2e15d5684", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 433, "~/assets/images/Users/", 433, 22, true);
#nullable restore
#line 13 "C:\Users\Hasan Hasanbayli\Desktop\FindJob\FindJob\Views\Users\CompanyProfile.cshtml"
AddHtmlAttributeValue("", 455, Model.Image, 455, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 14 "C:\Users\Hasan Hasanbayli\Desktop\FindJob\FindJob\Views\Users\CompanyProfile.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "105cbd096d1cfafebf3cbb97b256c48dcfd2e15d7554", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 18 "C:\Users\Hasan Hasanbayli\Desktop\FindJob\FindJob\Views\Users\CompanyProfile.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n                <div class=\"poster_details\">\r\n                    <h2>");
#nullable restore
#line 21 "C:\Users\Hasan Hasanbayli\Desktop\FindJob\FindJob\Views\Users\CompanyProfile.cshtml"
                   Write(Model.CompanyName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" <span class=""varified""><i class=""fas fa-check""></i>Verified</span></h2>
                    <h5>About company</h5>
                    <ul>
                        <li>
                            <div class=""staff_rating"">
                                <span>4.9</span>
                                <i class=""fas fa-star""></i>
                                <i class=""fas fa-star""></i>
                                <i class=""fas fa-star""></i>
                                <i class=""fas fa-star""></i>
                                <i class=""fas fa-star-half-alt""></i>
                            </div>
                        </li>
                        <li>
                            <i class=""fas fa-map-marker-alt""></i>
                            ");
#nullable restore
#line 36 "C:\Users\Hasan Hasanbayli\Desktop\FindJob\FindJob\Views\Users\CompanyProfile.cshtml"
                       Write(Model.Location);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" & 15 more
                        </li>
                        <li>
                            <i class=""far fa-clock""></i>
                            Since 2005
                        </li>
                    </ul>
                </div>
            </div>
        </div>
    </div>
</header>
<main>
    <div class=""single_job"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-md-12"">
                    <div class=""row "">
                        <div class=""col-md-12 single_job_main"">
                            <h2>About Company</h2>
                            <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur eget vestibulum ante, sit amet blandit tellus. Pellentesque sit amet viverra lorem. Sed non diam egestas ex aliquam feugiat. Nullam urna mauris, rutrum sed erat quis, gravida scelerisque enim. Cras dapibus orci magna, sit amet fringilla est porttitor sit amet. Proin eget justo mauris. Proin leo urna, ornare quis ");
            WriteLiteral(@"lacus id, pretium ullamcorper libero. Suspendisse congue tortor pellentesque diam accumsan, vel dictum tellus tincidunt. Vivamus dapibus dignissim posuere. Aliquam eget sem semper, feugiat mauris eget, convallis nisi. Curabitur interdum, mi vitae commodo mattis, lacus erat aliquet urna, ut malesuada elit quam quis justo. </p>
                            <p> Quisque aliquet eros libero. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Nunc vitae sapien sit amet ante mattis laoreet. Sed at quam quis ligula suscipit iaculis in tempus diam. Cras pulvinar facilisis commodo. Interdum et malesuada fames ac ante ipsum primis in faucibus. Aenean a leo eget felis porta pharetra. Donec vitae metus metus. Fusce pharetra turpis non felis laoreet cursus. </p>
                            <p> Suspendisse potenti. Suspendisse efficitur augue enim, a aliquet nunc malesuada sit amet. Praesent finibus egestas velit sit amet lobortis. Aliquam ultricies tempus facilisis. Sed maximus, ");
            WriteLiteral(@"turpis eu pharetra fringilla, sem tellus pharetra lorem, at dictum tortor libero sit amet nulla. Cras quis enim vitae enim congue elementum. Integer tincidunt sit amet nulla at ultricies. Mauris id hendrerit urna. </p>
                        </div>
                        <div class=""section-divider""></div>
                        <div class=""col-md-12 single_job_main"">
                            <h2>Location</h2>
                            <iframe class=""full-width-iframe"" src=""https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3428.916507434128!2d76.78322631470263!3d30.748846681631466!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x390fed76ab9f14c1%3A0xd6362b158b8994aa!2sEiffel%20Tower%20Replica!5e0!3m2!1sen!2sin!4v1581932177674!5m2!1sen!2sin"" height=""300""");
            BeginWriteAttribute("allowfullscreen", " allowfullscreen=\"", 4385, "\"", 4403, 0);
            EndWriteAttribute();
            WriteLiteral(@"></iframe>
                        </div>
                        <div class=""section-divider""></div>
                        <div class=""col-md-12 single_job_main"">
                            <h2> Open Positions</h2>
                            <div class=""row two_col featured_box_outer"">
                                <div class=""col-sm-6"">
                                    <div class=""featured_box "">
                                        <div class=""fb_image"">
                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "105cbd096d1cfafebf3cbb97b256c48dcfd2e15d13899", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                        </div>
                                        <div class=""fb_content"">
                                            <h4>2000 Words English to German</h4>
                                            <ul>
                                                <li>
                                                    <a href=""#"">
                                                        <i class=""fas fa-landmark""></i>
                                                        Magna Aliqua
                                                    </a>
                                                </li>
                                                <li>
                                                    <a href=""#"">
                                                        <i class=""fas fa-map-marker-alt""></i>
                                                        New York
                                                    </a>
                                            ");
            WriteLiteral(@"    </li>
                                                <li>
                                                    <a href=""#"">
                                                        <i class=""far fa-clock""></i>
                                                        2 days ago
                                                    </a>
                                                </li>
                                            </ul>
                                        </div>
                                        <div class=""fb_action"">
                                            <a title=""add to favourite"" href=""#""><i class=""far fa-heart""></i></a>
                                            <a class=""btn btn-third"" href=""#"">Apply Now</a>
                                        </div>
                                    </div>
                                </div>
                                <div class=""col-sm-6"">
                                    <div class=""featured_box "">
 ");
            WriteLiteral("                                       <div class=\"fb_image\">\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "105cbd096d1cfafebf3cbb97b256c48dcfd2e15d17263", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                        </div>
                                        <div class=""fb_content"">
                                            <h4>Fix Python Selenium Code</h4>
                                            <ul>
                                                <li>
                                                    <a href=""#"">
                                                        <i class=""fas fa-landmark""></i>
                                                        Magna Aliqua
                                                    </a>
                                                </li>
                                                <li>
                                                    <a href=""#"">
                                                        <i class=""fas fa-map-marker-alt""></i>
                                                        New York
                                                    </a>
                                                ");
            WriteLiteral(@"</li>
                                                <li>
                                                    <a href=""#"">
                                                        <i class=""far fa-clock""></i>
                                                        3 days ago
                                                    </a>
                                                </li>
                                            </ul>
                                        </div>
                                        <div class=""fb_action"">
                                            <a title=""add to favourite"" href=""#""><i class=""fas fa-heart""></i></a>
                                            <a class=""btn btn-third"" href=""#"">Apply Now</a>
                                        </div>
                                    </div>
                                </div>

                            </div>
                        </div>
                    </div>
                </div>
    ");
            WriteLiteral("        </div>\r\n        </div>\r\n    </div>\r\n</main>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AppUser> Html { get; private set; }
    }
}
#pragma warning restore 1591