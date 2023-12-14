using System;
using System.Collections.Generic;

namespace TodoDemo.TodoProject;

public partial class Task
{
    public int TaskId { get; set; }

    public string Title { get; set; } = null!;

    public string? Description { get; set; }

    public DateTime? DueDate { get; set; }

    public string CategoryName { get; set; } = null!;

    public string PriorityName { get; set; } = null!;

    public string StatusName { get; set; } = null!;

    public int? UserId { get; set; }

    public int? TodoListId { get; set; }

    public virtual ICollection<Reminder> Reminders { get; set; } = new List<Reminder>();

    public virtual ICollection<TaskAttachment> TaskAttachments { get; set; } = new List<TaskAttachment>();

    public virtual ICollection<TaskNote> TaskNotes { get; set; } = new List<TaskNote>();

    public virtual TodoList? TodoList { get; set; }

    public virtual User? User { get; set; }
}
