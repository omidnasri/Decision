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
    using Decision.Common.MVC;
    using Decision.Utility;
    using Decision.Web.HtmlHelpers;
    using MvcSiteMapProvider.Web.Html;
    using MvcSiteMapProvider.Web.Html.Models;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Error/Unauthorized.cshtml")]
    public partial class _Views_Error_Unauthorized_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Views_Error_Unauthorized_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 1 "..\..\Views\Error\Unauthorized.cshtml"
  
    ViewBag.Title = "Unauthorized";
    ViewBag.Description = "Sorry, but the page requires authentication.";

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<div");

WriteLiteral(" class=\"jumbotron text-center\"");

WriteLiteral(">\r\n    <header>\r\n        <h1><span");

WriteLiteral(" aria-hidden=\"true\"");

WriteLiteral(" class=\"fa fa-ban text-danger\"");

WriteLiteral("></span> ");

            
            #line 8 "..\..\Views\Error\Unauthorized.cshtml"
                                                                      Write(ViewBag.Title);

            
            #line default
            #line hidden
WriteLiteral("</h1>\r\n    </header>\r\n    <p>");

            
            #line 10 "..\..\Views\Error\Unauthorized.cshtml"
  Write(ViewBag.Description);

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n    <a");

WriteLiteral(" class=\"btn btn-primary btn-lg\"");

WriteAttribute("href", Tuple.Create(" href=\"", 353), Tuple.Create("\"", 389)
            
            #line 11 "..\..\Views\Error\Unauthorized.cshtml"
, Tuple.Create(Tuple.Create("", 360), Tuple.Create<System.Object, System.Int32>(Url.Action(MVC.Home.Index())
            
            #line default
            #line hidden
, 360), false)
);

WriteLiteral("><span");

WriteLiteral(" aria-hidden=\"true\"");

WriteLiteral(" class=\"fa fa-home\"");

WriteLiteral("></span> Take me home</a>\r\n</div>");

        }
    }
}
#pragma warning restore 1591