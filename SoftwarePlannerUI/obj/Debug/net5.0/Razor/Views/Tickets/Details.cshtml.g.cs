#pragma checksum "C:\Users\lynda\source\repos\SoftwarePlanner\SoftwarePlannerUI\Views\Tickets\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "78cd156df088bdf20f3b7dfc1e0756f637eb8627"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tickets_Details), @"mvc.1.0.view", @"/Views/Tickets/Details.cshtml")]
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
#line 1 "C:\Users\lynda\source\repos\SoftwarePlanner\SoftwarePlannerUI\Views\_ViewImports.cshtml"
using SoftwarePlannerUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\lynda\source\repos\SoftwarePlanner\SoftwarePlannerUI\Views\_ViewImports.cshtml"
using SoftwarePlannerLibrary.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"78cd156df088bdf20f3b7dfc1e0756f637eb8627", @"/Views/Tickets/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fa1fb8399b3bf367e73b2b88fcf7682bd9d1c046", @"/Views/_ViewImports.cshtml")]
    public class Views_Tickets_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SoftwarePlannerLibrary.Models.TicketModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\lynda\source\repos\SoftwarePlanner\SoftwarePlannerUI\Views\Tickets\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>TicketModel</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 14 "C:\Users\lynda\source\repos\SoftwarePlanner\SoftwarePlannerUI\Views\Tickets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TicketName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 17 "C:\Users\lynda\source\repos\SoftwarePlanner\SoftwarePlannerUI\Views\Tickets\Details.cshtml"
       Write(Html.DisplayFor(model => model.TicketName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 20 "C:\Users\lynda\source\repos\SoftwarePlanner\SoftwarePlannerUI\Views\Tickets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TicketDescription));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 23 "C:\Users\lynda\source\repos\SoftwarePlanner\SoftwarePlannerUI\Views\Tickets\Details.cshtml"
       Write(Html.DisplayFor(model => model.TicketDescription));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 26 "C:\Users\lynda\source\repos\SoftwarePlanner\SoftwarePlannerUI\Views\Tickets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DateCreated));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 29 "C:\Users\lynda\source\repos\SoftwarePlanner\SoftwarePlannerUI\Views\Tickets\Details.cshtml"
       Write(Html.DisplayFor(model => model.DateCreated));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 32 "C:\Users\lynda\source\repos\SoftwarePlanner\SoftwarePlannerUI\Views\Tickets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DueDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 35 "C:\Users\lynda\source\repos\SoftwarePlanner\SoftwarePlannerUI\Views\Tickets\Details.cshtml"
       Write(Html.DisplayFor(model => model.DueDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 38 "C:\Users\lynda\source\repos\SoftwarePlanner\SoftwarePlannerUI\Views\Tickets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ClosedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 41 "C:\Users\lynda\source\repos\SoftwarePlanner\SoftwarePlannerUI\Views\Tickets\Details.cshtml"
       Write(Html.DisplayFor(model => model.ClosedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 44 "C:\Users\lynda\source\repos\SoftwarePlanner\SoftwarePlannerUI\Views\Tickets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Archived));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 47 "C:\Users\lynda\source\repos\SoftwarePlanner\SoftwarePlannerUI\Views\Tickets\Details.cshtml"
       Write(Html.DisplayFor(model => model.Archived));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 50 "C:\Users\lynda\source\repos\SoftwarePlanner\SoftwarePlannerUI\Views\Tickets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.AssignedUserlId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 53 "C:\Users\lynda\source\repos\SoftwarePlanner\SoftwarePlannerUI\Views\Tickets\Details.cshtml"
       Write(Html.DisplayFor(model => model.AssignedUserlId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 56 "C:\Users\lynda\source\repos\SoftwarePlanner\SoftwarePlannerUI\Views\Tickets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CreatorModel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 59 "C:\Users\lynda\source\repos\SoftwarePlanner\SoftwarePlannerUI\Views\Tickets\Details.cshtml"
       Write(Html.DisplayFor(model => model.CreatorModel.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 62 "C:\Users\lynda\source\repos\SoftwarePlanner\SoftwarePlannerUI\Views\Tickets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ProjectModel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 65 "C:\Users\lynda\source\repos\SoftwarePlanner\SoftwarePlannerUI\Views\Tickets\Details.cshtml"
       Write(Html.DisplayFor(model => model.ProjectModel.AssignedUserlId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 68 "C:\Users\lynda\source\repos\SoftwarePlanner\SoftwarePlannerUI\Views\Tickets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TaskModel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 71 "C:\Users\lynda\source\repos\SoftwarePlanner\SoftwarePlannerUI\Views\Tickets\Details.cshtml"
       Write(Html.DisplayFor(model => model.TaskModel.AssignedUserlId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 74 "C:\Users\lynda\source\repos\SoftwarePlanner\SoftwarePlannerUI\Views\Tickets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TypeModel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 77 "C:\Users\lynda\source\repos\SoftwarePlanner\SoftwarePlannerUI\Views\Tickets\Details.cshtml"
       Write(Html.DisplayFor(model => model.TypeModel.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 80 "C:\Users\lynda\source\repos\SoftwarePlanner\SoftwarePlannerUI\Views\Tickets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PriorityModel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 83 "C:\Users\lynda\source\repos\SoftwarePlanner\SoftwarePlannerUI\Views\Tickets\Details.cshtml"
       Write(Html.DisplayFor(model => model.PriorityModel.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 86 "C:\Users\lynda\source\repos\SoftwarePlanner\SoftwarePlannerUI\Views\Tickets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.StatusModel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 89 "C:\Users\lynda\source\repos\SoftwarePlanner\SoftwarePlannerUI\Views\Tickets\Details.cshtml"
       Write(Html.DisplayFor(model => model.StatusModel.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 92 "C:\Users\lynda\source\repos\SoftwarePlanner\SoftwarePlannerUI\Views\Tickets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TeamModel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 95 "C:\Users\lynda\source\repos\SoftwarePlanner\SoftwarePlannerUI\Views\Tickets\Details.cshtml"
       Write(Html.DisplayFor(model => model.TeamModel.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "78cd156df088bdf20f3b7dfc1e0756f637eb862713584", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 100 "C:\Users\lynda\source\repos\SoftwarePlanner\SoftwarePlannerUI\Views\Tickets\Details.cshtml"
                           WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "78cd156df088bdf20f3b7dfc1e0756f637eb862715739", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SoftwarePlannerLibrary.Models.TicketModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
