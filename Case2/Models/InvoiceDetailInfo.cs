namespace Case2.Models;

public class InvoiceDetailInfo
{
    public int Row { get; set; }
    public string locale { get; set; }
    public string Description { get; set; }
    public BoundingPoly BoundingPoly { get; set; }
}