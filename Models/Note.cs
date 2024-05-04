using System.ComponentModel.DataAnnotations;
namespace notesApp.Models;

public class NoteItem {
    // TODO: change schema: remove title and add date
    public int Id { get; set; }
    public string? Text { get; set; }
    public DateTime Date { get; set; }
}