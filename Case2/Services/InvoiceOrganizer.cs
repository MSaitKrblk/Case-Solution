using Case2.Models;

namespace Case2.Services;

internal class InvoiceOrganizer
{
    public InvoiceItems OrganizeInvoices(List<InvoiceDetailInfo> sortedInvoiceByRow)
    {
        InvoiceItems finalInvoice = new InvoiceItems();
        int row = 0;
        int coordinateInfo = 0;

        foreach (var invoice in sortedInvoiceByRow)
        {
            InvoiceDetailInfo invoiceDetailInfo = new InvoiceDetailInfo();

            if (invoice.BoundingPoly.Vertices[0].Y > (coordinateInfo + 15))
                row++;

            invoiceDetailInfo.Description = invoice.Description;
            invoiceDetailInfo.Row = row;
            invoiceDetailInfo.BoundingPoly = invoice.BoundingPoly;
            coordinateInfo = invoice.BoundingPoly.Vertices[0].Y;
            finalInvoice.Items.Add(invoiceDetailInfo);
        }

        return finalInvoice;
    }
}