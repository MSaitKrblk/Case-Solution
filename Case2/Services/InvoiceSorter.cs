using Case2.Models;

namespace Case2.Services;

internal class InvoiceSorter
{
    public List<InvoiceDetailInfo> SortInvoiceByRow(List<InvoiceDetailInfo> invoiceItems)
    {
        return invoiceItems.FindAll(i => i.locale == null).OrderBy(i => i.BoundingPoly.Vertices[0].Y).ToList();
    }
}