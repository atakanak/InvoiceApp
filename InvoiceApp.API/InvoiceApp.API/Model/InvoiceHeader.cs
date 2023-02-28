namespace InvoiceApp.API.Model;

public class InvoiceHeader
{
    public string InvoiceId { get; set; }
    
    public string SenderTitle { get; set; }
    
    public string ReceiverTitle { get; set; }
    
    public DateTime Date { get; set; }
}