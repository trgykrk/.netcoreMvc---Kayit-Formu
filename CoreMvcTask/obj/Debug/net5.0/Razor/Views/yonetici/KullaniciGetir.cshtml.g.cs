#pragma checksum "C:\Users\Turgay\source\repos\CoreMvcTask\CoreMvcTask\Views\yonetici\KullaniciGetir.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3e4a0ceccd902685cc825d69d6c783ade47364f2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_yonetici_KullaniciGetir), @"mvc.1.0.view", @"/Views/yonetici/KullaniciGetir.cshtml")]
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
#line 2 "C:\Users\Turgay\source\repos\CoreMvcTask\CoreMvcTask\Views\_ViewImports.cshtml"
using CoreMvcTask.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e4a0ceccd902685cc825d69d6c783ade47364f2", @"/Views/yonetici/KullaniciGetir.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1fa89e9d5fd13e32c5ebbdaab22a5915dc9f22af", @"/Views/_ViewImports.cshtml")]
    public class Views_yonetici_KullaniciGetir : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CoreMvcTask.Models.Kullanicilar>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "2", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Turgay\source\repos\CoreMvcTask\CoreMvcTask\Views\yonetici\KullaniciGetir.cshtml"
  
    ViewData["Title"] = "KullaniciGetir";
    Layout = "~/Views/Shared/_YoneticiLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\Turgay\source\repos\CoreMvcTask\CoreMvcTask\Views\yonetici\KullaniciGetir.cshtml"
 using (Html.BeginForm("KullaniciGüncelle", "yonetici", FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <b>Kullanıcı ID</b>\r\n");
#nullable restore
#line 10 "C:\Users\Turgay\source\repos\CoreMvcTask\CoreMvcTask\Views\yonetici\KullaniciGetir.cshtml"
Write(Html.TextBoxFor(x => x.Kullanici_ID, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
            WriteLiteral("    <b>Kullanıcı Adı</b>\r\n");
#nullable restore
#line 14 "C:\Users\Turgay\source\repos\CoreMvcTask\CoreMvcTask\Views\yonetici\KullaniciGetir.cshtml"
Write(Html.TextBoxFor(x => x.Kullanici_Adi, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <b>Şifre</b>\r\n");
#nullable restore
#line 17 "C:\Users\Turgay\source\repos\CoreMvcTask\CoreMvcTask\Views\yonetici\KullaniciGetir.cshtml"
Write(Html.TextBoxFor(x => x.Sifre, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
            WriteLiteral("    <b>Yetki Kodu</b>\r\n    <fieldset>\r\n        <select id=\"MovieType\" name=\"Yetki_Kodu\" class=\"zmdi-format-clear-all\">\r\n\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3e4a0ceccd902685cc825d69d6c783ade47364f25446", async() => {
                WriteLiteral("1");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3e4a0ceccd902685cc825d69d6c783ade47364f26616", async() => {
                WriteLiteral("2");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n        </select>\r\n\r\n    </fieldset>\r\n    <br />\r\n");
            WriteLiteral("    <button class=\"btn btn-success\">Bilgileri Güncelle</button>\r\n");
#nullable restore
#line 35 "C:\Users\Turgay\source\repos\CoreMvcTask\CoreMvcTask\Views\yonetici\KullaniciGetir.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CoreMvcTask.Models.Kullanicilar> Html { get; private set; }
    }
}
#pragma warning restore 1591
