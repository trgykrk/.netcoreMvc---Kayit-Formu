#pragma checksum "C:\Users\Turgay\source\repos\CoreMvcTask\CoreMvcTask\Views\yonetici\TalepListesi.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "961a07eae38c847c2880feb0cd8c63a58c4ff4bd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_yonetici_TalepListesi), @"mvc.1.0.view", @"/Views/yonetici/TalepListesi.cshtml")]
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
#line 1 "C:\Users\Turgay\source\repos\CoreMvcTask\CoreMvcTask\Views\_ViewImports.cshtml"
using CoreMvcTask;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Turgay\source\repos\CoreMvcTask\CoreMvcTask\Views\yonetici\TalepListesi.cshtml"
using CoreMvcTask.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"961a07eae38c847c2880feb0cd8c63a58c4ff4bd", @"/Views/yonetici/TalepListesi.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1fa89e9d5fd13e32c5ebbdaab22a5915dc9f22af", @"/Views/_ViewImports.cshtml")]
    public class Views_yonetici_TalepListesi : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Musteriler>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("rounded-circle"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("80"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("40"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\Turgay\source\repos\CoreMvcTask\CoreMvcTask\Views\yonetici\TalepListesi.cshtml"
  
    ViewData["Title"] = "TalepListesi";
    Layout = "~/Views/Shared/_YoneticiLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<br />
<table class=""table table-bordered"">
    <tr>
        <th>Talep ID</th>
        <th>Adı</th>
        <th>Soyadı</th>
        <th>iletisim</th>
        <th>E-Posta Adresi</th>
        <th>İstenilen Hizmet</th>
        <th>Domain Süresi</th>
        <th>Domain Adı</th>
        <th>Uzantı</th>
        <th>Açıklama</th>
        <th>Firma Logo</th>
    </tr>
");
#nullable restore
#line 24 "C:\Users\Turgay\source\repos\CoreMvcTask\CoreMvcTask\Views\yonetici\TalepListesi.cshtml"
     foreach (var x in Model)
    {
        if (x.Firma_Logo == null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("     <tr>\r\n         <td>");
#nullable restore
#line 29 "C:\Users\Turgay\source\repos\CoreMvcTask\CoreMvcTask\Views\yonetici\TalepListesi.cshtml"
        Write(x.Musterı_ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n         <td>");
#nullable restore
#line 30 "C:\Users\Turgay\source\repos\CoreMvcTask\CoreMvcTask\Views\yonetici\TalepListesi.cshtml"
        Write(x.Adi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n         <td>");
#nullable restore
#line 31 "C:\Users\Turgay\source\repos\CoreMvcTask\CoreMvcTask\Views\yonetici\TalepListesi.cshtml"
        Write(x.Soyadi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n         <td>");
#nullable restore
#line 32 "C:\Users\Turgay\source\repos\CoreMvcTask\CoreMvcTask\Views\yonetici\TalepListesi.cshtml"
        Write(x.iletisim);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n         <td>");
#nullable restore
#line 33 "C:\Users\Turgay\source\repos\CoreMvcTask\CoreMvcTask\Views\yonetici\TalepListesi.cshtml"
        Write(x.eposta);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n         <td>");
#nullable restore
#line 34 "C:\Users\Turgay\source\repos\CoreMvcTask\CoreMvcTask\Views\yonetici\TalepListesi.cshtml"
        Write(x.Urun_Adi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n         <td>");
#nullable restore
#line 35 "C:\Users\Turgay\source\repos\CoreMvcTask\CoreMvcTask\Views\yonetici\TalepListesi.cshtml"
        Write(x.Domain_Sure);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n         <td>");
#nullable restore
#line 36 "C:\Users\Turgay\source\repos\CoreMvcTask\CoreMvcTask\Views\yonetici\TalepListesi.cshtml"
        Write(x.Domain_Adi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n         <td>");
#nullable restore
#line 37 "C:\Users\Turgay\source\repos\CoreMvcTask\CoreMvcTask\Views\yonetici\TalepListesi.cshtml"
        Write(x.Uzanti_Adi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n         <td>");
#nullable restore
#line 38 "C:\Users\Turgay\source\repos\CoreMvcTask\CoreMvcTask\Views\yonetici\TalepListesi.cshtml"
        Write(x.Aciklama);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n         <td>Logo Eklenmedi..</td>\r\n     </tr>\r\n");
#nullable restore
#line 41 "C:\Users\Turgay\source\repos\CoreMvcTask\CoreMvcTask\Views\yonetici\TalepListesi.cshtml"
        }
        else { 

#line default
#line hidden
#nullable disable
            WriteLiteral("     <tr>\r\n     \r\n         <td>");
#nullable restore
#line 45 "C:\Users\Turgay\source\repos\CoreMvcTask\CoreMvcTask\Views\yonetici\TalepListesi.cshtml"
        Write(x.Musterı_ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n         <td>");
#nullable restore
#line 46 "C:\Users\Turgay\source\repos\CoreMvcTask\CoreMvcTask\Views\yonetici\TalepListesi.cshtml"
        Write(x.Adi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n         <td>");
#nullable restore
#line 47 "C:\Users\Turgay\source\repos\CoreMvcTask\CoreMvcTask\Views\yonetici\TalepListesi.cshtml"
        Write(x.Soyadi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n         <td>");
#nullable restore
#line 48 "C:\Users\Turgay\source\repos\CoreMvcTask\CoreMvcTask\Views\yonetici\TalepListesi.cshtml"
        Write(x.iletisim);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n         <td>");
#nullable restore
#line 49 "C:\Users\Turgay\source\repos\CoreMvcTask\CoreMvcTask\Views\yonetici\TalepListesi.cshtml"
        Write(x.eposta);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n         <td>");
#nullable restore
#line 50 "C:\Users\Turgay\source\repos\CoreMvcTask\CoreMvcTask\Views\yonetici\TalepListesi.cshtml"
        Write(x.Urun_Adi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n         <td>");
#nullable restore
#line 51 "C:\Users\Turgay\source\repos\CoreMvcTask\CoreMvcTask\Views\yonetici\TalepListesi.cshtml"
        Write(x.Domain_Sure);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n         <td>");
#nullable restore
#line 52 "C:\Users\Turgay\source\repos\CoreMvcTask\CoreMvcTask\Views\yonetici\TalepListesi.cshtml"
        Write(x.Domain_Adi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n         <td>");
#nullable restore
#line 53 "C:\Users\Turgay\source\repos\CoreMvcTask\CoreMvcTask\Views\yonetici\TalepListesi.cshtml"
        Write(x.Uzanti_Adi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n         <td>");
#nullable restore
#line 54 "C:\Users\Turgay\source\repos\CoreMvcTask\CoreMvcTask\Views\yonetici\TalepListesi.cshtml"
        Write(x.Aciklama);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n         <td>\r\n             ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "961a07eae38c847c2880feb0cd8c63a58c4ff4bd10509", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1384, "~/Logolar/", 1384, 10, true);
#nullable restore
#line 56 "C:\Users\Turgay\source\repos\CoreMvcTask\CoreMvcTask\Views\yonetici\TalepListesi.cshtml"
AddHtmlAttributeValue("", 1394, x.Firma_Logo, 1394, 13, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n         </td>\r\n     </tr>\r\n");
#nullable restore
#line 59 "C:\Users\Turgay\source\repos\CoreMvcTask\CoreMvcTask\Views\yonetici\TalepListesi.cshtml"
        }
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Musteriler>> Html { get; private set; }
    }
}
#pragma warning restore 1591
