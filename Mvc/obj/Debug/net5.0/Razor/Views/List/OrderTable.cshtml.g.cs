#pragma checksum "C:\Users\mehmetyen\Desktop\OrderTrackingCore-Github\Mvc\Views\List\OrderTable.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "93fafca2177c0271f859cca6f98ca5e1ecda669b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_List_OrderTable), @"mvc.1.0.view", @"/Views/List/OrderTable.cshtml")]
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
#line 1 "C:\Users\mehmetyen\Desktop\OrderTrackingCore-Github\Mvc\Views\_ViewImports.cshtml"
using Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mehmetyen\Desktop\OrderTrackingCore-Github\Mvc\Views\_ViewImports.cshtml"
using Mvc.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\mehmetyen\Desktop\OrderTrackingCore-Github\Mvc\Views\_ViewImports.cshtml"
using Mvc.Models.Concrete;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\mehmetyen\Desktop\OrderTrackingCore-Github\Mvc\Views\_ViewImports.cshtml"
using Mvc.Models.Dtos.AppUserDtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\mehmetyen\Desktop\OrderTrackingCore-Github\Mvc\Views\_ViewImports.cshtml"
using Mvc.Models.Dtos.NavBarDtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\mehmetyen\Desktop\OrderTrackingCore-Github\Mvc\Views\_ViewImports.cshtml"
using Mvc.Models.Dtos.OrderDtos;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"93fafca2177c0271f859cca6f98ca5e1ecda669b", @"/Views/List/OrderTable.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"99b087003ae43f7c6901672df9c18610938858cf", @"/Views/_ViewImports.cshtml")]
    public class Views_List_OrderTable : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Order>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/orderTable.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\mehmetyen\Desktop\OrderTrackingCore-Github\Mvc\Views\List\OrderTable.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<table>
    <thead>
        <tr class=""table100-head"">
            <th class=""column1"">  <center>HAT </center></th>
            <th class=""column2"">  <center>İSTASYON </center></th>
            <th class=""column3"">  <center>MLZ KODU </center></th>
            <th class=""column4"">  <center>AÇIKLAMA </center></th>
            <th class=""column5"">  <center>ADET </center></th>
            <th class=""column6"">  <center>DURUM </center></th>
            <th class=""column7"">  <center>SAAT </center></th>
            <th class=""column8"">  <center>İŞLEM </center></th>
");
#nullable restore
#line 16 "C:\Users\mehmetyen\Desktop\OrderTrackingCore-Github\Mvc\Views\List\OrderTable.cshtml"
             if (!User.IsInRole("TV"))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <th class=\"column9\">  <center>ARAÇLAR </center></th>\n");
#nullable restore
#line 19 "C:\Users\mehmetyen\Desktop\OrderTrackingCore-Github\Mvc\Views\List\OrderTable.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tr>\n    </thead>\n    <tbody>\n");
#nullable restore
#line 23 "C:\Users\mehmetyen\Desktop\OrderTrackingCore-Github\Mvc\Views\List\OrderTable.cshtml"
         foreach (var models in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\n                <td class=\"column1\">  <center>");
#nullable restore
#line 26 "C:\Users\mehmetyen\Desktop\OrderTrackingCore-Github\Mvc\Views\List\OrderTable.cshtml"
                                          Write(models.Station.SubLine.AssemblyLine.Name + " " +models.Station.SubLine.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </center></td>\n                <td class=\"column2\">  <center>");
