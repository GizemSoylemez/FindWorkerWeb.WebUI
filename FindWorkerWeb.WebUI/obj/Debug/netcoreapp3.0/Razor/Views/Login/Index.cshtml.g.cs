#pragma checksum "C:\Users\gizem\Desktop\FindWorkerWeb.WebUI\FindWorkerWeb.WebUI\Views\Login\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b632a126250c77a0d854c8496a3f5c17e4a27c93"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Login_Index), @"mvc.1.0.view", @"/Views/Login/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b632a126250c77a0d854c8496a3f5c17e4a27c93", @"/Views/Login/Index.cshtml")]
    public class Views_Login_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("inside"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\gizem\Desktop\FindWorkerWeb.WebUI\FindWorkerWeb.WebUI\Views\Login\Index.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n<meta http-equiv=\"content-type\" content=\"text/html;charset=utf-8\" />\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b632a126250c77a0d854c8496a3f5c17e4a27c933349", async() => {
                WriteLiteral(@"
    <meta charset=""utf-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1, maximum-scale=1, user-scalable=no"">
    <meta name=""csrf-token"" content=""R68ot0k1-6LVMrGFSg9PJXZmYy05c18UdQCs"">
    <title>Giriş Yap</title>
    <link rel=""icon"" type=""image/png"" href=""favicon-32x32.png"" sizes=""32x32"">
    <link rel=""icon"" type=""image/png"" href=""favicon-16x16.png"" sizes=""16x16"">
    <!--Bootstrap -->
    <link href=""/css/bootstrap.min.css"" rel=""stylesheet"">
    <link href=""/css/glyphicons.css"" rel=""stylesheet"">
    <link rel=""stylesheet"" href=""css/glyphicons-social.css"" type=""text/css"">
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b632a126250c77a0d854c8496a3f5c17e4a27c935093", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b632a126250c77a0d854c8496a3f5c17e4a27c935355", async() => {
                    WriteLiteral(@"
        <nav role=""navigation"" class=""navbar navbar-inverse navbar-fixed-top"">
            <div class=""container"">
                <div class=""navbar-header"">
                    <button type=""button"" data-toggle=""collapse"" data-target=""#bs-example-navbar-collapse-1"" class=""navbar-toggle collapsed"">
                        <span class=""sr-only"">Toggle navigation</span>
                        <span class=""icon-bar""></span>
                        <span class=""icon-bar""></span>
                        <span class=""icon-bar""></span>
                    </button><a href=""index.html"" class=""logo_inside"">FİNDWORK-ER</a>
                </div>
                <div id=""bs-example-navbar-collapse-1"" style=""background: #444"" class=""collapse navbar-collapse"">
                    <ul class=""nav navbar-nav navbar-right"">
                        <li><a href=""/Login/Register"">Kayıt Ol</a></li>
                        <li><a href=""/Login/Index"">Giriş Yap</a></li>
                        <li></li>
          ");
                    WriteLiteral(@"          </ul>
                </div>
            </div>
        </nav>
        <div class=""inside_box_mycv"">
            <div class=""top_message"">
                <h1>Giriş Yap</h1>
            </div>
            <div style=""margin: 0 auto;"" class=""homepage_signup"">

                <form action=""/Login/Login"" method=""POST"" id=""Kayıt Ol""");
                    BeginWriteAttribute("style", " style=\"", 2290, "\"", 2298, 0);
                    EndWriteAttribute();
                    WriteLiteral(@">
                    <input type=""hidden"" name=""_csrf"" value=""R68ot0k1-6LVMrGFSg9PJXZmYy05c18UdQCs"">
                    <div class=""homepage_input form-group"">
                        <input type=""text"" name=""Email"" placeholder=""E-Mail "" class=""form-control"">
                        <span class=""help-block""> </span>
                    </div>

                    <div class=""homepage_input form-group"">
                        <input type=""password"" name=""password"" placeholder=""Şifre (minimum 6 karakter)"" class=""form-control"">
                    </div>
                    <div class=""homepage_input form-group"">
                        <input type=""submit"" value=""Giriş Yap"" style=""padding: 0"" class=""form-control homepage_signup_button"">
                    </div>

                </form>

            </div>
        </div>
    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    <div id=\"jobShareModal\" tabindex=\"-1\" role=\"dialog\"");
                BeginWriteAttribute("aria-labelledby", " aria-labelledby=\"", 3220, "\"", 3238, 0);
                EndWriteAttribute();
                WriteLiteral(@" aria-hidden=""true"" class=""modal fade"">
        <div class=""modal-dialog"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <button type=""button"" data-dismiss=""modal"" class=""close"">
                        <span aria-hidden=""true"">×</span><span class=""sr-only"">Close</span>
                    </button>
                    <h4 class=""modal-title"">Share</h4>
                </div>

            </div>
        </div>
    </div>
    <div class=""footer""></div>
    <script src=""/js0/i18n-client3e25.js?q=non|follow_btn,follow_active_btn,apply_then_no_html""></script>
    <script src=""/js/jquery.min.js""></script>
    <script src=""/js/d.js""></script>
    <script src=""/js/bootstrap.min.js""></script>
    <style>
        .fv-form-bootstrap .help-block {
            text-align: left
        }

        .fv-form-bootstrap .fv-icon-no-label {
            top: 5px !important;
        }
    </style>
    <script src=""/js0/i18n-client1474.js?q=i18n_fo");
                WriteLiteral(@"rm_errors|required,email_type,email_use_error,password_six_cr"">
    </script>
    <link href=""/css/formValidation.min.css"" rel=""stylesheet"">
    <script src=""/js/formValidation.min.js""></script>
    <script src=""/js/framework/bootstrap.min.js"">
    </script>
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
            WriteLiteral("\r\n</html>");
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