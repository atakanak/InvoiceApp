using InvoiceApp.API.Model;
using Microsoft.EntityFrameworkCore;

namespace InvoiceApp.API.DataAccess;

public class InvoiceAppDBContext : DbContext
{
    public InvoiceAppDBContext(DbContextOptions<InvoiceAppDBContext> options) : base(options)
    {
        
    }

    public DbSet<InvoiceHeader> InvoicesHeaders => Set<InvoiceHeader>();
    public DbSet<InvoiceLine> InvoicesLines => Set<InvoiceLine>();
}