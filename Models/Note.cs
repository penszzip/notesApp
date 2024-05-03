using System.ComponentModel.DataAnnotations;
namespace notesApp.Models;

public class NoteItem {
    // TODO: change schema: remove title and add date
    public int Id { get; set; }
    public string? Title { get; set; }
    public string? Text { get; set; }
}