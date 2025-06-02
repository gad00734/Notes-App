using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
public class User
{
    [Key]
    public int UserId { get; set; }
    public string Username { get; set; }
    public string PasswordHash { get; set; } 
    public List<Note> Notes { get; set; }
}