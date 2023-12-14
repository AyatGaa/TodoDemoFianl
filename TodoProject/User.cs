using System;
using System.Collections.Generic;

namespace TodoDemo.TodoProject;

public partial class User
{
    public int UserId { get; set; }

    public string UserName { get; set; } = null!;

    public string Password { get; set; } = null!;

    public virtual ICollection<Reminder> Reminders { get; set; } = new List<Reminder>();

    public virtual ICollection<TaskAttachment> TaskAttachments { get; set; } = new List<TaskAttachment>();

    public virtual ICollection<TaskNote> TaskNotes { get; set; } = new List<TaskNote>();

    public virtual ICollection<Task> Tasks { get; set; } = new List<Task>();

    public virtual ICollection<TodoList> TodoLists { get; set; } = new List<TodoList>();
}
