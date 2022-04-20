using System.ComponentModel.DataAnnotations;

namespace TodoApi.Model;

public class TodoItem
{
    public uint TodoItemId { get; set; }
    public string? Task { get; set; }
    public string? Instructions { get; set; }
    public bool isComplete { get; set; } = false;

    [Display(Name = "Date Created")]
    [DataType(DataType.Date)]
    public DateTime DateCreated { get; set; }

    [Display(Name = "Deadline")]
    [DataType(DataType.Date)]
    public DateTime Deadline { get; set; }
}