#pragma checksum "D:\AssetSystem23102019\SystemAsset02\Views\Shared\_Layout_Admin.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a79822c0360df394b30b5dd7fb47e72dc6522414"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout_Admin), @"mvc.1.0.view", @"/Views/Shared/_Layout_Admin.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_Layout_Admin.cshtml", typeof(AspNetCore.Views_Shared__Layout_Admin))]
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
#line 1 "D:\AssetSystem23102019\SystemAsset02\Views\_ViewImports.cshtml"
using SystemAsset02;

#line default
#line hidden
#line 2 "D:\AssetSystem23102019\SystemAsset02\Views\_ViewImports.cshtml"
using SystemAsset02.Models;

#line default
#line hidden
#line 2 "D:\AssetSystem23102019\SystemAsset02\Views\Shared\_Layout_Admin.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 4 "D:\AssetSystem23102019\SystemAsset02\Views\Shared\_Layout_Admin.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a79822c0360df394b30b5dd7fb47e72dc6522414", @"/Views/Shared/_Layout_Admin.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d1b82182f657bdb5a93d8cc14dd4af4379e9189", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout_Admin : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("app sidebar-mini rtl"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(128, 43, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html lang=\"en\">\r\n\r\n\r\n");
            EndContext();
            BeginContext(171, 1382, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a79822c0360df394b30b5dd7fb47e72dc65224144156", async() => {
                BeginContext(177, 1369, true);
                WriteLiteral(@"
    <meta name=""description"" content=""Vali is a responsive and free admin theme built with Bootstrap 4, SASS and PUG.js. It's fully customizable and modular."">
    <!-- Twitter meta-->
    <meta property=""twitter:card"" content=""summary_large_image"">
    <meta property=""twitter:site"" content="""">
    <meta property=""twitter:creator"" content="""">
    <!-- Open Graph Meta-->
    <meta property=""og:type"" content=""website"">
    <meta property=""og:site_name"" content=""Vali Admin"">
    <!--  <meta property=""og:title"" content=""Vali - Free Bootstrap 4 admin theme"">
     <meta property=""og:url"" content=""http://pratikborsadiya.in/blog/vali-admin"">
     <meta property=""og:image"" content=""http://pratikborsadiya.in/blog/vali-admin/hero-social.png"">-->
    <meta property=""og:description"" content=""Vali is a responsive and free admin theme built with Bootstrap 4, SASS and PUG.js. It's fully customizable and modular."">
    <title>ASSET SYSTEM</title>
    <meta charset=""utf-8"">
    <meta http-equiv=""X-UA-Compatible");
                WriteLiteral(@""" content=""IE=edge"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
    <!-- Main CSS-->
    <link rel=""stylesheet"" type=""text/css"" href=""/Admin/css/main.css"">
    <!-- Font-icon css-->
    <link rel=""stylesheet"" type=""text/css"" href=""https://maxcdn.bootstrapcdn.com/font-awesome/4.7.0/css/font-awesome.min.css"">
");
                EndContext();
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
            EndContext();
            BeginContext(1553, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(1555, 12907, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a79822c0360df394b30b5dd7fb47e72dc65224146808", async() => {
                BeginContext(1590, 6446, true);
                WriteLiteral(@"
    <!-- Navbar-->
    <header class=""app-header"">
        <a class=""app-header__logo"" href=""index.html"">Vali</a>
        <!-- Sidebar toggle button--><a class=""app-sidebar__toggle"" href=""#"" data-toggle=""sidebar"" aria-label=""Hide Sidebar""></a>
        <!-- Navbar Right Menu-->
        <ul class=""app-nav"">

            <li class=""app-search"">
                <input class=""app-search__input"" type=""search"" placeholder=""Search"">
                <button class=""app-search__button""><i class=""fa fa-search""></i></button>
            </li>
            <!--Notification Menu-->
            <li class=""dropdown"">
                <a class=""app-nav__item"" href=""#"" data-toggle=""dropdown"" aria-label=""Show notifications""><i class=""fa fa-bell-o fa-lg""></i></a>
                <ul class=""app-notification dropdown-menu dropdown-menu-right"">
                    <li class=""app-notification__title"">You have 4 new notifications.</li>
                    <div class=""app-notification__content"">
                       ");
                WriteLiteral(@" <li>
                            <a class=""app-notification__item"" href=""javascript:;"">
                                <span class=""app-notification__icon""><span class=""fa-stack fa-lg""><i class=""fa fa-circle fa-stack-2x text-primary""></i><i class=""fa fa-envelope fa-stack-1x fa-inverse""></i></span></span>
                                <div>
                                    <p class=""app-notification__message"">Lisa sent you a mail</p>
                                    <p class=""app-notification__meta"">2 min ago</p>
                                </div>
                            </a>
                        </li>
                        <li>
                            <a class=""app-notification__item"" href=""javascript:;"">
                                <span class=""app-notification__icon""><span class=""fa-stack fa-lg""><i class=""fa fa-circle fa-stack-2x text-danger""></i><i class=""fa fa-hdd-o fa-stack-1x fa-inverse""></i></span></span>
                                <div>
                ");
                WriteLiteral(@"                    <p class=""app-notification__message"">Mail server not working</p>
                                    <p class=""app-notification__meta"">5 min ago</p>
                                </div>
                            </a>
                        </li>
                        <li>
                            <a class=""app-notification__item"" href=""javascript:;"">
                                <span class=""app-notification__icon""><span class=""fa-stack fa-lg""><i class=""fa fa-circle fa-stack-2x text-success""></i><i class=""fa fa-money fa-stack-1x fa-inverse""></i></span></span>
                                <div>
                                    <p class=""app-notification__message"">Transaction complete</p>
                                    <p class=""app-notification__meta"">2 days ago</p>
                                </div>
                            </a>
                        </li>

                        <div class=""app-notification__content"">
                     ");
                WriteLiteral(@"       <li>
                                <a class=""app-notification__item"" href=""javascript:;"">
                                    <span class=""app-notification__icon""><span class=""fa-stack fa-lg""><i class=""fa fa-circle fa-stack-2x text-primary""></i><i class=""fa fa-envelope fa-stack-1x fa-inverse""></i></span></span>
                                    <div>
                                        <p class=""app-notification__message"">Lisa sent you a mail</p>
                                        <p class=""app-notification__meta"">2 min ago</p>
                                    </div>
                                </a>
                            </li>
                            <li>
                                <a class=""app-notification__item"" href=""javascript:;"">
                                    <span class=""app-notification__icon""><span class=""fa-stack fa-lg""><i class=""fa fa-circle fa-stack-2x text-danger""></i><i class=""fa fa-hdd-o fa-stack-1x fa-inverse""></i></span></span>
     ");
                WriteLiteral(@"                               <div>
                                        <p class=""app-notification__message"">Mail server not working</p>
                                        <p class=""app-notification__meta"">5 min ago</p>
                                    </div>
                                </a>
                            </li>
                            <li>
                                <a class=""app-notification__item"" href=""javascript:;"">
                                    <span class=""app-notification__icon""><span class=""fa-stack fa-lg""><i class=""fa fa-circle fa-stack-2x text-success""></i><i class=""fa fa-money fa-stack-1x fa-inverse""></i></span></span>
                                    <div>
                                        <p class=""app-notification__message"">Transaction complete</p>
                                        <p class=""app-notification__meta"">2 days ago</p>
                                    </div>
                                </a>
             ");
                WriteLiteral(@"               </li>
                        </div>
                    </div>
                    <li class=""app-notification__footer""><a href=""#"">See all notifications.</a></li>
                </ul>
            </li>
            <!-- User Menu-->
            <li class=""dropdown"">
                <a class=""app-nav__item"" href=""#"" data-toggle=""dropdown"" aria-label=""Open Profile Menu""><i class=""fa fa-user fa-lg""></i></a>
                <ul class=""dropdown-menu settings-menu dropdown-menu-right"">
                    <li><a class=""dropdown-item"" href=""page-user.html""><i class=""fa fa-cog fa-lg""></i> Settings</a></li>
                    <li><a class=""dropdown-item"" href=""page-user.html""><i class=""fa fa-user fa-lg""></i> Profile</a></li>
                    <li><a class=""dropdown-item"" href=""/Account/LogOut""><i class=""fa fa-sign-out fa-lg""></i>Đăng xuất</a></li>
                </ul>
            </li>
        </ul>
    </header>
    <!-- Sidebar menu-->
    <div class=""app-sidebar__overlay"" data");
                WriteLiteral(@"-toggle=""sidebar""></div>
    <aside class=""app-sidebar"">
        <div class=""app-sidebar__user"">
            <img class=""app-sidebar__user-avatar"" src=""https://s3.amazonaws.com/uifaces/faces/twitter/jsa/48.jpg"" alt=""User Image"">
            <div>
                <p class=""app-sidebar__user-name"">");
                EndContext();
                BeginContext(8078, 3147, true);
                WriteLiteral(@"</p>
                <p class=""app-sidebar__user-designation"">Frontend Developer</p>
            </div>
        </div>
        <ul class=""app-menu"">
            <li><a class=""app-menu__item active"" href=""index.html""><i class=""app-menu__icon fa fa-dashboard""></i><span class=""app-menu__label"">Kế hoạch mua hàng</span></a></li>
            <li class=""treeview"">
                <a class=""app-menu__item"" href=""#"" data-toggle=""treeview""><i class=""app-menu__icon fa fa-laptop""></i><span class=""app-menu__label"">UI Elements</span><i class=""treeview-indicator fa fa-angle-right""></i></a>
                <ul class=""treeview-menu"">
                    <li><a class=""treeview-item"" href=""bootstrap-components.html""><i class=""icon fa fa-circle-o""></i> Bootstrap Elements</a></li>
                    <li><a class=""treeview-item"" href=""https://fontawesome.com/v4.7.0/icons/"" target=""_blank"" rel=""noopener""><i class=""icon fa fa-circle-o""></i> Font Icons</a></li>
                    <li><a class=""treeview-item"" href=""ui-car");
                WriteLiteral(@"ds.html""><i class=""icon fa fa-circle-o""></i> Cards</a></li>
                    <li><a class=""treeview-item"" href=""widgets.html""><i class=""icon fa fa-circle-o""></i> Widgets</a></li>
                </ul>
            </li>
            <li><a class=""app-menu__item"" href=""charts.html""><i class=""app-menu__icon fa fa-pie-chart""></i><span class=""app-menu__label"">Charts</span></a></li>
            <li class=""treeview"">
                <a class=""app-menu__item"" href=""#"" data-toggle=""treeview""><i class=""app-menu__icon fa fa-edit""></i><span class=""app-menu__label"">Forms</span><i class=""treeview-indicator fa fa-angle-right""></i></a>
                <ul class=""treeview-menu"">
                    <li><a class=""treeview-item"" href=""form-components.html""><i class=""icon fa fa-circle-o""></i> Form Components</a></li>
                    <li><a class=""treeview-item"" href=""form-custom.html""><i class=""icon fa fa-circle-o""></i> Custom Components</a></li>
                    <li><a class=""treeview-item"" href=""form-samples");
                WriteLiteral(@".html""><i class=""icon fa fa-circle-o""></i> Form Samples</a></li>
                    <li><a class=""treeview-item"" href=""form-notifications.html""><i class=""icon fa fa-circle-o""></i> Form Notifications</a></li>
                </ul>
            </li>
            <li class=""treeview"">
                <a class=""app-menu__item"" href=""/Admin/Admin/ActiveAccount""><i class=""app-menu__icon fa fa-file-text""></i><span class=""app-menu__label"">Quản lý tài khoản</span></a>

            </li>
            <li class=""treeview"">
                <a class=""app-menu__item"" href=""#"" data-toggle=""treeview""><i class=""app-menu__icon fa fa-th-list""></i><span class=""app-menu__label"">LOG</span><i class=""treeview-indicator fa fa-angle-right""></i></a>
                <ul class=""treeview-menu"">
                    <li><a class=""treeview-item"" href=""/Admin/Admin/ViewErrorLog""><i class=""icon fa fa-circle-o""></i>Log All</a></li>
                    <li><a class=""treeview-item"" href=""table-data-table.html""><i class=""icon fa fa-circ");
                WriteLiteral("le-o\"></i> Data Tables</a></li>\r\n                </ul>\r\n            </li>\r\n");
                EndContext();
#line 165 "D:\AssetSystem23102019\SystemAsset02\Views\Shared\_Layout_Admin.cshtml"
             if (signInManager.IsSignedIn(User) && User.IsInRole("Admin"))
            {

#line default
#line hidden
                BeginContext(11316, 937, true);
                WriteLiteral(@"                <li class=""treeview"">
                    <a class=""app-menu__item"" href=""#"" data-toggle=""treeview""><i class=""app-menu__icon fa fa-laptop""></i><span class=""app-menu__label"">Quản lý tài khoản</span><i class=""treeview-indicator fa fa-angle-right""></i></a>
                    <ul class=""treeview-menu"">
                        <li><a class=""treeview-item"" href=""/Account/ListUser""><i class=""icon fa fa-circle-o""></i>Tài khoản người dùng</a></li>
                        <li><a class=""treeview-item"" href=""/Administration/ListRole"" rel=""noopener""><i class=""icon fa fa-circle-o""></i>Quản lý phân quyền</a></li>
                        <li><a class=""treeview-item"" href=""/Account/Decrypt""><i class=""icon fa fa-circle-o""></i>Giải mã</a></li>
                        <li><a class=""treeview-item"" href=""widgets.html""><i class=""icon fa fa-circle-o""></i> Xóa cache</a></li>
                    </ul>
                </li>
");
                EndContext();
#line 176 "D:\AssetSystem23102019\SystemAsset02\Views\Shared\_Layout_Admin.cshtml"
            }

#line default
#line hidden
                BeginContext(12268, 461, true);
                WriteLiteral(@"            </ul>
    </aside>
    <main class=""app-content"">
        <div class=""app-title"">
            <div>
                <h1><i class=""fa fa-dashboard""></i> Dashboard</h1>

            </div>
            <ul class=""app-breadcrumb breadcrumb"">
                <li class=""breadcrumb-item""><i class=""fa fa-home fa-lg""></i></li>
                <li class=""breadcrumb-item""><a href=""#"">Dashboard</a></li>
            </ul>
        </div>
        ");
                EndContext();
                BeginContext(12730, 12, false);
#line 190 "D:\AssetSystem23102019\SystemAsset02\Views\Shared\_Layout_Admin.cshtml"
   Write(RenderBody());

#line default
#line hidden
                EndContext();
                BeginContext(12742, 1713, true);
                WriteLiteral(@"


    </main>



    <!-- Essential javascripts for application to work-->
    <script src=""/Admin/js/jquery-3.2.1.min.js""></script>
    <script src=""/Admin/js/popper.min.js""></script>
    <script src=""/Admin/js/bootstrap.min.js""></script>
    <script src=""/Admin/js/main.js""></script>
    <!-- The javascript plugin to display page loading on top-->
    <script src=""/Admin/js/plugins/pace.min.js""></script>
    <!-- Page specific javascripts-->
    <!-- Google analytics script-->
    <script type=""text/javascript"">
        if (document.location.hostname == 'pratikborsadiya.in') {
            (function (i, s, o, g, r, a, m) {
                i['GoogleAnalyticsObject'] = r; i[r] = i[r] || function () {
                    (i[r].q = i[r].q || []).push(arguments)
                }, i[r].l = 1 * new Date(); a = s.createElement(o),
                    m = s.getElementsByTagName(o)[0]; a.async = 1; a.src = g; m.parentNode.insertBefore(a, m)
            })(window, document, 'script', '//www.goog");
                WriteLiteral(@"le-analytics.com/analytics.js', 'ga');
            ga('create', 'UA-72504830-1', 'auto');
            ga('send', 'pageview');
        }
    </script>
    <script>
        $(function () {
            $(""#btnSubmitEncrypt"").click(function () {
                var text = $(""#TextEncrypt"").val();
                $.ajax({
                    type: ""post"",
                    data: {
                        TextEncrypt: text
                    },
                    url: ""/Account/Decrypt"",
                    success: function (e) {
                        $(""#TextDecrypt"").val(e)
                    }

                })
            })
        })
    </script>
");
                EndContext();
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
            EndContext();
            BeginContext(14462, 11, true);
            WriteLiteral("\r\n</html>\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<AccountInfo> signInManager { get; private set; }
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