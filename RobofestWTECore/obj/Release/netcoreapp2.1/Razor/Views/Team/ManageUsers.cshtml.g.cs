#pragma checksum "C:\Users\djree\source\repos\RobofestOSS\RobofestOSSWeb\RobofestWTECore\Views\Team\ManageUsers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "66a93f6e713957b2197e2c1b25af0436f70288b1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(RobofestWTECore.Pages.Team.Views_Team_ManageUsers), @"mvc.1.0.view", @"/Views/Team/ManageUsers.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Team/ManageUsers.cshtml", typeof(RobofestWTECore.Pages.Team.Views_Team_ManageUsers))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"66a93f6e713957b2197e2c1b25af0436f70288b1", @"/Views/Team/ManageUsers.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce755af2a7418f0d746543a6139563ea8d84f149", @"/Views/_ViewImports.cshtml")]
    public class Views_Team_ManageUsers : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<RobofestWTE.Models.UserListModel>>
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(47, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\djree\source\repos\RobofestOSS\RobofestOSSWeb\RobofestWTECore\Views\Team\ManageUsers.cshtml"
  
    ViewBag.Title = "Users";

#line default
#line hidden
            BeginContext(86, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(90, 8301, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f1695a1f75944ac284e9abbc0098f566", async() => {
                BeginContext(96, 448, true);
                WriteLiteral(@"
        <h2>Volunteer Role Management</h2>

        <table class=""table table-hover"">
            <tr style=""font-size:20px"">
                <th style=""background-color:#ffffff"">
                    Username
                </th>
                <th style=""background-color:#ffffff"">
                    Role(s)
                </th>
                <th>
                    Add or Remove
                </th>
            </tr>

");
                EndContext();
#line 22 "C:\Users\djree\source\repos\RobofestOSS\RobofestOSSWeb\RobofestWTECore\Views\Team\ManageUsers.cshtml"
             foreach (var user in Model.OrderBy(x => x.UserName))
            {


#line default
#line hidden
                BeginContext(628, 72, true);
                WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(701, 13, false);
#line 27 "C:\Users\djree\source\repos\RobofestOSS\RobofestOSSWeb\RobofestWTECore\Views\Team\ManageUsers.cshtml"
                   Write(user.UserName);

#line default
#line hidden
                EndContext();
                BeginContext(714, 52, true);
                WriteLiteral("\r\n                    </td>\r\n                    <td");
                EndContext();
                BeginWriteAttribute("id", " id=\"", 766, "\"", 785, 1);
#line 29 "C:\Users\djree\source\repos\RobofestOSS\RobofestOSSWeb\RobofestWTECore\Views\Team\ManageUsers.cshtml"
WriteAttributeValue("", 771, user.UserName, 771, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("class", " class=\"", 786, "\"", 808, 1);
#line 29 "C:\Users\djree\source\repos\RobofestOSS\RobofestOSSWeb\RobofestWTECore\Views\Team\ManageUsers.cshtml"
WriteAttributeValue("", 794, user.UserName, 794, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(809, 3, true);
                WriteLiteral(">\r\n");
                EndContext();
#line 30 "C:\Users\djree\source\repos\RobofestOSS\RobofestOSSWeb\RobofestWTECore\Views\Team\ManageUsers.cshtml"
                          
                            int i = 0;
                        

#line default
#line hidden
                BeginContext(907, 24, true);
                WriteLiteral("                        ");
                EndContext();
#line 33 "C:\Users\djree\source\repos\RobofestOSS\RobofestOSSWeb\RobofestWTECore\Views\Team\ManageUsers.cshtml"
                         foreach (var role in user.Roles)
                        {
                            i++;
                            if (role == "Judge")
                            {

#line default
#line hidden
                BeginContext(1108, 158, true);
                WriteLiteral("                                <span style=\"background-color:blue;color:white;padding:3px;border-radius:2px;margin-bottom:10px;font-size:10px\">Judge</span>\r\n");
                EndContext();
#line 39 "C:\Users\djree\source\repos\RobofestOSS\RobofestOSSWeb\RobofestWTECore\Views\Team\ManageUsers.cshtml"
                            }
                            else if (role == "FieldStaff")
                            {

#line default
#line hidden
                BeginContext(1388, 174, true);
                WriteLiteral("                                <span style=\"background-color:cornflowerblue;color:white;padding:3px;border-radius:2px;margin-bottom:10px;font-size:10px\">Field Staff</span>\r\n");
                EndContext();
#line 43 "C:\Users\djree\source\repos\RobofestOSS\RobofestOSSWeb\RobofestWTECore\Views\Team\ManageUsers.cshtml"
                            }
                            else if (role == "Manager")
                            {

#line default
#line hidden
                BeginContext(1681, 169, true);
                WriteLiteral("                                <span style=\"background-color:darkorchid;color:white;padding:3px;border-radius:2px;margin-bottom:10px;font-size:10px\">Management</span>\r\n");
                EndContext();
#line 47 "C:\Users\djree\source\repos\RobofestOSS\RobofestOSSWeb\RobofestWTECore\Views\Team\ManageUsers.cshtml"
                            }
                            else if (role == "Admin")
                            {

#line default
#line hidden
                BeginContext(1967, 162, true);
                WriteLiteral("                                <span style=\"background-color:deeppink;color:white;padding:3px;border-radius:2px;margin-bottom:10px;font-size:10px\">Admin</span>\r\n");
                EndContext();
#line 51 "C:\Users\djree\source\repos\RobofestOSS\RobofestOSSWeb\RobofestWTECore\Views\Team\ManageUsers.cshtml"
                            }
                            else if (role == "Main")
                            {

#line default
#line hidden
                BeginContext(2245, 167, true);
                WriteLiteral("                                <span style=\"background-color:orange;color:white;padding:3px;border-radius:2px;margin-bottom:10px;font-size:10px\">Main Account</span>\r\n");
                EndContext();
#line 55 "C:\Users\djree\source\repos\RobofestOSS\RobofestOSSWeb\RobofestWTECore\Views\Team\ManageUsers.cshtml"
                            }
                            else if (role == "Tech")
                            {

#line default
#line hidden
                BeginContext(2528, 171, true);
                WriteLiteral("                                <span style=\"background-color:hotpink;color:white;padding:3px;border-radius:2px;margin-bottom:10px;font-size:10px\">Website Manager</span>\r\n");
                EndContext();
#line 59 "C:\Users\djree\source\repos\RobofestOSS\RobofestOSSWeb\RobofestWTECore\Views\Team\ManageUsers.cshtml"
                            }
                            else if (role == "Locked")
                            {

#line default
#line hidden
                BeginContext(2817, 157, true);
                WriteLiteral("                                <span style=\"border:2px red dashed;color:red;padding:3px;border-radius:2px;margin-bottom:10px;font-size:10px\">Locked</span>\r\n");
                EndContext();
#line 63 "C:\Users\djree\source\repos\RobofestOSS\RobofestOSSWeb\RobofestWTECore\Views\Team\ManageUsers.cshtml"
                            }

                        }

#line default
#line hidden
                BeginContext(3034, 24, true);
                WriteLiteral("                        ");
                EndContext();
#line 66 "C:\Users\djree\source\repos\RobofestOSS\RobofestOSSWeb\RobofestWTECore\Views\Team\ManageUsers.cshtml"
                         if (i == 0)
                        {

#line default
#line hidden
                BeginContext(3099, 139, true);
                WriteLiteral("                            <span style=\"background-color:lightgray;color:black;padding:3px;border-radius:2px\">Student / Spectator</span>\r\n");
                EndContext();
#line 69 "C:\Users\djree\source\repos\RobofestOSS\RobofestOSSWeb\RobofestWTECore\Views\Team\ManageUsers.cshtml"
                        }

#line default
#line hidden
                BeginContext(3265, 112, true);
                WriteLiteral("                    </td>\r\n                    <td>\r\n                        <button type=\"button\" class=\"judge\"");
                EndContext();
                BeginWriteAttribute("id", " id=\"", 3377, "\"", 3394, 1);
#line 72 "C:\Users\djree\source\repos\RobofestOSS\RobofestOSSWeb\RobofestWTECore\Views\Team\ManageUsers.cshtml"
WriteAttributeValue("", 3382, user.UserID, 3382, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 3395, "\"", 3417, 1);
#line 72 "C:\Users\djree\source\repos\RobofestOSS\RobofestOSSWeb\RobofestWTECore\Views\Team\ManageUsers.cshtml"
WriteAttributeValue("", 3403, user.UserName, 3403, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3418, 78, true);
                WriteLiteral(">Judge</button>\r\n                        <button type=\"button\" class=\"manager\"");
                EndContext();
                BeginWriteAttribute("id", " id=\"", 3496, "\"", 3513, 1);
#line 73 "C:\Users\djree\source\repos\RobofestOSS\RobofestOSSWeb\RobofestWTECore\Views\Team\ManageUsers.cshtml"
WriteAttributeValue("", 3501, user.UserID, 3501, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 3514, "\"", 3536, 1);
#line 73 "C:\Users\djree\source\repos\RobofestOSS\RobofestOSSWeb\RobofestWTECore\Views\Team\ManageUsers.cshtml"
WriteAttributeValue("", 3522, user.UserName, 3522, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3537, 83, true);
                WriteLiteral(">Manager</button>\r\n                        <button type=\"button\" class=\"fieldstaff\"");
                EndContext();
                BeginWriteAttribute("id", " id=\"", 3620, "\"", 3637, 1);
#line 74 "C:\Users\djree\source\repos\RobofestOSS\RobofestOSSWeb\RobofestWTECore\Views\Team\ManageUsers.cshtml"
WriteAttributeValue("", 3625, user.UserID, 3625, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 3638, "\"", 3660, 1);
#line 74 "C:\Users\djree\source\repos\RobofestOSS\RobofestOSSWeb\RobofestWTECore\Views\Team\ManageUsers.cshtml"
WriteAttributeValue("", 3646, user.UserName, 3646, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3661, 82, true);
                WriteLiteral(">Field Staff</button>\r\n                        <button type=\"button\" class=\"admin\"");
                EndContext();
                BeginWriteAttribute("id", " id=\"", 3743, "\"", 3760, 1);
#line 75 "C:\Users\djree\source\repos\RobofestOSS\RobofestOSSWeb\RobofestWTECore\Views\Team\ManageUsers.cshtml"
WriteAttributeValue("", 3748, user.UserID, 3748, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 3761, "\"", 3783, 1);
#line 75 "C:\Users\djree\source\repos\RobofestOSS\RobofestOSSWeb\RobofestWTECore\Views\Team\ManageUsers.cshtml"
WriteAttributeValue("", 3769, user.UserName, 3769, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3784, 75, true);
                WriteLiteral(">Admin</button>\r\n                        <button type=\"button\" class=\"tech\"");
                EndContext();
                BeginWriteAttribute("id", " id=\"", 3859, "\"", 3876, 1);
#line 76 "C:\Users\djree\source\repos\RobofestOSS\RobofestOSSWeb\RobofestWTECore\Views\Team\ManageUsers.cshtml"
WriteAttributeValue("", 3864, user.UserID, 3864, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 3877, "\"", 3899, 1);
#line 76 "C:\Users\djree\source\repos\RobofestOSS\RobofestOSSWeb\RobofestWTECore\Views\Team\ManageUsers.cshtml"
WriteAttributeValue("", 3885, user.UserName, 3885, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3900, 87, true);
                WriteLiteral(">Website Manager</button>\r\n                        <button type=\"button\" class=\"banned\"");
                EndContext();
                BeginWriteAttribute("id", " id=\"", 3987, "\"", 4004, 1);
#line 77 "C:\Users\djree\source\repos\RobofestOSS\RobofestOSSWeb\RobofestWTECore\Views\Team\ManageUsers.cshtml"
WriteAttributeValue("", 3992, user.UserID, 3992, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4005, 39, true);
                WriteLiteral(" style=\"background-color:palevioletred\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 4044, "\"", 4066, 1);
#line 77 "C:\Users\djree\source\repos\RobofestOSS\RobofestOSSWeb\RobofestWTECore\Views\Team\ManageUsers.cshtml"
WriteAttributeValue("", 4052, user.UserName, 4052, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4067, 70, true);
                WriteLiteral(">Lock Out</button>\r\n                    </td>\r\n                </tr>\r\n");
                EndContext();
#line 80 "C:\Users\djree\source\repos\RobofestOSS\RobofestOSSWeb\RobofestWTECore\Views\Team\ManageUsers.cshtml"
            }

#line default
#line hidden
                BeginContext(4152, 473, true);
                WriteLiteral(@"
        </table>

        <h2>Judge Field Assignments</h2>
        <table class=""table table-hover"">
            <tr style=""font-size:20px"">
                <th style=""        background-color: #ffffff"">
                    Username
                </th>
                <th style=""background-color:#ffffff"">
                    Role(s)
                </th>
                <th>
                    Add or Remove
                </th>
            </tr>

");
                EndContext();
#line 98 "C:\Users\djree\source\repos\RobofestOSS\RobofestOSSWeb\RobofestWTECore\Views\Team\ManageUsers.cshtml"
             foreach (var user in Model.Where(u => u.Roles.Contains("Judge")).OrderBy(x => x.UserName))
            {


#line default
#line hidden
                BeginContext(4747, 72, true);
                WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(4820, 13, false);
#line 103 "C:\Users\djree\source\repos\RobofestOSS\RobofestOSSWeb\RobofestWTECore\Views\Team\ManageUsers.cshtml"
                   Write(user.UserName);

#line default
#line hidden
                EndContext();
                BeginContext(4833, 52, true);
                WriteLiteral("\r\n                    </td>\r\n                    <td");
                EndContext();
                BeginWriteAttribute("id", " id=\"", 4885, "\"", 4904, 1);
#line 105 "C:\Users\djree\source\repos\RobofestOSS\RobofestOSSWeb\RobofestWTECore\Views\Team\ManageUsers.cshtml"
WriteAttributeValue("", 4890, user.UserName, 4890, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("class", " class=\"", 4905, "\"", 4927, 1);
#line 105 "C:\Users\djree\source\repos\RobofestOSS\RobofestOSSWeb\RobofestWTECore\Views\Team\ManageUsers.cshtml"
WriteAttributeValue("", 4913, user.UserName, 4913, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4928, 3, true);
                WriteLiteral(">\r\n");
                EndContext();
#line 106 "C:\Users\djree\source\repos\RobofestOSS\RobofestOSSWeb\RobofestWTECore\Views\Team\ManageUsers.cshtml"
                           int j = 0;

#line default
#line hidden
                BeginContext(4971, 24, true);
                WriteLiteral("                        ");
                EndContext();
#line 107 "C:\Users\djree\source\repos\RobofestOSS\RobofestOSSWeb\RobofestWTECore\Views\Team\ManageUsers.cshtml"
                         foreach (var role in user.Roles)
                        {
                            
                            if (role == "Field1")
                            {
                                j++;

#line default
#line hidden
                BeginContext(5207, 125, true);
                WriteLiteral("                                <span style=\"color:black;padding:3px;border-radius:2px;border:2px solid red\">Field 1</span>\r\n");
                EndContext();
#line 114 "C:\Users\djree\source\repos\RobofestOSS\RobofestOSSWeb\RobofestWTECore\Views\Team\ManageUsers.cshtml"
                            }
                            else if (role == "Field2")
                            {
                                j++;

#line default
#line hidden
                BeginContext(5488, 130, true);
                WriteLiteral("                                <span style=\"color: black;padding: 3px;border-radius: 2px;border: 2px solid blue\">Field 2</span>\r\n");
                EndContext();
#line 119 "C:\Users\djree\source\repos\RobofestOSS\RobofestOSSWeb\RobofestWTECore\Views\Team\ManageUsers.cshtml"
                            }
                            else if (role == "Field3")
                            {
                                j++;

#line default
#line hidden
                BeginContext(5774, 127, true);
                WriteLiteral("                                <span style=\"color:black;padding:3px;border-radius:2px;border:2px solid green\">Field 3</span>\r\n");
                EndContext();
#line 124 "C:\Users\djree\source\repos\RobofestOSS\RobofestOSSWeb\RobofestWTECore\Views\Team\ManageUsers.cshtml"
                            }
                            else if (role == "Field4")
                            {
                                j++;

#line default
#line hidden
                BeginContext(6057, 128, true);
                WriteLiteral("                                <span style=\"color:black;padding:3px;border-radius:2px;border:2px solid orange\">Field 4</span>\r\n");
                EndContext();
#line 129 "C:\Users\djree\source\repos\RobofestOSS\RobofestOSSWeb\RobofestWTECore\Views\Team\ManageUsers.cshtml"
                            }
                            else if (role == "Field5")
                            {
                                j++;

#line default
#line hidden
                BeginContext(6341, 130, true);
                WriteLiteral("                                <span style=\"color:black;padding:3px;border-radius:2px;border:2px solid deeppink\">Field 5</span>\r\n");
                EndContext();
#line 134 "C:\Users\djree\source\repos\RobofestOSS\RobofestOSSWeb\RobofestWTECore\Views\Team\ManageUsers.cshtml"
                            }
                            else if (role == "Field6")
                            {
                                j++;

#line default
#line hidden
                BeginContext(6627, 127, true);
                WriteLiteral("                                <span style=\"color:black;padding:3px;border-radius:2px;border:2px solid black\">Field 6</span>\r\n");
                EndContext();
#line 139 "C:\Users\djree\source\repos\RobofestOSS\RobofestOSSWeb\RobofestWTECore\Views\Team\ManageUsers.cshtml"
                            }
                            else if (role == "AllFields")
                            {
                                j++;

#line default
#line hidden
                BeginContext(6913, 142, true);
                WriteLiteral("                                <span style=\"color:black;padding:3px;border-radius:2px;background-color:mediumspringgreen\">All Fields</span>\r\n");
                EndContext();
#line 144 "C:\Users\djree\source\repos\RobofestOSS\RobofestOSSWeb\RobofestWTECore\Views\Team\ManageUsers.cshtml"
                            }


                        }

#line default
#line hidden
                BeginContext(7117, 24, true);
                WriteLiteral("                        ");
                EndContext();
#line 148 "C:\Users\djree\source\repos\RobofestOSS\RobofestOSSWeb\RobofestWTECore\Views\Team\ManageUsers.cshtml"
                         if (j == 0)
                        {

#line default
#line hidden
                BeginContext(7182, 138, true);
                WriteLiteral("                            <span style=\"background-color:lightgray;color:black;padding:3px;border-radius:2px\">No Assigned Fields</span>\r\n");
                EndContext();
#line 151 "C:\Users\djree\source\repos\RobofestOSS\RobofestOSSWeb\RobofestWTECore\Views\Team\ManageUsers.cshtml"
                        }

#line default
#line hidden
                BeginContext(7347, 114, true);
                WriteLiteral("                    </td>\r\n                    <td>\r\n                        <button type=\"button\" class=\"field1a\"");
                EndContext();
                BeginWriteAttribute("id", " id=\"", 7461, "\"", 7478, 1);
#line 154 "C:\Users\djree\source\repos\RobofestOSS\RobofestOSSWeb\RobofestWTECore\Views\Team\ManageUsers.cshtml"
WriteAttributeValue("", 7466, user.UserID, 7466, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 7479, "\"", 7501, 1);
#line 154 "C:\Users\djree\source\repos\RobofestOSS\RobofestOSSWeb\RobofestWTECore\Views\Team\ManageUsers.cshtml"
WriteAttributeValue("", 7487, user.UserName, 7487, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(7502, 80, true);
                WriteLiteral(">Field 1</button>\r\n                        <button type=\"button\" class=\"field2a\"");
                EndContext();
                BeginWriteAttribute("id", " id=\"", 7582, "\"", 7599, 1);
#line 155 "C:\Users\djree\source\repos\RobofestOSS\RobofestOSSWeb\RobofestWTECore\Views\Team\ManageUsers.cshtml"
WriteAttributeValue("", 7587, user.UserID, 7587, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 7600, "\"", 7622, 1);
#line 155 "C:\Users\djree\source\repos\RobofestOSS\RobofestOSSWeb\RobofestWTECore\Views\Team\ManageUsers.cshtml"
WriteAttributeValue("", 7608, user.UserName, 7608, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(7623, 80, true);
                WriteLiteral(">Field 2</button>\r\n                        <button type=\"button\" class=\"field3a\"");
                EndContext();
                BeginWriteAttribute("id", " id=\"", 7703, "\"", 7720, 1);
#line 156 "C:\Users\djree\source\repos\RobofestOSS\RobofestOSSWeb\RobofestWTECore\Views\Team\ManageUsers.cshtml"
WriteAttributeValue("", 7708, user.UserID, 7708, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 7721, "\"", 7743, 1);
#line 156 "C:\Users\djree\source\repos\RobofestOSS\RobofestOSSWeb\RobofestWTECore\Views\Team\ManageUsers.cshtml"
WriteAttributeValue("", 7729, user.UserName, 7729, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(7744, 80, true);
                WriteLiteral(">Field 3</button>\r\n                        <button type=\"button\" class=\"field4a\"");
                EndContext();
                BeginWriteAttribute("id", " id=\"", 7824, "\"", 7841, 1);
#line 157 "C:\Users\djree\source\repos\RobofestOSS\RobofestOSSWeb\RobofestWTECore\Views\Team\ManageUsers.cshtml"
WriteAttributeValue("", 7829, user.UserID, 7829, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 7842, "\"", 7864, 1);
#line 157 "C:\Users\djree\source\repos\RobofestOSS\RobofestOSSWeb\RobofestWTECore\Views\Team\ManageUsers.cshtml"
WriteAttributeValue("", 7850, user.UserName, 7850, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(7865, 80, true);
                WriteLiteral(">Field 4</button>\r\n                        <button type=\"button\" class=\"field5a\"");
                EndContext();
                BeginWriteAttribute("id", " id=\"", 7945, "\"", 7962, 1);
#line 158 "C:\Users\djree\source\repos\RobofestOSS\RobofestOSSWeb\RobofestWTECore\Views\Team\ManageUsers.cshtml"
WriteAttributeValue("", 7950, user.UserID, 7950, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 7963, "\"", 7985, 1);
#line 158 "C:\Users\djree\source\repos\RobofestOSS\RobofestOSSWeb\RobofestWTECore\Views\Team\ManageUsers.cshtml"
WriteAttributeValue("", 7971, user.UserName, 7971, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(7986, 80, true);
                WriteLiteral(">Field 5</button>\r\n                        <button type=\"button\" class=\"field6a\"");
                EndContext();
                BeginWriteAttribute("id", " id=\"", 8066, "\"", 8083, 1);
#line 159 "C:\Users\djree\source\repos\RobofestOSS\RobofestOSSWeb\RobofestWTECore\Views\Team\ManageUsers.cshtml"
WriteAttributeValue("", 8071, user.UserID, 8071, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 8084, "\"", 8106, 1);
#line 159 "C:\Users\djree\source\repos\RobofestOSS\RobofestOSSWeb\RobofestWTECore\Views\Team\ManageUsers.cshtml"
WriteAttributeValue("", 8092, user.UserName, 8092, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(8107, 123, true);
                WriteLiteral(">Field 6</button>\r\n                        <button type=\"button\" class=\"fieldaa\" style=\"background-color:mediumspringgreen\"");
                EndContext();
                BeginWriteAttribute("id", " id=\"", 8230, "\"", 8247, 1);
#line 160 "C:\Users\djree\source\repos\RobofestOSS\RobofestOSSWeb\RobofestWTECore\Views\Team\ManageUsers.cshtml"
WriteAttributeValue("", 8235, user.UserID, 8235, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 8248, "\"", 8270, 1);
#line 160 "C:\Users\djree\source\repos\RobofestOSS\RobofestOSSWeb\RobofestWTECore\Views\Team\ManageUsers.cshtml"
WriteAttributeValue("", 8256, user.UserName, 8256, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(8271, 72, true);
                WriteLiteral(">All Fields</button>\r\n                    </td>\r\n                </tr>\r\n");
                EndContext();
#line 163 "C:\Users\djree\source\repos\RobofestOSS\RobofestOSSWeb\RobofestWTECore\Views\Team\ManageUsers.cshtml"
            }

#line default
#line hidden
                BeginContext(8358, 26, true);
                WriteLiteral("\r\n        </table>\r\n\r\n    ");
                EndContext();
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
            EndContext();
            BeginContext(8391, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(8393, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4b3a28ac753c4174bc17ecdb3957839a", async() => {
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
            BeginContext(8454, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(8456, 51, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bcd60170707d4eaeb02aac6f2434d0dc", async() => {
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
            BeginContext(8507, 2883, true);
            WriteLiteral(@"
<script>
    $(function () {
        // Reference the auto-generated proxy for the hub.
        var chat = new signalR.HubConnectionBuilder().withUrl(""/scoreHub"").build();
        var compid = 1;
        chat.on(""reloadUsers"", function (field, helping) {
            location.reload(true);
        });
        chat.start().then(function () {
            $("".judge"").click(function () {
                var username = $(this).val();
                chat.invoke(""updateUserRoleAsync"", username, ""Judge"", compid);
            });
            $("".manager"").click(function () {
                var username = $(this).val();
                chat.invoke(""updateUserRoleAsync"", username, ""Manager"", compid);
            });
            $("".fieldstaff"").click(function () {
                var username = $(this).val();
                chat.invoke(""updateUserRoleAsync"", username, ""FieldStaff"", compid);
            });
            $("".admin"").click(function () {
                var username = $(this).val();");
            WriteLiteral(@"
                chat.invoke(""updateUserRoleAsync"", username, ""Admin"", compid);
            });
            $("".tech"").click(function () {
                var username = $(this).val();
                chat.invoke(""updateUserRoleAsync"", username, ""Tech"", compid);
            });
            $("".banned"").click(function () {
                var username = $(this).val();
                chat.invoke(""updateUserRoleAsync"", username, ""Locked"", compid);
            });
            $("".field1a"").click(function () {
                var username = $(this).val();
                chat.invoke(""updateUserRoleAsync"", username, ""Field1"", compid);
            });
            $("".field2a"").click(function () {
                var username = $(this).val();
                chat.invoke(""updateUserRoleAsync"", username, ""Field2"", compid);
            });
            $("".field3a"").click(function () {
                var username = $(this).val();
                chat.invoke(""updateUserRoleAsync"", username, ""Field3""");
            WriteLiteral(@", compid);
            });
            $("".field4a"").click(function () {
                var username = $(this).val();
                chat.invoke(""updateUserRoleAsync"", username, ""Field4"", compid);
            });
            $("".field5a"").click(function () {
                var username = $(this).val();
                chat.invoke(""updateUserRoleAsync"", username, ""Field5"", compid);
            });
            $("".field6a"").click(function () {
                var username = $(this).val();
                chat.invoke(""updateUserRoleAsync"", username, ""Field6"", compid);
            });
            $("".fieldaa"").click(function () {
                var username = $(this).val();
                chat.invoke(""updateUserRoleAsync"", username, ""AllFields"", compid);
            });

        });
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<RobofestWTE.Models.UserListModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
