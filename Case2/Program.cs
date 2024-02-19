using Case2.Models;
using Case2.Services;

namespace Case2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string json = File.ReadAllText("response.json");

            InvoiceProcessor invoiceProcessor = new InvoiceProcessor();
            List<InvoiceDetailInfo> invoiceItems = invoiceProcessor.GetInvoiceDetails(json);

            InvoiceSorter invoiceSorter = new InvoiceSorter();
            List<InvoiceDetailInfo> sortedInvoiceByRow = invoiceSorter.SortInvoiceByRow(invoiceItems);

            InvoiceOrganizer invoiceOrganizer = new InvoiceOrganizer();
            InvoiceItems finalInvoice = invoiceOrganizer.OrganizeInvoices(sortedInvoiceByRow);

            InvoicePrinter invoicePrinter = new InvoicePrinter();
            invoicePrinter.PrintInvoices(finalInvoice,invoiceItems); 
        }
    }





    









}
