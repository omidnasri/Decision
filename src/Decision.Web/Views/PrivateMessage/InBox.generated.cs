﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Optimization;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    
    #line 2 "..\..\Views\PrivateMessage\InBox.cshtml"
    using Decision.Common.HtmlHelpers;
    
    #line default
    #line hidden
    using Decision.Utility;
    using Decision.Web.HtmlHelpers;
    using MvcSiteMapProvider.Web.Html;
    using MvcSiteMapProvider.Web.Html.Models;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/PrivateMessage/InBox.cshtml")]
    public partial class _Views_PrivateMessage_InBox_cshtml : System.Web.Mvc.WebViewPage<IEnumerable<Decision.ViewModel.PrivateMessage.InBoxViewModel>>
    {
        public _Views_PrivateMessage_InBox_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

            
            #line 4 "..\..\Views\PrivateMessage\InBox.cshtml"
  
    ViewBag.Title = "لیست پیغام های دریافتی";

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 7 "..\..\Views\PrivateMessage\InBox.cshtml"
Write(Html.AntiForgeryToken());

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<div");

WriteLiteral(" class=\"panel panel-default\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"panel-heading\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"col-md-12\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 13 "..\..\Views\PrivateMessage\InBox.cshtml"
           Write(Html.HelpAlert(Url.Content("~/Content/Images/lightbulb.png"),
                    "توجه کنید که حذف توسط گیرنده/فرستنده به معنای انصراف کلی است",
                    "اگر در لیست پیغام های ورودی یا خروجی ، پیغامی  توسط فرستنده یا گیرنده حذف شده باشد ،برای کاربر مقابل هم غیر فابل دسترس خواهد بود"));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <div");

WriteLiteral(" class=\"panel-body\"");

WriteLiteral(" id=\"conversationList\"");

WriteLiteral(">\r\n");

            
            #line 21 "..\..\Views\PrivateMessage\InBox.cshtml"
        
            
            #line default
            #line hidden
            
            #line 21 "..\..\Views\PrivateMessage\InBox.cshtml"
          Html.RenderPartial(MVC.PrivateMessage.Views._InBoxListAjax, Model);
            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n    <div");

WriteLiteral(" class=\"panel-footer padding-5-5\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"col-md-offset-2 col-md-8\"");

WriteLiteral(">\r\n                <button");

WriteLiteral(" data-page=\"2\"");

WriteLiteral(" data-container=\"#conversationList\"");

WriteLiteral("\r\n                        data-progress=\"#progress\"");

WriteLiteral("\r\n                        data-json=\'{}\'");

WriteLiteral("\r\n                        data-load-url=\"");

            
            #line 29 "..\..\Views\PrivateMessage\InBox.cshtml"
                                  Write(Url.Action(MVC.PrivateMessage.InBoxAjax()));

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral("\r\n                        onclick=\"justPaging(this)\"");

WriteLiteral(" class=\"btn btn-info btn-block btn-sm\"");

WriteLiteral(" type=\"button\"");

WriteLiteral(">\r\n                    بیشتر\r\n                </button>\r\n            </div>\r\n    " +
"    </div>\r\n        <div");

WriteLiteral(" id=\"progress\"");

WriteLiteral(" align=\"center\"");

WriteLiteral(" style=\"display: none\"");

WriteLiteral(">\r\n            <img");

WriteAttribute("src", Tuple.Create(" src=\"", 1484), Tuple.Create("\"", 1534)
            
            #line 36 "..\..\Views\PrivateMessage\InBox.cshtml"
, Tuple.Create(Tuple.Create("", 1490), Tuple.Create<System.Object, System.Int32>(Url.Content("~/Content/images/loading.gif")
            
            #line default
            #line hidden
, 1490), false)
);

WriteLiteral(" alt=\"loading...\"");

WriteLiteral(" />\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");

DefineSection("Menu", () => {

WriteLiteral("\r\n");

            
            #line 42 "..\..\Views\PrivateMessage\InBox.cshtml"
    
            
            #line default
            #line hidden
            
            #line 42 "..\..\Views\PrivateMessage\InBox.cshtml"
      Html.RenderPartial(MVC.Shared.Views._UserProfileSideBarMenu);
            
            #line default
            #line hidden
WriteLiteral("\r\n");

});

        }
    }
}
#pragma warning restore 1591
