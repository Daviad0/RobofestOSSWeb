#pragma checksum "C:\Users\djree\source\repos\RobofestOSS\RobofestOSSWeb\RobofestWTECore\Views\Team\TeamMatches.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fdcf68b5855d72973abd2dec3d391693fe2f1206"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(RobofestWTECore.Pages.Team.Views_Team_TeamMatches), @"mvc.1.0.view", @"/Views/Team/TeamMatches.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Team/TeamMatches.cshtml", typeof(RobofestWTECore.Pages.Team.Views_Team_TeamMatches))]
namespace RobofestWTECore.Pages.Team
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\djree\source\repos\RobofestOSS\RobofestOSSWeb\RobofestWTECore\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "C:\Users\djree\source\repos\RobofestOSS\RobofestOSSWeb\RobofestWTECore\Views\_ViewImports.cshtml"
using RobofestWTECore;

#line default
#line hidden
#line 3 "C:\Users\djree\source\repos\RobofestOSS\RobofestOSSWeb\RobofestWTECore\Views\_ViewImports.cshtml"
using RobofestWTECore.Data;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fdcf68b5855d72973abd2dec3d391693fe2f1206", @"/Views/Team/TeamMatches.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce755af2a7418f0d746543a6139563ea8d84f149", @"/Views/_ViewImports.cshtml")]
    public class Views_Team_TeamMatches : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RobofestWTECore.Models.ViewModels.TeamMatchDataModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/signalr/dist/browser/signalr.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(61, 250, true);
            WriteLiteral("\r\n<h1>Team Matches</h1>\r\n<div>\r\n    <input type=\"button\" class=\"btn btn-success\" id=\"listallteams\" value=\"Save Changes\" />\r\n    <input type=\"button\" class=\"btn btn-danger\" id=\"discardchanges\" value=\"Discard Changes\" />\r\n    <a class=\"btn btn-warning\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 311, "\"", 356, 1);
