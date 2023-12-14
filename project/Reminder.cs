using System;
using System.Collections.Generic;

namespace TodoDemo.project;

public partial class Reminder
{
    public int ReminderId { get; set; }

    public int? TaskId { get; set; }

    public DateTime? ReminderDateTime { get; set; }

    public bool? IsCompleted { get; set; }

    public int? UserId { get; set; }

    public virtual Task? Task { get; set; }

    public virtual User? User { get; set; }
}
