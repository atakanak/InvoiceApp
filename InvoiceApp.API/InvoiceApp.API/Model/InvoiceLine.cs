using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore;

namespace InvoiceApp.API.Model;

public class InvoiceLine
{
    [Key]
    public int LineId { get; set; }
    
    [JsonPropertyName("Id")]
    public int InvoiceLineId { get; set; }
    
    [JsonIgnore]
    public int InvoiceHeaderId { get; set; }

    public string Name { get; set; }

    public int Quantity { get; set; }

    public string UnitCode { get; set; }

    public int UnitPrice { get; set; }
}