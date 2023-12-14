using System;
using System.Collections.Generic;

namespace TodoDemo.project;

public partial class TaskNote
{
    public int NoteId { get; set; }

    public int? TaskId { get; set; }

    public string? NoteText { get; set; }

    public DateTime? CreatedAt { get; set; }

    public int? CreatedBy { get; set; }

    public virtual User? CreatedByNavigation { get; set; }

    public virtual Task? Task { get; set; }
}
