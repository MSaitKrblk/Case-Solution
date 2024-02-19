namespace Case2.Models;

public class InvoiceItems
{
    public InvoiceItems()
    {
        Items = new List<InvoiceDetailInfo>();
    }

    public List<InvoiceDetailInfo> Items { get; set; }
}