using Microsoft.EntityFrameworkCore;

namespace pastebin.Models;

public class PasteDbContext : DbContext
{
    public PasteDbContext(DbContextOptions<PasteDbContext> options)
        : base(options)
    {
    }

    public DbSet<Paste> Pastes { get; set; }
}