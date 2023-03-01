namespace InvoiceApp.API.Model;

public class Invoice
{
    public InvoiceHeader InvoiceHeader { get; set; }
    
    public List<InvoiceLine> InvoiceLine { get; set; }
}