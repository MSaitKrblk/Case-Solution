using Case2.Models;

namespace Case2.Services;

internal class InvoicePrinter
{
    public void PrintInvoices(InvoiceItems finalInvoice,List<InvoiceDetailInfo> invoiceItems)
    {
        int lineInfo = 0;
        InvoiceDetailInfo allInvoiceText = invoiceItems.Find(i => i.locale != null);

        foreach (var line in finalInvoice.Items)
        {
            if (line.Row > lineInfo)
            {
                Console.WriteLine();
                lineInfo = line.Row;
                Console.Write($"{line.Row}");
            }

            if (allInvoiceText.Description.Contains(line.Description))
            {
                Console.Write($" {line.Description}");
            }
        }
    }
}