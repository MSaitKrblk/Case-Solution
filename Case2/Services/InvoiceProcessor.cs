using Case2.Models;
using Newtonsoft.Json;

namespace Case2.Services;

internal class InvoiceProcessor
{
    public List<InvoiceDetailInfo> GetInvoiceDetails(string json)
    {
        return JsonConvert.DeserializeObject<List<InvoiceDetailInfo>>(json);
    }
}