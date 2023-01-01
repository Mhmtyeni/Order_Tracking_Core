#pragma checksum "C:\Users\mehmetyen\Desktop\OrderTrackingCore-3e9036d42109652b7683321a1ca18cac99d0023b\Mvc\Views\Tv\TvTable.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "47cf318a642154d9454c2e84faff3cce66b2e1c4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tv_TvTable), @"mvc.1.0.view", @"/Views/Tv/TvTable.cshtml")]
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
#line 1 "C:\Users\mehmetyen\Desktop\OrderTrackingCore-3e9036d42109652b7683321a1ca18cac99d0023b\Mvc\Views\_ViewImports.cshtml"
using Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mehmetyen\Desktop\OrderTrackingCore-3e9036d42109652b7683321a1ca18cac99d0023b\Mvc\Views\_ViewImports.cshtml"
using Mvc.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\mehmetyen\Desktop\OrderTrackingCore-3e9036d42109652b7683321a1ca18cac99d0023b\Mvc\Views\_ViewImports.cshtml"
using Mvc.Models.Concrete;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\mehmetyen\Desktop\OrderTrackingCore-3e9036d42109652b7683321a1ca18cac99d0023b\Mvc\Views\_ViewImports.cshtml"
using Mvc.Models.Dtos.AppUserDtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\mehmetyen\Desktop\OrderTrackingCore-3e9036d42109652b7683321a1ca18cac99d0023b\Mvc\Views\_ViewImports.cshtml"
using Mvc.Models.Dtos.NavBarDtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\mehmetyen\Desktop\OrderTrackingCore-3e9036d42109652b7683321a1ca18cac99d0023b\Mvc\Views\_ViewImports.cshtml"
using Mvc.Models.Dtos.OrderDtos;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"47cf318a642154d9454c2e84faff3cce66b2e1c4", @"/Views/Tv/TvTable.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"99b087003ae43f7c6901672df9c18610938858cf", @"/Views/_ViewImports.cshtml")]
    public class Views_Tv_TvTable : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Order>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\mehmetyen\Desktop\OrderTrackingCore-3e9036d42109652b7683321a1ca18cac99d0023b\Mvc\Views\Tv\TvTable.cshtml"
  
    ViewBag.Title = "Index";
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
#line 17 "C:\Users\mehmetyen\Desktop\OrderTrackingCore-3e9036d42109652b7683321a1ca18cac99d0023b\Mvc\Views\Tv\TvTable.cshtml"
             if (!User.IsInRole("TV"))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <th class=\"column9\">  <center>ARAÇLAR </center></th>\n");
#nullable restore
#line 20 "C:\Users\mehmetyen\Desktop\OrderTrackingCore-3e9036d42109652b7683321a1ca18cac99d0023b\Mvc\Views\Tv\TvTable.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tr>\n    </thead>\n    <tbody>\n");
#nullable restore
#line 24 "C:\Users\mehmetyen\Desktop\OrderTrackingCore-3e9036d42109652b7683321a1ca18cac99d0023b\Mvc\Views\Tv\TvTable.cshtml"
         foreach (var models in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\n                <td class=\"column1\">  <center>");
#nullable restore
#line 27 "C:\Users\mehmetyen\Desktop\OrderTrackingCore-3e9036d42109652b7683321a1ca18cac99d0023b\Mvc\Views\Tv\TvTable.cshtml"
                                          Write(models.Station.SubLine.AssemblyLine.Name + " " +models.Station.SubLine.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </center></td>\n                <td class=\"column2\">  <center>");
