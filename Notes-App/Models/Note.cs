using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
public class Note
{
    [Key]
    public int NoteID { get; set; }
    [Required, MaxLength(100)]
    public string Title { get; set; }
    public string Content { get; set; }
    public string Category { get; set; }
    public DateTime CreationDate { get; set; } = DateTime.Now;
    public DateTime? ReminderDate { get; set; }

    [ForeignKey("User")]
    public int UserID { get; set; }
    public User User { get; set; }

}
