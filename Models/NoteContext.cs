using Microsoft.EntityFrameworkCore;

namespace notesApp.Models;

public class NoteDbContext : DbContext
{
    public NoteDbContext(DbContextOptions<NoteDbContext> options)
        : base(options)
    {
    }

    public DbSet<NoteItem> NoteItems { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<NoteItem>().HasData(
            new NoteItem { Id = 1, Text = "First note", Date = DateTime.Now },
            new NoteItem { Id = 2, Text = "Second note", Date = DateTime.Now },
            new NoteItem { Id = 3, Text = "Third note", Date = DateTime.Now },
            new NoteItem { Id = 4, Text = "Fourth note", Date = DateTime.Now },
            new NoteItem { Id = 5, Text = "Fifth note", Date = DateTime.Now }
        );
    }
}