#line 7 "C:\Users\djree\source\repos\RobofestOSS\RobofestOSSWeb\RobofestWTECore\Views\Team\TeamMatches.cshtml"
WriteAttributeValue("", 318, Url.Action("TeamMatchesEdit", "Team"), 318, 38, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(357, 85, true);
            WriteLiteral(">Edit Match Status</a>\r\n    <input type=\"number\" class=\"input-lg\" id=\"numberoffields\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 442, "\"", 466, 1);
#line 8 "C:\Users\djree\source\repos\RobofestOSS\RobofestOSSWeb\RobofestWTECore\Views\Team\TeamMatches.cshtml"
WriteAttributeValue("", 450, Model.NumFields, 450, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(467, 21, true);
            WriteLiteral(" />\r\n</div>\r\n<br />\r\n");
            EndContext();
#line 11 "C:\Users\djree\source\repos\RobofestOSS\RobofestOSSWeb\RobofestWTECore\Views\Team\TeamMatches.cshtml"
   int i = 0;

#line default
#line hidden
#line 12 "C:\Users\djree\source\repos\RobofestOSS\RobofestOSSWeb\RobofestWTECore\Views\Team\TeamMatches.cshtml"
 foreach (var match in Model.Matches.OrderBy(m => m.MatchID).ThenBy(m => m.Order))
        {
            i++;
            string idtoinput = i.ToString() + "-" + match.Order;
            string idtoinputbutton = i.ToString() + "-" + match.Order + "-add";
            string idtoinputteam = i.ToString() + "-" + match.Order + "-team";
            string idtoinputbuttonremove = i.ToString() + "-" + match.Order + "-remove";
            string idtoinputround = i.ToString() + "-" + match.Order + "-round";
            string idtoinputcompleted = i.ToString() + "-" + match.Order + "-completed";
            string idtoinputrerun = i.ToString() + "-" + match.Order + "-rerun";
            string idtoinputtestmatch = i.ToString() + "-" + match.Order + "-testmatch";
            string idtoinputparentc = i.ToString() + "-" + match.Order + "-parentcomp";
            string idtoinputparentt = i.ToString() + "-" + match.Order + "-parenttest";
            string idtoinputparentr = i.ToString() + "-" + match.Order + "-parentrerun";

#line default
#line hidden
            BeginContext(1546, 116, true);
            WriteLiteral("<div style=\"background-color:lightgray;border-radius:6px;border:10px solid lightgray;z-index:-1;margin-bottom:10px;\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1662, "\"", 1677, 1);
#line 26 "C:\Users\djree\source\repos\RobofestOSS\RobofestOSSWeb\RobofestWTECore\Views\Team\TeamMatches.cshtml"
WriteAttributeValue("", 1667, idtoinput, 1667, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1678, 71, true);
            WriteLiteral(" class=\"matchentry\">\r\n    <input type=\"text\" class=\"teamentry input-sm\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1749, "\"", 1774, 1);
#line 27 "C:\Users\djree\source\repos\RobofestOSS\RobofestOSSWeb\RobofestWTECore\Views\Team\TeamMatches.cshtml"
WriteAttributeValue("", 1757, match.TeamNumber, 1757, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1775, 40, true);
            WriteLiteral(" maxlength=\"7\" placeholder=\"Team Number\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1815, "\"", 1834, 1);
#line 27 "C:\Users\djree\source\repos\RobofestOSS\RobofestOSSWeb\RobofestWTECore\Views\Team\TeamMatches.cshtml"
WriteAttributeValue("", 1820, idtoinputteam, 1820, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1835, 50, true);
            WriteLiteral(" />\r\n    <input type=\"button\" class=\"btn addafter\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1885, "\"", 1906, 1);
#line 28 "C:\Users\djree\source\repos\RobofestOSS\RobofestOSSWeb\RobofestWTECore\Views\Team\TeamMatches.cshtml"
WriteAttributeValue("", 1890, idtoinputbutton, 1890, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1907, 79, true);
            WriteLiteral(" value=\"Add Another Below\" />\r\n    <input type=\"button\" class=\"btn removeentry\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1986, "\"", 2013, 1);
#line 29 "C:\Users\djree\source\repos\RobofestOSS\RobofestOSSWeb\RobofestWTECore\Views\Team\TeamMatches.cshtml"
WriteAttributeValue("", 1991, idtoinputbuttonremove, 1991, 22, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2014, 41, true);
            WriteLiteral(" value=\"Delete This Entry\" />\r\n    <label");
            EndContext();
            BeginWriteAttribute("for", " for=\"", 2055, "\"", 2076, 1);
#line 30 "C:\Users\djree\source\repos\RobofestOSS\RobofestOSSWeb\RobofestWTECore\Views\Team\TeamMatches.cshtml"
WriteAttributeValue("", 2061, idtoinputround, 2061, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2077, 59, true);
            WriteLiteral(">Round #</label>\r\n    <input type=\"number\" class=\"input-sm\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2136, "\"", 2159, 1);
#line 31 "C:\Users\djree\source\repos\RobofestOSS\RobofestOSSWeb\RobofestWTECore\Views\Team\TeamMatches.cshtml"
WriteAttributeValue("", 2144, match.RoundNum, 2144, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=\"", 2160, "\"", 2180, 1);
#line 31 "C:\Users\djree\source\repos\RobofestOSS\RobofestOSSWeb\RobofestWTECore\Views\Team\TeamMatches.cshtml"
WriteAttributeValue("", 2165, idtoinputround, 2165, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2181, 43, true);
            WriteLiteral(" placeholder=\"Round #\" max=\"2\" min=\"1\" />\r\n");
            EndContext();
#line 32 "C:\Users\djree\source\repos\RobofestOSS\RobofestOSSWeb\RobofestWTECore\Views\Team\TeamMatches.cshtml"
     if (match.Completed == true)
    {

#line default
#line hidden
            BeginContext(2266, 83, true);
            WriteLiteral("        <label class=\"checkbox-inline\" style=\"background-color:dimgray;color:white\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 2349, "\"", 2371, 1);
#line 34 "C:\Users\djree\source\repos\RobofestOSS\RobofestOSSWeb\RobofestWTECore\Views\Team\TeamMatches.cshtml"
WriteAttributeValue("", 2354, idtoinputparentc, 2354, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2372, 54, true);
            WriteLiteral(">\r\n            <input type=\"checkbox\" class=\"checkbox\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 2426, "\"", 2450, 1);
#line 35 "C:\Users\djree\source\repos\RobofestOSS\RobofestOSSWeb\RobofestWTECore\Views\Team\TeamMatches.cshtml"
WriteAttributeValue("", 2431, idtoinputcompleted, 2431, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2451, 47, true);
            WriteLiteral(" checked />Status Completed\r\n        </label>\r\n");
            EndContext();
#line 37 "C:\Users\djree\source\repos\RobofestOSS\RobofestOSSWeb\RobofestWTECore\Views\Team\TeamMatches.cshtml"
    }
    else if (match.Completed == false)
    {

#line default
#line hidden
            BeginContext(2552, 86, true);
            WriteLiteral("        <label class=\"checkbox-inline\" style=\"background-color:darkorange;color:white\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 2638, "\"", 2660, 1);
#line 40 "C:\Users\djree\source\repos\RobofestOSS\RobofestOSSWeb\RobofestWTECore\Views\Team\TeamMatches.cshtml"
WriteAttributeValue("", 2643, idtoinputparentc, 2643, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2661, 54, true);
            WriteLiteral(">\r\n            <input type=\"checkbox\" class=\"checkbox\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 2715, "\"", 2739, 1);
#line 41 "C:\Users\djree\source\repos\RobofestOSS\RobofestOSSWeb\RobofestWTECore\Views\Team\TeamMatches.cshtml"
WriteAttributeValue("", 2720, idtoinputcompleted, 2720, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2740, 39, true);
            WriteLiteral(" />Status Completed\r\n        </label>\r\n");
            EndContext();
#line 43 "C:\Users\djree\source\repos\RobofestOSS\RobofestOSSWeb\RobofestWTECore\Views\Team\TeamMatches.cshtml"
    }

#line default
#line hidden
            BeginContext(2786, 4, true);
            WriteLiteral("    ");
            EndContext();
#line 44 "C:\Users\djree\source\repos\RobofestOSS\RobofestOSSWeb\RobofestWTECore\Views\Team\TeamMatches.cshtml"
     if (match.Test == true)
    {

#line default
#line hidden
            BeginContext(2823, 84, true);
            WriteLiteral("        <label class=\"checkbox-inline\" style=\"background-color:deeppink;color:white\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 2907, "\"", 2929, 1);
#line 46 "C:\Users\djree\source\repos\RobofestOSS\RobofestOSSWeb\RobofestWTECore\Views\Team\TeamMatches.cshtml"
WriteAttributeValue("", 2912, idtoinputparentt, 2912, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2930, 54, true);
            WriteLiteral(">\r\n            <input type=\"checkbox\" class=\"checkbox\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 2984, "\"", 3008, 1);
#line 47 "C:\Users\djree\source\repos\RobofestOSS\RobofestOSSWeb\RobofestWTECore\Views\Team\TeamMatches.cshtml"
WriteAttributeValue("", 2989, idtoinputtestmatch, 2989, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3009, 41, true);
            WriteLiteral(" checked />Test Match\r\n        </label>\r\n");
            EndContext();
#line 49 "C:\Users\djree\source\repos\RobofestOSS\RobofestOSSWeb\RobofestWTECore\Views\Team\TeamMatches.cshtml"
    }
    else
    {

#line default
#line hidden
            BeginContext(3074, 83, true);
            WriteLiteral("        <label class=\"checkbox-inline\" style=\"background-color:dimgray;color:white\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 3157, "\"", 3179, 1);
#line 52 "C:\Users\djree\source\repos\RobofestOSS\RobofestOSSWeb\RobofestWTECore\Views\Team\TeamMatches.cshtml"
WriteAttributeValue("", 3162, idtoinputparentt, 3162, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3180, 54, true);
            WriteLiteral(">\r\n            <input type=\"checkbox\" class=\"checkbox\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 3234, "\"", 3258, 1);
#line 53 "C:\Users\djree\source\repos\RobofestOSS\RobofestOSSWeb\RobofestWTECore\Views\Team\TeamMatches.cshtml"
WriteAttributeValue("", 3239, idtoinputtestmatch, 3239, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3259, 33, true);
            WriteLiteral(" />Test Match\r\n        </label>\r\n");
            EndContext();
#line 55 "C:\Users\djree\source\repos\RobofestOSS\RobofestOSSWeb\RobofestWTECore\Views\Team\TeamMatches.cshtml"
    }

#line default
#line hidden
            BeginContext(3299, 4, true);
            WriteLiteral("    ");
            EndContext();
#line 56 "C:\Users\djree\source\repos\RobofestOSS\RobofestOSSWeb\RobofestWTECore\Views\Team\TeamMatches.cshtml"
     if (match.Rerun == true)
    {

#line default
#line hidden
            BeginContext(3337, 87, true);
            WriteLiteral("        <label class=\"checkbox-inline\" style=\"background-color:forestgreen;color:white\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 3424, "\"", 3446, 1);
#line 58 "C:\Users\djree\source\repos\RobofestOSS\RobofestOSSWeb\RobofestWTECore\Views\Team\TeamMatches.cshtml"
WriteAttributeValue("", 3429, idtoinputparentr, 3429, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3447, 54, true);
            WriteLiteral(">\r\n            <input type=\"checkbox\" class=\"checkbox\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 3501, "\"", 3521, 1);
#line 59 "C:\Users\djree\source\repos\RobofestOSS\RobofestOSSWeb\RobofestWTECore\Views\Team\TeamMatches.cshtml"
WriteAttributeValue("", 3506, idtoinputrerun, 3506, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3522, 36, true);
            WriteLiteral(" checked />Rerun\r\n        </label>\r\n");
            EndContext();
#line 61 "C:\Users\djree\source\repos\RobofestOSS\RobofestOSSWeb\RobofestWTECore\Views\Team\TeamMatches.cshtml"
    }
    else
    {

#line default
#line hidden
            BeginContext(3582, 83, true);
            WriteLiteral("        <label class=\"checkbox-inline\" style=\"background-color:dimgray;color:white\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 3665, "\"", 3687, 1);
#line 64 "C:\Users\djree\source\repos\RobofestOSS\RobofestOSSWeb\RobofestWTECore\Views\Team\TeamMatches.cshtml"
WriteAttributeValue("", 3670, idtoinputparentr, 3670, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3688, 54, true);
            WriteLiteral(">\r\n            <input type=\"checkbox\" class=\"checkbox\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 3742, "\"", 3762, 1);
#line 65 "C:\Users\djree\source\repos\RobofestOSS\RobofestOSSWeb\RobofestWTECore\Views\Team\TeamMatches.cshtml"
WriteAttributeValue("", 3747, idtoinputrerun, 3747, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3763, 28, true);
            WriteLiteral(" />Rerun\r\n        </label>\r\n");
            EndContext();
#line 67 "C:\Users\djree\source\repos\RobofestOSS\RobofestOSSWeb\RobofestWTECore\Views\Team\TeamMatches.cshtml"
    }

#line default
#line hidden
            BeginContext(3798, 16, true);
            WriteLiteral("\r\n\r\n\r\n\r\n</div>\r\n");
            EndContext();
#line 73 "C:\Users\djree\source\repos\RobofestOSS\RobofestOSSWeb\RobofestWTECore\Views\Team\TeamMatches.cshtml"
}

#line default
#line hidden
            BeginContext(3817, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eb6a15d5b88c414998ea434b4642c438", async() => {
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
            EndContext();
            BeginContext(3878, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(3880, 51, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2518c740e8b84e57b8711daa92c956bc", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3931, 3728, true);
            WriteLiteral(@"
<script>
    var chat = new signalR.HubConnectionBuilder().withUrl(""/scoreHub"").build();
    var i = 0;
    var reloads = 0;
    chat.on(""reloadRequired"", function () {
        reloads += 1
        if (reloads >= i) {
            location.reload(true)
        }
    });
    chat.start().then(function () {
        var scheduler = {
            ""schedules"" : []
        }
        $(document).on('click', '#listallteams', function () {
            chat.on(""addMatches"", function () {
                var numfields = parseInt($(""#numberoffields"").val())
                chat.invoke(""sendAllMatches"", numfields);
            });
            chat.invoke(""clearSchedule"");
            $("".matchentry"").each(function () {
                i += 1;
                var localid = this.id
                var numfields = parseInt($(""#numberoffields"").val())
                var schedule = {

                };
                schedule.TeamNumber = $(this).children(""#"" + localid + ""-team"").val();
        ");
            WriteLiteral(@"        schedule.RoundNum = $(this).children(""#"" + localid + ""-round"").val();
                schedule.CompID = 1;
                schedule.MatchID = i;
                schedule.Order = 1;
                schedule.Rerun = $(""#"" + localid + ""-rerun"").is("":checked"");
                schedule.Test = $(""#"" + localid + ""-testmatch"").is("":checked"");
                schedule.Completed = $(""#"" + localid + ""-completed"").is("":checked"");
                scheduler.schedules.push(schedule);
                completedschedule = JSON.stringify(schedule);
                chat.invoke(""changeMatches"", completedschedule, numfields);
            });
            
        });
        $(document).on('click', '.addafter', function () {
            var clearedstring = this.id.replace(""-add"", """");
            $(""#"" + clearedstring + ""-add"").attr(""disabled"", true)
            var newid = clearedstring.split(""-"")
            var newidstring = newid[0] + ""-"" + (parseInt(newid[1]) + 1)
            $(""<div style='backgroun");
            WriteLiteral(@"d-color:lightgray;border-radius:6px;border:10px solid lightgray;z-index:-1;margin-bottom:10px' id='"" + newidstring + ""' class='matchentry'><input type='text' class='teamentry input-sm' value='EMPTY' maxlength='7' placeholder='Team Number' id='"" + newidstring + ""-team' style='margin-right:4px'/><input type='button' class='btn addafter' id='"" + newidstring + ""-add' value='Add Another Below' style='margin-right:4px'/><input type='button' class='btn removeentry' id='"" + newidstring + ""-remove' value='Delete This Entry' placeholder='Round #' style='margin-right:4px'/><label for='"" + newidstring + ""-round' style='margin-right:4px'>Round #</label><input type='number' class='input-sm' id='"" + newidstring + ""-round' value=1 max='2' min='1' style='margin-right:4px'/><label class='checkbox-inline' style='background-color:darkorange;color:white'><input type='checkbox' class='checkbox' id='"" + newidstring + ""-completed' />Status Completed</label><label class='checkbox-inline' style='background-color:dimgray;color:white'><");
            WriteLiteral(@"input type='checkbox' class='checkbox' id='"" + newidstring + ""-testmatch' />Test Match</label><label class='checkbox-inline' style='background-color:dimgray;color:white'><input type='checkbox' class='checkbox' id='"" + newidstring + ""-rerun' />Rerun</label></div>"").insertAfter(""#"" + clearedstring)
        });
        $(document).on('click', '.removeentry', function () {
            var clearedstring = this.id.replace(""-remove"", """");
            $(""#"" + clearedstring).remove();
        });
        $(""#discardchanges"").on(""click"", function () {
            location.reload(true);
        });
        //
    
    
        
    });
</script>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RobofestWTECore.Models.ViewModels.TeamMatchDataModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
