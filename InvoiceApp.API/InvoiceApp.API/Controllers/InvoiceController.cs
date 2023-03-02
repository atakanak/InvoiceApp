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
    public async Task<List<InvoiceLine>> GetInvoiceDetail(string id)
    {
        return await _context.InvoicesHeaders
            .Where(x => x.InvoiceId == id)
            .Select(x => x.InvoiceLine)
            .FirstOrDefaultAsync();
    }

    [HttpPost]
    [Route("api/[controller]/UploadInvoice")]
    public async Task<IActionResult> UploadInvoice(byte[] file)
    {
        try
        {
            Invoice invoice = JsonSerializer.Deserialize<Invoice>(file);
            if (_context.InvoicesHeaders.Any(x => x.InvoiceId != invoice.InvoiceHeader.InvoiceId))
            {
                invoice.InvoiceHeader.InvoiceLine = invoice.InvoiceLine;
                _context.InvoicesHeaders.Add(invoice.InvoiceHeader);
            
                await _context.SaveChangesAsync();
            
                return Ok();
            }
            else
            {
                return BadRequest("Böyle bir fatura var");
            }
        }
        catch (Exception e)
        {
            throw e;
        }
    }
}