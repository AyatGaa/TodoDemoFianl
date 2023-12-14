using System;
using System.Collections.Generic;

namespace TodoDemo.TodoProject;

public partial class TaskAttachment
{
    public int AttachmentId { get; set; }

    public int? TaskId { get; set; }

    public string? FilePath { get; set; }

    public string? Description { get; set; }

    public DateTime? UploadedAt { get; set; }

    public int? UploadedBy { get; set; }

    public virtual Task? Task { get; set; }

    public virtual User? UploadedByNavigation { get; set; }
}
