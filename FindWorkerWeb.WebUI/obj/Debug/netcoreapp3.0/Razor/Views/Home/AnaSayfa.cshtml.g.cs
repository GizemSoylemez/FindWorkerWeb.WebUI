#pragma checksum "C:\Users\gizem\Desktop\Yeni klasör (2)\Web\FindWorkerWeb.WebUI\FindWorkerWeb.WebUI\Views\Home\AnaSayfa.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f576ce97fe27f46ccf675103d6447c455450c20b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_AnaSayfa), @"mvc.1.0.view", @"/Views/Home/AnaSayfa.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f576ce97fe27f46ccf675103d6447c455450c20b", @"/Views/Home/AnaSayfa.cshtml")]
    public class Views_Home_AnaSayfa : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/pp.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\gizem\Desktop\Yeni klasör (2)\Web\FindWorkerWeb.WebUI\FindWorkerWeb.WebUI\Views\Home\AnaSayfa.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n<!DOCTYPE html>\r\n<html lang=\"fr\">\r\n<meta http-equiv=\"content-type\" content=\"text/html;charset=utf-8\" />\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f576ce97fe27f46ccf675103d6447c455450c20b3609", async() => {
                WriteLiteral(@"
    <meta charset=""utf-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1, maximum-scale=1, user-scalable=no"">
    <title>FİND WORK-ER</title>
    <link rel=""icon"" type=""/image/png"" href=""favicon-32x32.png"" sizes=""32x32"">
    <link rel=""icon"" type=""/image/png"" href=""favicon-16x16.png"" sizes=""16x16"">
    <!--Bootstrap -->
    <link href=""/css/bootstrap.min.css"" rel=""stylesheet"">
    <link href=""/css/glyphicons.css"" rel=""stylesheet"">
    <link rel=""stylesheet"" href=""/css/glyphicons-social.css"" type=""text/css"">
    <link href=""/css/register.css"" rel=""stylesheet"">
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</style>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f576ce97fe27f46ccf675103d6447c455450c20b5294", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f576ce97fe27f46ccf675103d6447c455450c20b5556", async() => {
                    WriteLiteral(@"
        <div class=""home_background"">
            <div style=""overflow: hidden"" class=""top_background"">
                <div class=""top clearfix"">
                    <div class=""logo left"">
                        <div class=""homepage_logo"">
                            <a href=""index.html"">FindWorker</a>
                        </div>
                    </div>
                    <div class=""top_right right clearfix"">
                        <a href=""/Login/Register"" class=""top_signup_button left"">Kayıt Ol</a>
                        <div class=""dropdown pull-left"">
                            <a href=""login.html"" id=""dLabel"" data-target=""#"" data-backdrop=""false"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"" class=""top_login_button left"">Giriş Yap</a>
                            <ul role=""form"" aria-labelledby=""dLabel"" class=""dropdown-menu pull-right"">
                                <form role=""form"" method=""POST"" action=""/Login/Login"" id=""login-form"" class=""form-signin"">");
                    WriteLiteral("\r\n                                    <div class=\"homepage_input\">\r\n                                        <input type=\"text\" name=\"Email\" placeholder=\"Email\"");
                    BeginWriteAttribute("value", " value=\"", 2030, "\"", 2038, 0);
                    EndWriteAttribute();
                    WriteLiteral(@" autofocus class=""form-control"">
                                    </div>
                                    <div class=""homepage_input"">
                                        <input type=""password"" name=""Password"" placeholder=""Şifre"" class=""form-control"">
                                    </div>
                                    <button type=""submit"" class=""btn btn-primary btn-block submit"">Giriş Yap</button>
                                </form>
                            </ul>
                        </div>
                    </div>
                </div>
                <div class=""clearfix"">
                    <div class=""homepage_intro"">
                        <div class=""top_message"">
                            <h1>Örnek Cv'ler ile kendi Cv'ni hemen yarat.</h1>
                            <p> Gizem ve Beyda tarafından oluşturulan Cv oluşturma sitesine Hoşgeldiniz. Umarım size yardımcı oluruz kolay gelsin. </p>
                        </div>

                    </div>");
                    WriteLiteral(@"
                    <div class=""browser"">
                        <div class=""browser_top_bar"">
                            <div class=""url_back"">
                                <div class=""pull-left ssl-lock"">
                                </div>
                                <div class=""pull-left ssl-url-text"">
                                    <span class=""trust_color"">https://</span>
                                    <span class=""trust_url"">findworker.com/</span>
                                    <span class=""findworker_username""></span>
                                    <span class=""cursor_i"" style=""display: inline; opacity: 0.833006;"">| </span>
                                </div>
                            </div>
                        </div>
                        <div class=""example_cv"" style=""display:inline-block"" >
                            ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f576ce97fe27f46ccf675103d6447c455450c20b9283", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\">\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n\r\n\r\n        </div>\r\n    ");
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
                WriteLiteral(@"
    <script src=""/js0/i18n-client3e25.js?q=non|follow_btn,follow_active_btn,apply_then_no_html"">
    </script>
    <script src=""/js/jquery.min.js""></script>
    <script src=""/js/d.js""></script>
    <script src=""/js/bootstrap.min.js""></script>
    <style>
        .footer {
            display: none
        }
    </style>
    <script src=""/js/homepage.js""></script>
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
            WriteLiteral("\r\n\r\n</html>\r\n");
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
