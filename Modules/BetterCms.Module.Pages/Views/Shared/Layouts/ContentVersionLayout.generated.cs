﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BetterCms.Module.Pages.Views.Shared.Layouts
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    
    #line 1 "..\..\Views\Shared\Layouts\ContentVersionLayout.cshtml"
    using BetterCms.Module.Root.Mvc.Helpers;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Shared/Layouts/ContentVersionLayout.cshtml")]
    public partial class ContentVersionLayout : System.Web.Mvc.WebViewPage<BetterCms.Module.Root.ViewModels.Cms.RenderPageViewModel>
    {
        public ContentVersionLayout()
        {
        }
        public override void Execute()
        {

WriteLiteral("\r\n");


WriteLiteral("\r\n");


            
            #line 5 "..\..\Views\Shared\Layouts\ContentVersionLayout.cshtml"
  
    Layout = "~/Areas/bcms-root/Views/Shared/BaseLayout.cshtml";


            
            #line default
            #line hidden
WriteLiteral("\r\n");


            
            #line 9 "..\..\Views\Shared\Layouts\ContentVersionLayout.cshtml"
Write(RenderBody());

            
            #line default
            #line hidden
WriteLiteral("\r\n");


            
            #line 10 "..\..\Views\Shared\Layouts\ContentVersionLayout.cshtml"
Write(RenderSection("VersionContent", false));

            
            #line default
            #line hidden

        }
    }
}
#pragma warning restore 1591