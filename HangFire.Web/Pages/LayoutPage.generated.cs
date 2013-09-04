﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18047
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HangFire.Web.Pages
{
    
    #line 2 "..\..\Pages\LayoutPage.cshtml"
    using System;
    
    #line default
    #line hidden
    using System.Collections.Generic;
    
    #line 3 "..\..\Pages\LayoutPage.cshtml"
    using System.Diagnostics;
    
    #line default
    #line hidden
    
    #line 4 "..\..\Pages\LayoutPage.cshtml"
    using System.Linq;
    
    #line default
    #line hidden
    
    #line 5 "..\..\Pages\LayoutPage.cshtml"
    using System.Reflection;
    
    #line default
    #line hidden
    using System.Text;
    
    #line 6 "..\..\Pages\LayoutPage.cshtml"
    using System.Web.Configuration;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "1.5.3.0")]
    internal partial class LayoutPage : WebTemplateBase
    {
#line hidden

        public override void Execute()
        {


WriteLiteral("\r\n");







WriteLiteral("<!DOCTYPE html>\r\n\r\n<html lang=\"ru\">\r\n<head>\r\n    <title>");


            
            #line 12 "..\..\Pages\LayoutPage.cshtml"
      Write(Title);

            
            #line default
            #line hidden
WriteLiteral(" - HangFire</title>\r\n    <meta charset=\"utf-8\" />\r\n    <meta name=\"viewport\" cont" +
"ent=\"width=device-width, initial-scale=1.0\">\r\n    <link rel=\"stylesheet\" href=\"");


            
            #line 15 "..\..\Pages\LayoutPage.cshtml"
                            Write(Request.LinkTo("/styles.css?v1"));

            
            #line default
            #line hidden
WriteLiteral(@""" />
</head>
<body>
    <!-- Wrap all page content here -->
    <div id=""wrap"">

        <!-- Fixed navbar -->
        <div class=""navbar navbar-default navbar-fixed-top"">
            <div class=""container"">
                <div class=""navbar-header"">
                    <button type=""button"" class=""navbar-toggle"" data-toggle=""collapse"" data-target="".navbar-collapse"">
                        <span class=""icon-bar""></span>
                        <span class=""icon-bar""></span>
                        <span class=""icon-bar""></span>
                    </button>
                    <a class=""navbar-brand"" href=""");


            
            #line 30 "..\..\Pages\LayoutPage.cshtml"
                                             Write(Request.LinkTo("/"));

            
            #line default
            #line hidden
WriteLiteral("\">HangFire Monitor</a>\r\n                </div>\r\n                <div class=\"colla" +
"pse navbar-collapse\">\r\n                    <ul class=\"nav navbar-nav\">\r\n        " +
"                <li class=\"");


            
            #line 34 "..\..\Pages\LayoutPage.cshtml"
                               Write(Request.PathInfo.Equals("/") || Request.PathInfo.Equals("") ? "active" : null);

            
            #line default
            #line hidden
WriteLiteral("\">\r\n                            <a href=\"");


            
            #line 35 "..\..\Pages\LayoutPage.cshtml"
                                Write(Request.LinkTo("/"));

            
            #line default
            #line hidden
WriteLiteral("\">Dashboard</a>\r\n                        </li>\r\n                        <li class" +
"=\"");


            
            #line 37 "..\..\Pages\LayoutPage.cshtml"
                               Write(Request.PathInfo.Equals("/servers") ? "active" : null);

            
            #line default
            #line hidden
WriteLiteral("\">\r\n                            <a href=\"");


            
            #line 38 "..\..\Pages\LayoutPage.cshtml"
                                 Write(Request.LinkTo("/servers"));

            
            #line default
            #line hidden
WriteLiteral("\">\r\n                                Servers\r\n                                <spa" +
"n class=\"badge\">");


            
            #line 40 "..\..\Pages\LayoutPage.cshtml"
                                               Write(Storage.Servers().Count());

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n                            </a>                            \r\n          " +
"              </li>\r\n                        <li class=\"");


            
            #line 43 "..\..\Pages\LayoutPage.cshtml"
                               Write(Request.PathInfo.Equals("/queues") ? "active" : null);

            
            #line default
            #line hidden
WriteLiteral("\">\r\n                            <a href=\"");


            
            #line 44 "..\..\Pages\LayoutPage.cshtml"
                                Write(Request.LinkTo("/queues"));

            
            #line default
            #line hidden
WriteLiteral("\">\r\n                                Queues\r\n                                <span" +
" class=\"badge\">");


            
            #line 46 "..\..\Pages\LayoutPage.cshtml"
                                               Write(Storage.Queues().Count());

            
            #line default
            #line hidden
WriteLiteral(@"</span>
                            </a>
                        </li>
                    </ul>
                    <ul class=""nav navbar-nav navbar-right"">
                        <li>
                            <a href=""/"">Back to site</a>
                        </li>
                    </ul>
                </div>
                <!--/.nav-collapse -->
            </div>
        </div>

        <!-- Begin page content -->

        <div class=""container"">
            <div class=""col-md-3"">
                <div id=""stats"" class=""list-group"" data-refresh-url=""");


            
            #line 64 "..\..\Pages\LayoutPage.cshtml"
                                                                Write(Request.LinkTo("/stats"));

            
            #line default
            #line hidden
WriteLiteral("\">\r\n                    <a class=\"list-group-item ");


            
            #line 65 "..\..\Pages\LayoutPage.cshtml"
                                          Write(Request.PathInfo.Equals("/succeeded") ? "active" : null);

            
            #line default
            #line hidden
WriteLiteral("\" \r\n                        href=\"");


            
            #line 66 "..\..\Pages\LayoutPage.cshtml"
                         Write(Request.LinkTo("/succeeded"));

            
            #line default
            #line hidden
WriteLiteral("\">\r\n                        <span id=\"stats-succeeded\" class=\"label label-success" +
" pull-right\">\r\n                            ");


            
            #line 68 "..\..\Pages\LayoutPage.cshtml"
                       Write(String.Format("{0:n0}", Storage.SucceededCount()));

            
            #line default
            #line hidden
WriteLiteral("\r\n                        </span>\r\n                        Succeeded\r\n           " +
"         </a>\r\n                    <a class=\"list-group-item ");


            
            #line 72 "..\..\Pages\LayoutPage.cshtml"
                                          Write(Request.PathInfo.Equals("/failed") ? "active" : null);

            
            #line default
            #line hidden
WriteLiteral("\" \r\n                        href=\"");


            
            #line 73 "..\..\Pages\LayoutPage.cshtml"
                         Write(Request.LinkTo("/failed"));

            
            #line default
            #line hidden
WriteLiteral("\">\r\n                        <span id=\"stats-failed\" class=\"label label-danger pul" +
"l-right\">\r\n                            ");


            
            #line 75 "..\..\Pages\LayoutPage.cshtml"
                       Write(String.Format("{0:n0}", Storage.FailedCount()));

            
            #line default
            #line hidden
WriteLiteral("\r\n                        </span>\r\n                        Failed\r\n              " +
"      </a>\r\n                    <a class=\"list-group-item ");


            
            #line 79 "..\..\Pages\LayoutPage.cshtml"
                                          Write(Request.PathInfo.Equals("/dispatchers") ? "active" : null);

            
            #line default
            #line hidden
WriteLiteral("\" \r\n                        href=\"");


            
            #line 80 "..\..\Pages\LayoutPage.cshtml"
                         Write(Request.LinkTo("/dispatchers"));

            
            #line default
            #line hidden
WriteLiteral("\">\r\n                        <span id=\"stats-dispatchers\" class=\"label label-warni" +
"ng pull-right\">\r\n                            ");


            
            #line 82 "..\..\Pages\LayoutPage.cshtml"
                       Write(String.Format("{0:n0}", Storage.Dispatchers().Count()));

            
            #line default
            #line hidden
WriteLiteral("\r\n                        </span>\r\n                        Processing\r\n          " +
"          </a>\r\n                    <a class=\"list-group-item ");


            
            #line 86 "..\..\Pages\LayoutPage.cshtml"
                                          Write(Request.PathInfo.Equals("/schedule") ? "active" : null);

            
            #line default
            #line hidden
WriteLiteral("\" \r\n                        href=\"");


            
            #line 87 "..\..\Pages\LayoutPage.cshtml"
                         Write(Request.LinkTo("/schedule"));

            
            #line default
            #line hidden
WriteLiteral("\">\r\n                        <span id=\"stats-scheduled\" class=\"label label-primary" +
" pull-right\">\r\n                            ");


            
            #line 89 "..\..\Pages\LayoutPage.cshtml"
                       Write(String.Format("{0:n0}", Storage.ScheduledCount()));

            
            #line default
            #line hidden
WriteLiteral(@"
                        </span>
                        Scheduled
                    </a>
                    <a class=""list-group-item"" href=""#"">
                        <span id=""stats-enqueued"" class=""label label-default pull-right"">
                            ");


            
            #line 95 "..\..\Pages\LayoutPage.cshtml"
                       Write(String.Format("{0:n0}", Storage.EnqueuedCount()));

            
            #line default
            #line hidden
WriteLiteral(@"
                        </span>
                        Enqueued
                    </a>
                </div>

                <label>Test jobs</label>
                <div class=""input-group"">
                    <input type=""text"" class=""form-control"">
                    <span class=""input-group-btn"">
                        <button class=""btn btn-default"" type=""button"">Go</button>
                    </span>
                </div>
            </div>
            <div class=""col-md-9"">
                <h1 class=""page-header"">");


            
            #line 110 "..\..\Pages\LayoutPage.cshtml"
                                   Write(Title);

            
            #line default
            #line hidden
WriteLiteral("</h1>\r\n                ");


            
            #line 111 "..\..\Pages\LayoutPage.cshtml"
           Write(RenderBody());

            
            #line default
            #line hidden
WriteLiteral(@"
            </div>
        </div>
    </div>

    <div id=""footer"">
        <div class=""container"">
            <ul class=""list-inline credit"">
                <li>
                    <a href=""http://github.io/odinserj/hangfire"" target=""_blank"">
                        HangFire 
                        ");


            
            #line 122 "..\..\Pages\LayoutPage.cshtml"
                   Write(AssemblyName.GetAssemblyName(GetType().Assembly.Location).Version);

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </a>\r\n                </li>\r\n                <li>Redis: \r\n " +
"                   ");


            
            #line 126 "..\..\Pages\LayoutPage.cshtml"
               Write(String.Format("{0}:{1}/{2}", Configuration.Instance.RedisHost, Configuration.Instance.RedisPort, Configuration.Instance.RedisDb));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </li>\r\n                <li>Time: ");


            
            #line 128 "..\..\Pages\LayoutPage.cshtml"
                     Write(DateTime.UtcNow.ToString());

            
            #line default
            #line hidden
WriteLiteral(" UTC\r\n                </li>\r\n            </ul>\r\n        </div>\r\n    </div>\r\n    \r" +
"\n    <script src=\"");


            
            #line 134 "..\..\Pages\LayoutPage.cshtml"
            Write(Request.LinkTo("/scripts.js"));

            
            #line default
            #line hidden
WriteLiteral("\"></script>\r\n</body>\r\n</html>\r\n");


        }
    }
}
#pragma warning restore 1591