#nullable restore
#line 28 "C:\Users\mehmetyen\Desktop\OrderTrackingCore-3e9036d42109652b7683321a1ca18cac99d0023b\Mvc\Views\Tv\TvTable.cshtml"
                                         Write(models.Station.StationNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("  </center></td>\n                <td class=\"column3\">  <center>");
#nullable restore
#line 29 "C:\Users\mehmetyen\Desktop\OrderTrackingCore-3e9036d42109652b7683321a1ca18cac99d0023b\Mvc\Views\Tv\TvTable.cshtml"
                                         Write(models.MaterialCode);

#line default
#line hidden
#nullable disable
            WriteLiteral("  </center></td>\n                <td class=\"column4\">  <center>");
#nullable restore
#line 30 "C:\Users\mehmetyen\Desktop\OrderTrackingCore-3e9036d42109652b7683321a1ca18cac99d0023b\Mvc\Views\Tv\TvTable.cshtml"
                                         Write(models.MaterialDesc);

#line default
#line hidden
#nullable disable
            WriteLiteral("  </center></td>\n                <td class=\"column5\">  <center>");
#nullable restore
#line 31 "C:\Users\mehmetyen\Desktop\OrderTrackingCore-3e9036d42109652b7683321a1ca18cac99d0023b\Mvc\Views\Tv\TvTable.cshtml"
                                         Write(models.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("  </center></td>\n                <td class=\"column6\">  <center><a style=\"color:blue\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1421, "\"", 1455, 3);
            WriteAttributeValue("", 1431, "orderDetails(", 1431, 13, true);
#nullable restore
#line 32 "C:\Users\mehmetyen\Desktop\OrderTrackingCore-3e9036d42109652b7683321a1ca18cac99d0023b\Mvc\Views\Tv\TvTable.cshtml"
WriteAttributeValue("", 1444, models.Id, 1444, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1454, ")", 1454, 1, true);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 32 "C:\Users\mehmetyen\Desktop\OrderTrackingCore-3e9036d42109652b7683321a1ca18cac99d0023b\Mvc\Views\Tv\TvTable.cshtml"
                                                                                                  Write(models.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>  </center></td>\n                <td class=\"column7\">  <center>");
#nullable restore
#line 33 "C:\Users\mehmetyen\Desktop\OrderTrackingCore-3e9036d42109652b7683321a1ca18cac99d0023b\Mvc\Views\Tv\TvTable.cshtml"
                                         Write(models.OrderDate.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("  </center></td>\n                <td class=\"column8\">  <center>");
#nullable restore
#line 34 "C:\Users\mehmetyen\Desktop\OrderTrackingCore-3e9036d42109652b7683321a1ca18cac99d0023b\Mvc\Views\Tv\TvTable.cshtml"
                                         Write(models.Operation.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 34 "C:\Users\mehmetyen\Desktop\OrderTrackingCore-3e9036d42109652b7683321a1ca18cac99d0023b\Mvc\Views\Tv\TvTable.cshtml"
                                                                     Write(models.Operation.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </center></td>\n");
#nullable restore
#line 35 "C:\Users\mehmetyen\Desktop\OrderTrackingCore-3e9036d42109652b7683321a1ca18cac99d0023b\Mvc\Views\Tv\TvTable.cshtml"
                 if (!User.IsInRole("TV"))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td class=\"column9\">\n                        <center>\n                            <div class=\"row\">\n");
#nullable restore
#line 40 "C:\Users\mehmetyen\Desktop\OrderTrackingCore-3e9036d42109652b7683321a1ca18cac99d0023b\Mvc\Views\Tv\TvTable.cshtml"
                                 if (models.Status.Contains("Bekleniyor"))
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <div class=\"col-md-12\">\n                                        <a class=\"btn btn-warning btn-sm\" style=\"color:white\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2137, "\"", 2168, 3);
            WriteAttributeValue("", 2147, "getIdFunc(", 2147, 10, true);
#nullable restore
#line 43 "C:\Users\mehmetyen\Desktop\OrderTrackingCore-3e9036d42109652b7683321a1ca18cac99d0023b\Mvc\Views\Tv\TvTable.cshtml"
WriteAttributeValue("", 2157, models.Id, 2157, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2167, ")", 2167, 1, true);
            EndWriteAttribute();
            WriteLiteral(" title=\"Sipariş İptal\">\n                                            <i class=\"fas fa-close fa-2x\">\n                                            </i>\n                                        </a>\n                                    </div>\n");
#nullable restore
#line 48 "C:\Users\mehmetyen\Desktop\OrderTrackingCore-3e9036d42109652b7683321a1ca18cac99d0023b\Mvc\Views\Tv\TvTable.cshtml"
                                }
                                else
                                {
                                    if (models.Status.Contains("Yolda"))
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <div class=\"col-md-12\">\n                                            <a class=\"btn btn-success btn-sm\" style=\"color:white\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2782, "\"", 2814, 3);
            WriteAttributeValue("", 2792, "getIdFunc2(", 2792, 11, true);
#nullable restore
#line 54 "C:\Users\mehmetyen\Desktop\OrderTrackingCore-3e9036d42109652b7683321a1ca18cac99d0023b\Mvc\Views\Tv\TvTable.cshtml"
WriteAttributeValue("", 2803, models.Id, 2803, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2813, ")", 2813, 1, true);
            EndWriteAttribute();
            WriteLiteral(" title=\"Sipariş Geldi\">\n                                                <i class=\"fas fa-check fa-2x\">\n                                                </i>\n                                            </a>\n                                        </div>\n");
#nullable restore
#line 59 "C:\Users\mehmetyen\Desktop\OrderTrackingCore-3e9036d42109652b7683321a1ca18cac99d0023b\Mvc\Views\Tv\TvTable.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <div class=\"col-md-6\">\n                                            <a class=\"btn btn-warning btn-sm\" style=\"color:white\" id=\"berat\"");
            BeginWriteAttribute("onclick", " onclick=\"", 3355, "\"", 3386, 3);
            WriteAttributeValue("", 3365, "getIdFunc(", 3365, 10, true);
#nullable restore
#line 63 "C:\Users\mehmetyen\Desktop\OrderTrackingCore-3e9036d42109652b7683321a1ca18cac99d0023b\Mvc\Views\Tv\TvTable.cshtml"
WriteAttributeValue("", 3375, models.Id, 3375, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3385, ")", 3385, 1, true);
            EndWriteAttribute();
            WriteLiteral(@" title=""Sipariş İptal"">
                                                <i class=""fas fa-close fa-2x"">
                                                </i>
                                            </a>
                                        </div>
                                        <div class=""col-md-6"">
                                            <a class=""btn btn-success btn-sm"" style=""color:white""");
            BeginWriteAttribute("onclick", " onclick=\"", 3799, "\"", 3831, 3);
            WriteAttributeValue("", 3809, "getIdFunc2(", 3809, 11, true);
#nullable restore
#line 69 "C:\Users\mehmetyen\Desktop\OrderTrackingCore-3e9036d42109652b7683321a1ca18cac99d0023b\Mvc\Views\Tv\TvTable.cshtml"
WriteAttributeValue("", 3820, models.Id, 3820, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3830, ")", 3830, 1, true);
            EndWriteAttribute();
            WriteLiteral(" title=\"Sipariş Geldi\">\n                                                <i class=\"fas fa-check fa-2x\">\n                                                </i>\n                                            </a>\n                                        </div>\n");
#nullable restore
#line 74 "C:\Users\mehmetyen\Desktop\OrderTrackingCore-3e9036d42109652b7683321a1ca18cac99d0023b\Mvc\Views\Tv\TvTable.cshtml"
                                    }
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </div>\n                        </center>\n                    </td>\n");
#nullable restore
#line 79 "C:\Users\mehmetyen\Desktop\OrderTrackingCore-3e9036d42109652b7683321a1ca18cac99d0023b\Mvc\Views\Tv\TvTable.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tr>\n");
#nullable restore
#line 81 "C:\Users\mehmetyen\Desktop\OrderTrackingCore-3e9036d42109652b7683321a1ca18cac99d0023b\Mvc\Views\Tv\TvTable.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\n</table>\n");
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