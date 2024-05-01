using System.ComponentModel.DataAnnotations;
namespace notesApp.Models;

public class NoteItem {
    public int Id { get; set; }
    public string? Title { get; set; }
    public string? Text { get; set; }
}