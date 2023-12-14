using System;
using System.Collections.Generic;

namespace TodoDemo.TodoProject;

public partial class TodoList
{
    public int TodoListId { get; set; }

    public string Title { get; set; } = null!;

    public string? Description { get; set; }

    public int? UserId { get; set; }

    public virtual ICollection<Task> Tasks { get; set; } = new List<Task>();

    public virtual User? User { get; set; }
}
