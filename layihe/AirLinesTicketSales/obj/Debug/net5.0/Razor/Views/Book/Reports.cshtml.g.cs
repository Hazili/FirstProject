#pragma checksum "C:\Users\Mushvig\source\layihe\AirLinesTicketSales\Views\Book\Reports.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ad9014a04ca118f45a32397eb28ccc8a9bac6cce"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Book_Reports), @"mvc.1.0.view", @"/Views/Book/Reports.cshtml")]
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
#line 1 "C:\Users\Mushvig\source\layihe\AirLinesTicketSales\Views\_ViewImports.cshtml"
using AirLinesTicketSales;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Mushvig\source\layihe\AirLinesTicketSales\Views\_ViewImports.cshtml"
using AirLinesTicketSales.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Mushvig\source\layihe\AirLinesTicketSales\Views\Book\Reports.cshtml"
using DTO.DTOs;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ad9014a04ca118f45a32397eb28ccc8a9bac6cce", @"/Views/Book/Reports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"850502f57a42a0500f5747b40a089191d995392d", @"/Views/_ViewImports.cshtml")]
    public class Views_Book_Reports : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<PassengerToGetDTO>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Mushvig\source\layihe\AirLinesTicketSales\Views\Book\Reports.cshtml"
  
    Layout = "_TestLayout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 8 "C:\Users\Mushvig\source\layihe\AirLinesTicketSales\Views\Book\Reports.cshtml"
  
    int resp = 0;
    int count = 0;

    foreach (var pas in Model)
    {
        resp += pas.Fly.Price;
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("<style>\r\n\r\n    table tr th {\r\n        text-align: center;\r\n    }\r\n\r\n    tbody tr td {\r\n        text-align: center;\r\n    }\r\n</style>\r\n\r\n<center><h1>Ümumi Biletlər</h1></center>\r\n<center><h3>Bilet Satış Məbləği: ");
#nullable restore
#line 29 "C:\Users\Mushvig\source\layihe\AirLinesTicketSales\Views\Book\Reports.cshtml"
                            Write(resp);

#line default
#line hidden
#nullable disable
            WriteLiteral(" AZN</h3></center>\r\n<br />\r\n");
#nullable restore
#line 31 "C:\Users\Mushvig\source\layihe\AirLinesTicketSales\Views\Book\Reports.cshtml"
 if (TempData["AlertMessage"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-warning\">\r\n        <strong>BİLDİRİŞ: </strong> ");
#nullable restore
#line 34 "C:\Users\Mushvig\source\layihe\AirLinesTicketSales\Views\Book\Reports.cshtml"
                               Write(TempData["AlertMessage"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 36 "C:\Users\Mushvig\source\layihe\AirLinesTicketSales\Views\Book\Reports.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<table class=""table table-info table-striped"">
    <thead>
        <tr>

            <th scope=""col"">#</th>
            <th scope=""col"">Ad</th>
            <th scope=""col"">Soyad</th>
            <th scope=""col"">Pasportun Nömrəsi</th>
            <th scope=""col"">Uçuş Seriyası</th>
            <th scope=""col"">İadə</th>

        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 52 "C:\Users\Mushvig\source\layihe\AirLinesTicketSales\Views\Book\Reports.cshtml"
         foreach (var passenger in Model)
        {
            count++;


#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 57 "C:\Users\Mushvig\source\layihe\AirLinesTicketSales\Views\Book\Reports.cshtml"
               Write(count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 58 "C:\Users\Mushvig\source\layihe\AirLinesTicketSales\Views\Book\Reports.cshtml"
               Write(passenger.PassengerName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 59 "C:\Users\Mushvig\source\layihe\AirLinesTicketSales\Views\Book\Reports.cshtml"
               Write(passenger.PassengerSurname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 60 "C:\Users\Mushvig\source\layihe\AirLinesTicketSales\Views\Book\Reports.cshtml"
               Write(passenger.PassengerPassportNo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 61 "C:\Users\Mushvig\source\layihe\AirLinesTicketSales\Views\Book\Reports.cshtml"
               Write(passenger.Fly.FlySeries);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 62 "C:\Users\Mushvig\source\layihe\AirLinesTicketSales\Views\Book\Reports.cshtml"
               Write(Html.ActionLink("Bileti İadə Etmək", "ReturnTicket", "Book", new { passengerId = passenger.PassengerId }, new { @class = "btn btn-warning" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n            </tr>\r\n");
#nullable restore
#line 65 "C:\Users\Mushvig\source\layihe\AirLinesTicketSales\Views\Book\Reports.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<PassengerToGetDTO>> Html { get; private set; }
    }
}
#pragma warning restore 1591