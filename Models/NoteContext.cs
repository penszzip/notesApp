using Microsoft.EntityFrameworkCore;

namespace notesApp.Models;

public class NoteDbContext : DbContext
{
    public NoteDbContext(DbContextOptions<NoteDbContext> options)
        : base(options)
    {
    }

    public DbSet<NoteItem> NoteItems { get; set; } = null!;
}