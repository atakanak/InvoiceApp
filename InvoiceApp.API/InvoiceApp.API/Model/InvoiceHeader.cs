using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore;

namespace InvoiceApp.API.Model;

public class InvoiceHeader
{
    public int Id { get; set; }

    public string InvoiceId { get; set; }

    public string SenderTitle { get; set; }

    public string ReceiverTitle { get; set; }

    public DateTime Date { get; set; }
    
    [JsonIgnore]
    public List<InvoiceLine>? InvoiceLine { get; set; }
}