#pragma checksum "C:\Users\gizem\Desktop\Web Projesi\FindWorkerWeb.WebUI\FindWorkerWeb.WebUI\Views\Login\Register.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d1cae5182f933e3c5bc95710666985d9b8b89413"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Login_Register), @"mvc.1.0.view", @"/Views/Login/Register.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d1cae5182f933e3c5bc95710666985d9b8b89413", @"/Views/Login/Register.cshtml")]
    public class Views_Login_Register : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FindWorkerWeb.WebUI.Models.RegisterModel>
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
#line 2 "C:\Users\gizem\Desktop\Web Projesi\FindWorkerWeb.WebUI\FindWorkerWeb.WebUI\Views\Login\Register.cshtml"
  
    Layout = null;


#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d1cae5182f933e3c5bc95710666985d9b8b894133346", async() => {
                WriteLiteral(@"
    <meta charset=""utf-8"">
    <meta http-equiv=""content-type"" content=""text/html;charset=utf-8"" />
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1, maximum-scale=1, user-scalable=no"">
    <meta name=""csrf-token"" content=""R68ot0k1-6LVMrGFSg9PJXZmYy05c18UdQCs"">
    <title>Kayıt Ol</title>
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d1cae5182f933e3c5bc95710666985d9b8b894135170", async() => {
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
                </ul>
            </div>
        </div>
    </nav>");
                WriteLiteral(@"
    <div class=""inside_box_mycv"">
        <div class=""top_message"">
            <h1>Kayıt Ol</h1>
        </div>
        <div style=""margin: 0 auto;"" class=""homepage_signup"">
            <div class=""homepage_input"">
                <div data-toggle=""buttons"" style=""width: 100%"" id=""accountType"" class=""btn-group"">
                    <label style=""width: 50%; font-size: 12px; white-space: normal;"" class=""btn btn-default active"">
                        <input id=""option1"" type=""radio"" name=""accountType"" autocomplete=""off"" checked value=""Kayıt Ol""> Bireysel
                    </label>
                    <label style=""width: 50%; font-size: 12px; white-space: normal;"" class=""btn btn-default"">
                        <input id=""option2"" type=""radio"" name=""accountType"" autocomplete=""off"" value=""company_signup""> Kurumsal
                    </label>
                </div>
            </div>
            <form");
                BeginWriteAttribute("action", "  action=\"", 2915, "\"", 2925, 0);
                EndWriteAttribute();
                WriteLiteral(" method=\"POST\" id=\"KayitOlUser\"");
                BeginWriteAttribute("style", " style=\"", 2957, "\"", 2965, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                ");
#nullable restore
#line 59 "C:\Users\gizem\Desktop\Web Projesi\FindWorkerWeb.WebUI\FindWorkerWeb.WebUI\Views\Login\Register.cshtml"
           Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                ");
#nullable restore
#line 60 "C:\Users\gizem\Desktop\Web Projesi\FindWorkerWeb.WebUI\FindWorkerWeb.WebUI\Views\Login\Register.cshtml"
           Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                <input type=\"hidden\" name=\"_csrf\" value=\"R68ot0k1-6LVMrGFSg9PJXZmYy05c18UdQCs\">\r\n                <div class=\"homepage_input form-group clearfix\">\r\n                    <div class=\"half_input left\">\r\n                        ");
#nullable restore
#line 64 "C:\Users\gizem\Desktop\Web Projesi\FindWorkerWeb.WebUI\FindWorkerWeb.WebUI\Views\Login\Register.cshtml"
                   Write(Html.ValidationMessageFor(x => x.user.Name, "", new { style = "color:red" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        ");
#nullable restore
#line 65 "C:\Users\gizem\Desktop\Web Projesi\FindWorkerWeb.WebUI\FindWorkerWeb.WebUI\Views\Login\Register.cshtml"
                   Write(Html.TextBoxFor(x => x.user.Name, new { @class = "form-control", @placeholder = "Ad" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        <span class=\"help-block\"> </span>\r\n                        <span asp-validation-for=\"Name\">  </span>\r\n\r\n\r\n                    </div>\r\n                    <div class=\"half_input right\">\r\n                        ");
#nullable restore
#line 72 "C:\Users\gizem\Desktop\Web Projesi\FindWorkerWeb.WebUI\FindWorkerWeb.WebUI\Views\Login\Register.cshtml"
                   Write(Html.ValidationMessageFor(x => x.user.Surname, "", new { style = "color:red" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        ");
#nullable restore
#line 73 "C:\Users\gizem\Desktop\Web Projesi\FindWorkerWeb.WebUI\FindWorkerWeb.WebUI\Views\Login\Register.cshtml"
                   Write(Html.TextBoxFor(x => x.user.Surname, new { @class = "form-control", @placeholder = "Soyad" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                        <span class=""help-block""> </span>
                        <span asp-validation-for=""SurName"">  </span>
                    </div>
                </div>
                <div class=""homepage_input form-group"">
                    ");
#nullable restore
#line 79 "C:\Users\gizem\Desktop\Web Projesi\FindWorkerWeb.WebUI\FindWorkerWeb.WebUI\Views\Login\Register.cshtml"
               Write(Html.ValidationMessageFor(x => x.user.UserName, "", new { style = "color:red" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    ");
#nullable restore
#line 80 "C:\Users\gizem\Desktop\Web Projesi\FindWorkerWeb.WebUI\FindWorkerWeb.WebUI\Views\Login\Register.cshtml"
               Write(Html.TextBoxFor(x => x.user.UserName, new { @class = "form-control", @placeholder = "Kullanıcı Adı" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    <span class=\"help-block\"> </span>\r\n                    <span asp-validation-for=\"UserName\">  </span>\r\n                </div>\r\n\r\n                <div class=\"homepage_input form-group\">\r\n                    ");
#nullable restore
#line 86 "C:\Users\gizem\Desktop\Web Projesi\FindWorkerWeb.WebUI\FindWorkerWeb.WebUI\Views\Login\Register.cshtml"
               Write(Html.ValidationMessageFor(x => x.user.Email, "", new { style = "color:red" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    ");
#nullable restore
#line 87 "C:\Users\gizem\Desktop\Web Projesi\FindWorkerWeb.WebUI\FindWorkerWeb.WebUI\Views\Login\Register.cshtml"
               Write(Html.TextBoxFor(x => x.user.Email, new { @class = "form-control", @placeholder = "Email" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    <span class=\"help-block\"> </span>\r\n                    <span asp-validation-for=\"Email\">  </span>\r\n                </div>\r\n                <div class=\"homepage_input form-group\">\r\n                    ");
#nullable restore
#line 92 "C:\Users\gizem\Desktop\Web Projesi\FindWorkerWeb.WebUI\FindWorkerWeb.WebUI\Views\Login\Register.cshtml"
               Write(Html.ValidationMessageFor(x => x.user.PhoneNumber, "", new { style = "color:red" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    ");
#nullable restore
#line 93 "C:\Users\gizem\Desktop\Web Projesi\FindWorkerWeb.WebUI\FindWorkerWeb.WebUI\Views\Login\Register.cshtml"
               Write(Html.TextBoxFor(x => x.user.PhoneNumber, new { @class = "form-control", @placeholder = "Telefon Numarası" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    <span class=\"help-block\"> </span>\r\n                    <span asp-validation-for=\"PhoneNumber\">  </span>\r\n                </div>\r\n                <div class=\"homepage_input form-group\" >\r\n                  \r\n                    ");
#nullable restore
#line 99 "C:\Users\gizem\Desktop\Web Projesi\FindWorkerWeb.WebUI\FindWorkerWeb.WebUI\Views\Login\Register.cshtml"
               Write(Html.ValidationMessageFor(x => x.user.Password, "", new { style = "color:red" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    ");
#nullable restore
#line 100 "C:\Users\gizem\Desktop\Web Projesi\FindWorkerWeb.WebUI\FindWorkerWeb.WebUI\Views\Login\Register.cshtml"
               Write(Html.TextBoxFor(x => x.user.Password, new { @class = "form-control", @type= "Password", @placeholder = "Şifre" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                    <span asp-validation-for=""Password"">  </span>
                </div>

                <div class=""homepage_input form-group"">
                    <input type=""submit"" value=""Kayıt Ol"" style=""padding: 0"" class=""form-control homepage_signup_button"">

                </div>

            </form>
            <form action=""/Login/CompanyRegister"" method=""POST"" id=""KayitOlCompany"" style=""display: none"">
                ");
#nullable restore
#line 111 "C:\Users\gizem\Desktop\Web Projesi\FindWorkerWeb.WebUI\FindWorkerWeb.WebUI\Views\Login\Register.cshtml"
           Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                ");
#nullable restore
#line 112 "C:\Users\gizem\Desktop\Web Projesi\FindWorkerWeb.WebUI\FindWorkerWeb.WebUI\Views\Login\Register.cshtml"
           Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                <div class=\"homepage_input form-group\">\r\n                    ");
#nullable restore
#line 114 "C:\Users\gizem\Desktop\Web Projesi\FindWorkerWeb.WebUI\FindWorkerWeb.WebUI\Views\Login\Register.cshtml"
               Write(Html.ValidationMessageFor(x => x.company.CompanyName, "", new { style = "color:red" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    ");
#nullable restore
#line 115 "C:\Users\gizem\Desktop\Web Projesi\FindWorkerWeb.WebUI\FindWorkerWeb.WebUI\Views\Login\Register.cshtml"
               Write(Html.TextBoxFor(x => x.company.CompanyName, new { @class = "form-control", @placeholder = "Şirket Ad" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    <span asp-validation-for=\"CompanyName\">  </span>\r\n                    <span class=\"help-block\"> </span>\r\n                </div>\r\n                <div class=\"homepage_input form-group\">\r\n                    ");
#nullable restore
#line 120 "C:\Users\gizem\Desktop\Web Projesi\FindWorkerWeb.WebUI\FindWorkerWeb.WebUI\Views\Login\Register.cshtml"
               Write(Html.ValidationMessageFor(x => x.company.CompanyEmail, "", new { style = "color:red" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    ");
#nullable restore
#line 121 "C:\Users\gizem\Desktop\Web Projesi\FindWorkerWeb.WebUI\FindWorkerWeb.WebUI\Views\Login\Register.cshtml"
               Write(Html.TextBoxFor(x => x.company.CompanyEmail, new { @class = "form-control", @placeholder = "Şirket Email" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    <span class=\"help-block\"> </span>\r\n                    <span asp-validation-for=\"CompanyEmail\">  </span>\r\n                </div>\r\n                <div class=\"homepage_input form-group\">\r\n                    ");
#nullable restore
#line 126 "C:\Users\gizem\Desktop\Web Projesi\FindWorkerWeb.WebUI\FindWorkerWeb.WebUI\Views\Login\Register.cshtml"
               Write(Html.ValidationMessageFor(x => x.company.Password, "", new { style = "color:red" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    ");
#nullable restore
#line 127 "C:\Users\gizem\Desktop\Web Projesi\FindWorkerWeb.WebUI\FindWorkerWeb.WebUI\Views\Login\Register.cshtml"
               Write(Html.TextBoxFor(x => x.company.Password, new { @class = "form-control", @type= "Password", @placeholder = "Şifre" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                    <span asp-validation-for=""Password"">  </span>
                </div>
                <div class=""homepage_input form-group"">
                    <input type=""submit"" value=""Kayıt Ol"" style=""padding: 0"" class=""form-control homepage_signup_button"">
                </div>
            </form>
        </div>
    </div>
    <div id=""jobShareModal"" tabindex=""-1"" role=""dialog""");
                BeginWriteAttribute("aria-labelledby", " aria-labelledby=\"", 7895, "\"", 7913, 0);
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
    <script>
        $(function () {

            $(""#option2"").click(function () {
                $(""#KayitOlUser"").hide();
                $(""#KayitOlCompany"").show();
            });
            $(""#option1"").click(function () {
                $(""#KayitOlCompany"").hide();
                $(""#KayitOlUser"").show();
            });

        });
    </script>
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
            WriteLiteral("\r\n\r\n\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FindWorkerWeb.WebUI.Models.RegisterModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
