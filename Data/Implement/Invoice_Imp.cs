using Compu_Pos.Data.Context;
using Compu_Pos.Data.IRepos;
using Compu_Pos.Data.Models;
using Microsoft.EntityFrameworkCore;

public class Invoice_Imp : Iinvoice_Repo
{
    private readonly ApplicationDBContext _context;

    public Invoice_Imp(ApplicationDBContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Invoice>> GetAll()
    {
        return await _context.Invoices.Include(i => i.Items).ToListAsync();
    }

    public async Task<Invoice> GetById(int id)
    {
        return await _context.Invoices.Include(i => i.Items).FirstOrDefaultAsync(i => i.Id == id);
    }

    public async Task Add(Invoice model)
    {
        await _context.Invoices.AddAsync(model);
        await _context.SaveChangesAsync();
    }

    public async Task Update(Invoice model)
    {
        _context.Invoices.Update(model);
        await _context.SaveChangesAsync();
    }

    public async Task Delete(int id)
    {
        var invoice = await _context.Invoices.FindAsync(id);
        if (invoice != null)
        {
            _context.Invoices.Remove(invoice);
            await _context.SaveChangesAsync();
        }
    }

    public async Task<int> GetNextInvoiceNumber()
    {
        var maxId = await _context.Invoices.MaxAsync(i => i.Id);
        return maxId;
    }
}