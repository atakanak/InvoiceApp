namespace InvoiceApp.API.Model;

public class Invoice
{
    public InvoiceHeader InvoiceHeader { get; set; }
    
    public InvoiceLine InvoiceLine { get; set; }
}