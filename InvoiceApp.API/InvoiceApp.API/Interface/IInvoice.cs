using InvoiceApp.API.Model;

namespace InvoiceApp.API.Interface;

public interface IInvoice
{
    public List<Invoice> ListInvoicesAsync();
    
    void SendInvoiceAsync(byte[] file);
}