#nullable restore
#line 27 "C:\Users\mehmetyen\Desktop\OrderTrackingCore-Github\Mvc\Views\List\OrderTable.cshtml"
                                         Write(models.Station.StationNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("  </center></td>\n                <td class=\"column3\">  <center>");
#nullable restore
#line 28 "C:\Users\mehmetyen\Desktop\OrderTrackingCore-Github\Mvc\Views\List\OrderTable.cshtml"
                                         Write(models.MaterialCode);

#line default
#line hidden
#nullable disable
            WriteLiteral("  </center></td>\n                <td class=\"column4\">  <center>");
#nullable restore
#line 29 "C:\Users\mehmetyen\Desktop\OrderTrackingCore-Github\Mvc\Views\List\OrderTable.cshtml"
                                         Write(models.MaterialDesc);

#line default
#line hidden
#nullable disable
            WriteLiteral("  </center></td>\n                <td class=\"column5\">  <center>");
#nullable restore
#line 30 "C:\Users\mehmetyen\Desktop\OrderTrackingCore-Github\Mvc\Views\List\OrderTable.cshtml"
                                         Write(models.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("  </center></td>\n                <td class=\"column6\">  <center><a style=\"color:blue\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1392, "\"", 1426, 3);
            WriteAttributeValue("", 1402, "orderDetails(", 1402, 13, true);
#nullable restore
#line 31 "C:\Users\mehmetyen\Desktop\OrderTrackingCore-Github\Mvc\Views\List\OrderTable.cshtml"
WriteAttributeValue("", 1415, models.Id, 1415, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1425, ")", 1425, 1, true);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 31 "C:\Users\mehmetyen\Desktop\OrderTrackingCore-Github\Mvc\Views\List\OrderTable.cshtml"
                                                                                                  Write(models.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>  </center></td>\n                <td class=\"column7\">  <center>");
#nullable restore
#line 32 "C:\Users\mehmetyen\Desktop\OrderTrackingCore-Github\Mvc\Views\List\OrderTable.cshtml"
                                         Write(models.OrderDate.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("  </center></td>\n                <td class=\"column8\">  <center>");
#nullable restore
#line 33 "C:\Users\mehmetyen\Desktop\OrderTrackingCore-Github\Mvc\Views\List\OrderTable.cshtml"
                                         Write(models.Operation.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 33 "C:\Users\mehmetyen\Desktop\OrderTrackingCore-Github\Mvc\Views\List\OrderTable.cshtml"
                                                                     Write(models.Operation.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </center></td>\n");
#nullable restore
#line 34 "C:\Users\mehmetyen\Desktop\OrderTrackingCore-Github\Mvc\Views\List\OrderTable.cshtml"
                 if (!User.IsInRole("TV"))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td class=\"column9\">\n                        <center>\n                            <div class=\"row\">\n");
#nullable restore
#line 39 "C:\Users\mehmetyen\Desktop\OrderTrackingCore-Github\Mvc\Views\List\OrderTable.cshtml"
                                 if (models.Status.Contains("Bekleniyor"))
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <div class=\"col-md-12\">\n                                        <a class=\"btn btn-warning btn-sm\" style=\"color:white\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2108, "\"", 2141, 3);
            WriteAttributeValue("", 2118, "cancelOrder(", 2118, 12, true);
#nullable restore
#line 42 "C:\Users\mehmetyen\Desktop\OrderTrackingCore-Github\Mvc\Views\List\OrderTable.cshtml"
WriteAttributeValue("", 2130, models.Id, 2130, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2140, ")", 2140, 1, true);
            EndWriteAttribute();
            WriteLiteral(" title=\"Sipariş İptal\">\n                                            <i class=\"fa fa-close fa-2x\">\n                                            </i>\n                                        </a>\n                                    </div>\n");
#nullable restore
#line 47 "C:\Users\mehmetyen\Desktop\OrderTrackingCore-Github\Mvc\Views\List\OrderTable.cshtml"
                                }
                                else
                                {
                                    if (models.Status.Contains("Yolda"))
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <div class=\"col-md-12\">\n                                            <a class=\"btn btn-success btn-sm\" style=\"color:white\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2754, "\"", 2789, 3);
            WriteAttributeValue("", 2764, "completeOrder(", 2764, 14, true);
#nullable restore
#line 53 "C:\Users\mehmetyen\Desktop\OrderTrackingCore-Github\Mvc\Views\List\OrderTable.cshtml"
WriteAttributeValue("", 2778, models.Id, 2778, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2788, ")", 2788, 1, true);
            EndWriteAttribute();
            WriteLiteral(" title=\"Sipariş Geldi\">\n                                                <i class=\"fa fa-check fa-2x\">\n                                                </i>\n                                            </a>\n                                        </div>\n");
#nullable restore
#line 58 "C:\Users\mehmetyen\Desktop\OrderTrackingCore-Github\Mvc\Views\List\OrderTable.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <div class=\"col-md-6\">\n                                            <a class=\"btn btn-warning btn-sm\" style=\"color:white\"");
            BeginWriteAttribute("onclick", " onclick=\"", 3318, "\"", 3351, 3);
            WriteAttributeValue("", 3328, "cancelOrder(", 3328, 12, true);
#nullable restore
#line 62 "C:\Users\mehmetyen\Desktop\OrderTrackingCore-Github\Mvc\Views\List\OrderTable.cshtml"
WriteAttributeValue("", 3340, models.Id, 3340, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3350, ")", 3350, 1, true);
            EndWriteAttribute();
            WriteLiteral(@" title=""Sipariş İptal"">
                                                <i class=""fa fa-close fa-2x"">
                                                </i>
                                            </a>
                                        </div>
                                        <div class=""col-md-6"">
                                            <a class=""btn btn-success btn-sm"" style=""color:white""");
            BeginWriteAttribute("onclick", " onclick=\"", 3763, "\"", 3798, 3);
            WriteAttributeValue("", 3773, "completeOrder(", 3773, 14, true);
#nullable restore
#line 68 "C:\Users\mehmetyen\Desktop\OrderTrackingCore-Github\Mvc\Views\List\OrderTable.cshtml"
WriteAttributeValue("", 3787, models.Id, 3787, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3797, ")", 3797, 1, true);
            EndWriteAttribute();
            WriteLiteral(" title=\"Sipariş Geldi\">\n                                                <i class=\"fa fa-check fa-2x\">\n                                                </i>\n                                            </a>\n                                        </div>\n");
#nullable restore
#line 73 "C:\Users\mehmetyen\Desktop\OrderTrackingCore-Github\Mvc\Views\List\OrderTable.cshtml"
                                    }
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </div>\n                        </center>\n                    </td>\n");
#nullable restore
#line 78 "C:\Users\mehmetyen\Desktop\OrderTrackingCore-Github\Mvc\Views\List\OrderTable.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tr>\n");
#nullable restore
#line 80 "C:\Users\mehmetyen\Desktop\OrderTrackingCore-Github\Mvc\Views\List\OrderTable.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\n</table>\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "93fafca2177c0271f859cca6f98ca5e1ecda669b15461", async() => {
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Order>> Html { get; private set; }
    }
}
#pragma warning restore 1591
