#pragma checksum "F:\Education\c#\ASP.Net\EmployeeOrders\EmployeeOrders.Web\Views\User\Orders.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "32ad1268cbcbbd6d58b00abefccb95e5a1338c4a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Orders), @"mvc.1.0.view", @"/Views/User/Orders.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/User/Orders.cshtml", typeof(AspNetCore.Views_User_Orders))]
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
#line 1 "F:\Education\c#\ASP.Net\EmployeeOrders\EmployeeOrders.Web\Views\_ViewImports.cshtml"
using EmployeeOrders.Web;

#line default
#line hidden
#line 2 "F:\Education\c#\ASP.Net\EmployeeOrders\EmployeeOrders.Web\Views\_ViewImports.cshtml"
using EmployeeOrders.Web.Models;

#line default
#line hidden
#line 1 "F:\Education\c#\ASP.Net\EmployeeOrders\EmployeeOrders.Web\Views\User\Orders.cshtml"
using EmployeeOrders.Web.Models.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"32ad1268cbcbbd6d58b00abefccb95e5a1338c4a", @"/Views/User/Orders.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1abc0a5b1ff84842bf39a3379600870028c563c6", @"/Views/_ViewImports.cshtml")]
    public class Views_User_Orders : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<UserOrders>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Orders", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-sort", "true", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-sort", "false", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(45, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(79, 220, true);
            WriteLiteral("\r\n<div class=\"container\" style=\"margin-top:60px;margin-bottom:60px; \">\r\n\t<div class=\"card border\">\r\n\t\t<div class=\"card-header\">\r\n\t\t\t<h2><strong>User orders</strong></h2>\r\n\t\t\t<div class=\"right\">\r\n\t\t\t\t<p>\r\n\t\t\t\t\tShow\r\n\t\t\t\t\t");
            EndContext();
            BeginContext(299, 69, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "32ad1268cbcbbd6d58b00abefccb95e5a1338c4a4665", async() => {
                BeginContext(342, 22, true);
                WriteLiteral("\r\n\t\t\t\t\t\tToday\'s\r\n\t\t\t\t\t");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-sort", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sort"] = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(368, 10, true);
            WriteLiteral(" or\r\n\t\t\t\t\t");
            EndContext();
            BeginContext(378, 66, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "32ad1268cbcbbd6d58b00abefccb95e5a1338c4a6595", async() => {
                BeginContext(422, 18, true);
                WriteLiteral("\r\n\t\t\t\t\t\tAll\r\n\t\t\t\t\t");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-sort", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sort"] = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(444, 731, true);
            WriteLiteral(@"
				</p>
			</div>
		</div>
		<div class=""accordion"" id=""view"">
			<div class=""card"">
				<div class=""card-header"" id=""headingOne"">
					<h2 class=""mb-0"">
						<button class=""btn btn-link collapsed"" type=""button"" data-toggle=""collapse"" data-target=""#collapseOne"" aria-expanded=""true"" aria-controls=""collapseOne"">
							Full list of orders
						</button>
					</h2>
				</div>
			</div>
			<div id=""collapseOne"" class=""collapse"" aria-labelledby=""headingOne"" data-parent=""#view"">
				<div class=""card-body"">
					<table class=""table table-bordered table-striped"">
						<tr>
							<th>User Name</th>
							<th>Drink</th>
							<th>Food</th>
							<th>Total Price</th>
							<th>Date</th>
						</tr>
");
            EndContext();
#line 41 "F:\Education\c#\ASP.Net\EmployeeOrders\EmployeeOrders.Web\Views\User\Orders.cshtml"
                         foreach (var item in @Model)
						{

#line default
#line hidden
            BeginContext(1221, 25, true);
            WriteLiteral("\t\t\t\t\t\t\t<tr>\r\n\t\t\t\t\t\t\t\t<th>");
            EndContext();
            BeginContext(1247, 14, false);
#line 44 "F:\Education\c#\ASP.Net\EmployeeOrders\EmployeeOrders.Web\Views\User\Orders.cshtml"
                               Write(item.User.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1261, 19, true);
            WriteLiteral("</th>\r\n\t\t\t\t\t\t\t\t<th>");
            EndContext();
            BeginContext(1281, 21, false);
#line 45 "F:\Education\c#\ASP.Net\EmployeeOrders\EmployeeOrders.Web\Views\User\Orders.cshtml"
                               Write(item.Order.Drink.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1302, 19, true);
            WriteLiteral("</th>\r\n\t\t\t\t\t\t\t\t<th>");
            EndContext();
            BeginContext(1322, 20, false);
#line 46 "F:\Education\c#\ASP.Net\EmployeeOrders\EmployeeOrders.Web\Views\User\Orders.cshtml"
                               Write(item.Order.Food.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1342, 19, true);
            WriteLiteral("</th>\r\n\t\t\t\t\t\t\t\t<th>");
            EndContext();
            BeginContext(1362, 33, false);
#line 47 "F:\Education\c#\ASP.Net\EmployeeOrders\EmployeeOrders.Web\Views\User\Orders.cshtml"
                               Write(item.Order.Total.ToString("0.##"));

#line default
#line hidden
            EndContext();
            BeginContext(1395, 23, true);
            WriteLiteral(" yan</th>\r\n\t\t\t\t\t\t\t\t<th>");
            EndContext();
            BeginContext(1419, 9, false);
#line 48 "F:\Education\c#\ASP.Net\EmployeeOrders\EmployeeOrders.Web\Views\User\Orders.cshtml"
                               Write(item.Date);

#line default
#line hidden
            EndContext();
            BeginContext(1428, 21, true);
            WriteLiteral("</th>\r\n\t\t\t\t\t\t\t</tr>\r\n");
            EndContext();
#line 50 "F:\Education\c#\ASP.Net\EmployeeOrders\EmployeeOrders.Web\Views\User\Orders.cshtml"
						}

#line default
#line hidden
            BeginContext(1458, 44, true);
            WriteLiteral("\t\t\t\t\t</table>\r\n\t\t\t\t\t<p>Total price: <strong>");
            EndContext();
            BeginContext(1503, 35, false);
#line 52 "F:\Education\c#\ASP.Net\EmployeeOrders\EmployeeOrders.Web\Views\User\Orders.cshtml"
                                       Write(ViewBag.totalPrice.ToString("0.##"));

#line default
#line hidden
            EndContext();
            BeginContext(1538, 684, true);
            WriteLiteral(@" yan</strong></p>
				</div>
			</div>
		</div>
		<div class=""card"">
			<div class=""card-header"" id=""headingTwo"">
				<h2 class=""mb-0"">
					<button class=""btn btn-link collapsed"" type=""button"" data-toggle=""collapse"" data-target=""#collapseTwo"" aria-expanded=""false"" aria-controls=""collapseTwo"">
						Short list of orders
					</button>
				</h2>
			</div>
			<div id=""collapseTwo"" class=""collapse"" aria-labelledby=""headingTwo"" data-parent=""#view"">
				<div class=""card-body"">
					<div class=""row"">
						<div class=""col sm-4"">
							<table class=""table table-bordered table-striped"">
								<tr>
									<th>Food</th>
									<th>Count</th>
								</tr>

");
            EndContext();
#line 74 "F:\Education\c#\ASP.Net\EmployeeOrders\EmployeeOrders.Web\Views\User\Orders.cshtml"
                                 foreach (var item in @ViewBag.totalFood)
								{

#line default
#line hidden
            BeginContext(2284, 29, true);
            WriteLiteral("\t\t\t\t\t\t\t\t\t<tr>\r\n\t\t\t\t\t\t\t\t\t\t<th>");
            EndContext();
            BeginContext(2314, 9, false);
#line 77 "F:\Education\c#\ASP.Net\EmployeeOrders\EmployeeOrders.Web\Views\User\Orders.cshtml"
                                       Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(2323, 21, true);
            WriteLiteral("</th>\r\n\t\t\t\t\t\t\t\t\t\t<th>");
            EndContext();
            BeginContext(2345, 10, false);
#line 78 "F:\Education\c#\ASP.Net\EmployeeOrders\EmployeeOrders.Web\Views\User\Orders.cshtml"
                                       Write(item.Count);

#line default
#line hidden
            EndContext();
            BeginContext(2355, 23, true);
            WriteLiteral("</th>\r\n\t\t\t\t\t\t\t\t\t</tr>\r\n");
            EndContext();
#line 80 "F:\Education\c#\ASP.Net\EmployeeOrders\EmployeeOrders.Web\Views\User\Orders.cshtml"
								}

#line default
#line hidden
            BeginContext(2389, 201, true);
            WriteLiteral("\t\t\t\t\t\t\t</table>\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t<div class=\"col sm-4\">\r\n\t\t\t\t\t\t\t<table class=\"table table-bordered table-striped\">\r\n\t\t\t\t\t\t\t\t<tr>\r\n\t\t\t\t\t\t\t\t\t<th>Drink</th>\r\n\t\t\t\t\t\t\t\t\t<th>Count</th>\r\n\t\t\t\t\t\t\t\t</tr>\r\n\r\n");
            EndContext();
#line 90 "F:\Education\c#\ASP.Net\EmployeeOrders\EmployeeOrders.Web\Views\User\Orders.cshtml"
                                 foreach (var item in @ViewBag.totalDrinks)
								{

#line default
#line hidden
            BeginContext(2654, 29, true);
            WriteLiteral("\t\t\t\t\t\t\t\t\t<tr>\r\n\t\t\t\t\t\t\t\t\t\t<th>");
            EndContext();
            BeginContext(2684, 9, false);
#line 93 "F:\Education\c#\ASP.Net\EmployeeOrders\EmployeeOrders.Web\Views\User\Orders.cshtml"
                                       Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(2693, 21, true);
            WriteLiteral("</th>\r\n\t\t\t\t\t\t\t\t\t\t<th>");
            EndContext();
            BeginContext(2715, 10, false);
#line 94 "F:\Education\c#\ASP.Net\EmployeeOrders\EmployeeOrders.Web\Views\User\Orders.cshtml"
                                       Write(item.Count);

#line default
#line hidden
            EndContext();
            BeginContext(2725, 23, true);
            WriteLiteral("</th>\r\n\t\t\t\t\t\t\t\t\t</tr>\r\n");
            EndContext();
#line 96 "F:\Education\c#\ASP.Net\EmployeeOrders\EmployeeOrders.Web\Views\User\Orders.cshtml"
								}

#line default
#line hidden
            BeginContext(2759, 73, true);
            WriteLiteral("\t\t\t\t\t\t\t</table>\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\r\n\t\t\t\t\t<p>Total price: <strong>");
            EndContext();
            BeginContext(2833, 35, false);
#line 100 "F:\Education\c#\ASP.Net\EmployeeOrders\EmployeeOrders.Web\Views\User\Orders.cshtml"
                                       Write(ViewBag.totalPrice.ToString("0.##"));

#line default
#line hidden
            EndContext();
            BeginContext(2868, 71, true);
            WriteLiteral(" yan</strong></p>\r\n\t\t\t\t</div>\r\n\t\t\t</div>\r\n\t\t</div>\r\n\t</div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<UserOrders>> Html { get; private set; }
    }
}
#pragma warning restore 1591
