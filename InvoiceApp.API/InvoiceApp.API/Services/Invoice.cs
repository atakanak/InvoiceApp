using InvoiceApp.API.Interface;

namespace InvoiceApp.API.Services;

public class Invoice : IInvoice
{
    public List<Model.Invoice> ListInvoicesAsync()
    {
        throw new NotImplementedException();
    }

    public void SendInvoiceAsync(byte[] file)
    {
        throw new NotImplementedException();
    }
}