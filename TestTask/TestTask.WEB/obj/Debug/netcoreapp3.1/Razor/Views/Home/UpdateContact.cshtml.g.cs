#pragma checksum "C:\Users\User\Desktop\TestTask\TestTask\TestTask\TestTask.WEB\Views\Home\UpdateContact.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "065f551f9a2371cd078e1f3a1fcd05f47bead79e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_UpdateContact), @"mvc.1.0.view", @"/Views/Home/UpdateContact.cshtml")]
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
#line 1 "C:\Users\User\Desktop\TestTask\TestTask\TestTask\TestTask.WEB\Views\_ViewImports.cshtml"
using TestTask.WEB;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Desktop\TestTask\TestTask\TestTask\TestTask.WEB\Views\_ViewImports.cshtml"
using TestTask.WEB.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"065f551f9a2371cd078e1f3a1fcd05f47bead79e", @"/Views/Home/UpdateContact.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"11475d3b813cd0fe4238709e652f07660aed2020", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_UpdateContact : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TestTask.WEB.Models.ContactModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<link href=""https://cdn.jsdelivr.net/npm/bootstrap@5.0.0/dist/css/bootstrap.min.css"" rel=""stylesheet"" integrity=""sha384-wEmeIV1mKuiNpC+IOBjI7aAzPcEZeedi5yW5f2yOq55WWLwNGmvvx4Um1vskeMj0"" crossorigin=""anonymous"">
<script defer src=""https://cdn.jsdelivr.net/npm/bootstrap@5.0.0/dist/js/bootstrap.bundle.min.js"" integrity=""sha384-p34f1UUtsS3wqzfto5wAAmdvj+osOnFyQFpp4Ua3gs/ZVWx6oOypYoCJhGGScy+8"" crossorigin=""anonymous""></script>


<div class=""modal-content"">
    <div class=""modal-header"">
        <button class=""close""");
            BeginWriteAttribute("onclick", " onclick=\"", 567, "\"", 615, 5);
            WriteAttributeValue("", 577, "location.href", 577, 13, true);
            WriteAttributeValue(" ", 590, "=", 591, 2, true);
            WriteAttributeValue(" ", 592, "\'", 593, 2, true);
#nullable restore
#line 9 "C:\Users\User\Desktop\TestTask\TestTask\TestTask\TestTask.WEB\Views\Home\UpdateContact.cshtml"
WriteAttributeValue("", 594, Url.Action("Index"), 594, 20, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 614, "\'", 614, 1, true);
            EndWriteAttribute();
            WriteLiteral(">X</button>\r\n        <h4>Update contact</h4>\r\n    </div>\r\n    <div class=\"modal-body\">\r\n        <dl class=\"dl-horizontal\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "065f551f9a2371cd078e1f3a1fcd05f47bead79e4941", async() => {
                WriteLiteral("\r\n                <h5>For updating all inputs must be filled in</h5>\r\n                <dt>Name:</dt>\r\n                <dd><input class=\"notEmpty\" id=\"Name\" name=\"Name\"");
                BeginWriteAttribute("value", " value=\"", 1009, "\"", 1028, 1);
#nullable restore
#line 17 "C:\Users\User\Desktop\TestTask\TestTask\TestTask\TestTask.WEB\Views\Home\UpdateContact.cshtml"
WriteAttributeValue("", 1017, Model.Name, 1017, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" /></dd>\r\n\r\n                <dt>Mobile phone:</dt>\r\n                <dd><input class=\"notEmpty\" id=\"MobilePhone\" name=\"MobilePhone\"");
                BeginWriteAttribute("value", " value=\"", 1160, "\"", 1186, 1);
#nullable restore
#line 20 "C:\Users\User\Desktop\TestTask\TestTask\TestTask\TestTask.WEB\Views\Home\UpdateContact.cshtml"
WriteAttributeValue("", 1168, Model.MobilePhone, 1168, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" /></dd>\r\n\r\n                <dt>Job title:</dt>\r\n                <dd><input class=\"notEmpty\" id=\"JodTitle\" name=\"JobTitle\"");
                BeginWriteAttribute("value", " value=\"", 1309, "\"", 1332, 1);
#nullable restore
#line 23 "C:\Users\User\Desktop\TestTask\TestTask\TestTask\TestTask.WEB\Views\Home\UpdateContact.cshtml"
WriteAttributeValue("", 1317, Model.JobTitle, 1317, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" /></dd>\r\n\r\n                <dt>Birthday:</dt>\r\n                <dd><input class=\"notEmpty\" id=\"BirthDate\" name=\"BirthDate\"");
                BeginWriteAttribute("value", " value=\"", 1456, "\"", 1480, 1);
#nullable restore
#line 26 "C:\Users\User\Desktop\TestTask\TestTask\TestTask\TestTask.WEB\Views\Home\UpdateContact.cshtml"
WriteAttributeValue("", 1464, Model.BirthDate, 1464, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" /></dd>\r\n\r\n                <button id=\"ConfirmBtn\" class=\"btn btn-primary\" type=\"submit\">Update</button>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
#nullable restore
#line 14 "C:\Users\User\Desktop\TestTask\TestTask\TestTask\TestTask.WEB\Views\Home\UpdateContact.cshtml"
AddHtmlAttributeValue("", 780, Url.Action("UpdateOldContact","Home", new { id = Model.Id}), 780, 60, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        </dl>
    </div>
</div>


<script>

    
    $('.notEmpty').on(""click keyup change blur"", function () {
        if ($('#BirthDate').val().replace(/[_-]/g, '').length < 10 || $('#MobilePhone').val().replace(/[_-]/g, '').length < 17 || $('#Name').val().length < 1 || $('#JodTitle').val().length < 1) { $('#ConfirmBtn').attr('style', ' visibility: hidden;'); } else { $('#ConfirmBtn').attr('style', 'visibility: visible;'); }
    });

    $('#MobilePhone').mask('+375 (99) 999-99-99');
    $('#BirthDate').mask('99/99/9999');
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TestTask.WEB.Models.ContactModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
