using System.Text.Json;
using InvoiceApp.API.DataAccess;
using InvoiceApp.API.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace InvoiceApp.API.Controllers;

[ApiController]
public class InvoiceController : ControllerBase
{
    private readonly InvoiceAppDBContext _context;

    public InvoiceController(InvoiceAppDBContext context)
    {
        _context = context;
    }

    [HttpGet]
    [Route("api/[controller]/GetInvoices")]
    public async Task<List<InvoiceHeader>> GetInvoices()
    {
        return await _context.InvoicesHeaders.ToListAsync();
    }

    [HttpGet]
    [Route("api/[controller]/GetInvoiceDetail/{id}")]
    public async Task<Invoice> GetInvoiceDetail(string id)
    {
        return await _context.InvoicesHeaders
            .Where(x => x.InvoiceId == id)
            .Select(x => new Invoice
            {
                InvoiceHeader = new InvoiceHeader
                {
                    InvoiceId = x.InvoiceId,
                    SenderTitle = x.SenderTitle,
                    ReceiverTitle = x.ReceiverTitle,
                    Date = x.Date
                },
                InvoiceLine = x.InvoiceLine
            })
            .FirstOrDefaultAsync();
    }

    [HttpPost]
    [Route("api/[controller]/UploadInvoice")]
    public async Task<IActionResult> UploadInvoice([FromBody] Invoice invoice)
    {
        try
        {
            if (_context.InvoicesHeaders.Any(x => x.InvoiceId == invoice.InvoiceHeader.InvoiceId))
            {
                return BadRequest("Böyle bir fatura var");
            }

            invoice.InvoiceHeader.InvoiceLine = invoice.InvoiceLine;
            _context.InvoicesHeaders.Add(invoice.InvoiceHeader);

            await _context.SaveChangesAsync();

            return Ok();
        }
        catch (Exception e)
        {
            throw e;
        }
    }
}