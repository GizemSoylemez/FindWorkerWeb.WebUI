#pragma checksum "C:\Users\gizem\Desktop\Web Projesi\FindWorkerWeb.WebUI\FindWorkerWeb.WebUI\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "94226e95cdbd216313336af8b133ef6987489bf5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
#line 1 "C:\Users\gizem\Desktop\Web Projesi\FindWorkerWeb.WebUI\FindWorkerWeb.WebUI\Views\Shared\_Layout.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"94226e95cdbd216313336af8b133ef6987489bf5", @"/Views/Shared/_Layout.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#line 2 "C:\Users\gizem\Desktop\Web Projesi\FindWorkerWeb.WebUI\FindWorkerWeb.WebUI\Views\Shared\_Layout.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"tr\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "94226e95cdbd216313336af8b133ef6987489bf53536", async() => {
                WriteLiteral(@"
    <meta charset=""utf-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1, maximum-scale=1, user-scalable=no"">
    <meta name=""csrf-token"" content=""uTFfvMCg-2edosKSlw-4PASrxGRopAa0CM8Y"">
    <link rel=""icon"" type=""image/png"" href=""/favicon-32x32.png"" sizes=""32x32"">
    <link rel=""icon"" type=""image/png"" href=""/favicon-16x16.png"" sizes=""16x16"">
    <!--Bootstrap -->
    <link href=""/css/bootstrap.min.css"" rel=""stylesheet"">
    <link href=""/css/glyphicons.css"" rel=""stylesheet"">
    <link rel=""stylesheet"" href=""/css/glyphicons-social.css"" type=""text/css"">
    <link href=""/css/mycv.css"" rel=""stylesheet"">
    <!--if lt IE 9script(src='https://oss.maxcdn.com/html5shiv/3.7.2/html5shiv.min.js')
    script(src='https://oss.maxcdn.com/respond/1.4.2/respond.min.js')-->
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
            WriteLiteral("\r\n\r\n\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "94226e95cdbd216313336af8b133ef6987489bf55424", async() => {
                WriteLiteral(@"
    <nav role=""navigation"" class=""navbar navbar-inverse navbar-fixed-top"">
        <div class=""container"">
            <div class=""navbar-header"">

                <button type=""button"" data-toggle=""collapse"" data-target=""#bs-example-navbar-collapse-1"" class=""navbar-toggle collapsed"">
                    <span class=""sr-only"">Toggle navigation</span>
                    <span class=""icon-bar""></span>
                    <span class=""icon-bar""></span>
                    <span class=""icon-bar""></span>
                </button><a href=""/Home/AnaSayfa"" class=""logo_inside"">FİNDWORK-ER</a>

            </div>
            <div id=""bs-example-navbar-collapse-1"" style=""background: #444"" class=""collapse navbar-collapse"">

                <ul class=""nav navbar-nav"">
                    <li>
                        <a ");
#nullable restore
#line 44 "C:\Users\gizem\Desktop\Web Projesi\FindWorkerWeb.WebUI\FindWorkerWeb.WebUI\Views\Shared\_Layout.cshtml"
                            if (Context.Session.GetString("RoleId") == "1")
                                    {
                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 46 "C:\Users\gizem\Desktop\Web Projesi\FindWorkerWeb.WebUI\FindWorkerWeb.WebUI\Views\Shared\_Layout.cshtml"
                                   Write(Html.ActionLink("","Profile","User"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 46 "C:\Users\gizem\Desktop\Web Projesi\FindWorkerWeb.WebUI\FindWorkerWeb.WebUI\Views\Shared\_Layout.cshtml"
                                                                             
    
                                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
#nullable restore
#line 50 "C:\Users\gizem\Desktop\Web Projesi\FindWorkerWeb.WebUI\FindWorkerWeb.WebUI\Views\Shared\_Layout.cshtml"
                                     if (Context.Session.GetString("RoleId") == "2")
                                    {
                                         

#line default
#line hidden
#nullable disable
#nullable restore
#line 52 "C:\Users\gizem\Desktop\Web Projesi\FindWorkerWeb.WebUI\FindWorkerWeb.WebUI\Views\Shared\_Layout.cshtml"
                                    Write(Html.ActionLink("", "Profile", "Company"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 52 "C:\Users\gizem\Desktop\Web Projesi\FindWorkerWeb.WebUI\FindWorkerWeb.WebUI\Views\Shared\_Layout.cshtml"
                                                                                   
                                     }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                    >Profilim</a>\r\n                        \r\n                    </li>\r\n                    <li><a ");
#nullable restore
#line 58 "C:\Users\gizem\Desktop\Web Projesi\FindWorkerWeb.WebUI\FindWorkerWeb.WebUI\Views\Shared\_Layout.cshtml"
                            if (Context.Session.GetString("RoleId") == "1")
                                    {
                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 60 "C:\Users\gizem\Desktop\Web Projesi\FindWorkerWeb.WebUI\FindWorkerWeb.WebUI\Views\Shared\_Layout.cshtml"
                                   Write(Html.ActionLink("","Message","User"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 60 "C:\Users\gizem\Desktop\Web Projesi\FindWorkerWeb.WebUI\FindWorkerWeb.WebUI\Views\Shared\_Layout.cshtml"
                                                                             
    
                                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
#nullable restore
#line 64 "C:\Users\gizem\Desktop\Web Projesi\FindWorkerWeb.WebUI\FindWorkerWeb.WebUI\Views\Shared\_Layout.cshtml"
                                     if (Context.Session.GetString("RoleId") == "2")
                                    {
                                         

#line default
#line hidden
#nullable disable
#nullable restore
#line 66 "C:\Users\gizem\Desktop\Web Projesi\FindWorkerWeb.WebUI\FindWorkerWeb.WebUI\Views\Shared\_Layout.cshtml"
                                    Write(Html.ActionLink("", "Message", "Company"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 66 "C:\Users\gizem\Desktop\Web Projesi\FindWorkerWeb.WebUI\FindWorkerWeb.WebUI\Views\Shared\_Layout.cshtml"
                                                                                   
                                     }

#line default
#line hidden
#nullable disable
                WriteLiteral(@">Mesajlar</a></li>
                </ul>
                <ul class=""nav navbar-nav navbar-right"">
                    <li class=""dropdown"">
                        <a href=""#"" data-toggle=""dropdown"" style=""height: 50px;"" class=""dropdown-toggle"">
                            <div style=""padding-left: 7px"" class=""pull-right""><span class=""caret""></span></div>
                            <div style=""background: #fff;"" class=""top_profile_img"">
                                <img");
                BeginWriteAttribute("src", " src=\"", 3391, "\"", 3397, 0);
                EndWriteAttribute();
                WriteLiteral(" width=\"35\" height=\"35\" style=\"border-radius: 100px; display: none\" class=\"top_profile_img_img\">\r\n                            </div>\r\n                            <span class=\"hidden-md\"> ");
#nullable restore
#line 76 "C:\Users\gizem\Desktop\Web Projesi\FindWorkerWeb.WebUI\FindWorkerWeb.WebUI\Views\Shared\_Layout.cshtml"
                                                Write(Context.Session.GetString("Name"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</span>
                        </a>
                        
                        <ul role=""menu"" class=""dropdown-menu"">
                         
                            <li class=""divider""></li>
                            <li><a href=""/Home/CikisYap"">Çıkış</a></li>
                        </ul>
                    </li>
                </ul>
            </div>
        </div>
    </nav>
    <div class=""container no_padding"">
        ");
#nullable restore
#line 90 "C:\Users\gizem\Desktop\Web Projesi\FindWorkerWeb.WebUI\FindWorkerWeb.WebUI\Views\Shared\_Layout.cshtml"
   Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
    </div>

    <div class=""footer""></div>
    <script src=""/js0/i18n-client.js?q=non|follow_btn,follow_active_btn,apply_then_no_html""></script>
    <script src=""/js/jquery.min.js""></script>
    <script src=""/js/d.js""></script>
    <script src=""/js/bootstrap.min.js""></script>
    <script>
        (function (i, s, o, g, r, a, m) {
            i['GoogleAnalyticsObject'] = r;
            i[r] = i[r] || function () {
                (i[r].q = i[r].q || []).push(arguments);
            },
                i[r].l = 1 * new Date();
            a = s.createElement(o),
                m = s.getElementsByTagName(o)[0];
            a.async = 1;
            a.src = g;
            m.parentNode.insertBefore(a, m)
        })(window, document, 'script', '//www.google-analytics.com/analytics.js', 'ga');
        ga('create', 'UA-47702418-3', 'auto');
        ga('send', 'pageview');
    </script>

    <script src=""/js/jquery-scrolltofixed-min.js""></script>
    <script src=""/js/u.js""></script>
    <scr");
                WriteLiteral("ipt src=\"/socket.io/socket.io.js\"></script>\r\n    <script src=\"/js/left.js\"></script>\r\n    <script src=\"/js/i18n/tr.js\"></script>\r\n");
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
