using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace TodoDemo.TodoProject;

public partial class TodoFinalContext : DbContext
{
    public TodoFinalContext()
    {
    }

    public TodoFinalContext(DbContextOptions<TodoFinalContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Reminder> Reminders { get; set; }

    public virtual DbSet<Task> Tasks { get; set; }

    public virtual DbSet<TaskAttachment> TaskAttachments { get; set; }

    public virtual DbSet<TaskNote> TaskNotes { get; set; }

    public virtual DbSet<TodoList> TodoLists { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("server=.;database=todoFinal;user id =ayat;password=1234;Trusted_Connection=true;Encrypt=false");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Reminder>(entity =>
        {
            entity.HasKey(e => e.ReminderId).HasName("PK__Reminder__01A830A7F50F3354");

            entity.Property(e => e.ReminderId)
                .ValueGeneratedNever()
                .HasColumnName("ReminderID");
            entity.Property(e => e.ReminderDateTime).HasColumnType("datetime");
            entity.Property(e => e.TaskId).HasColumnName("TaskID");
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.Task).WithMany(p => p.Reminders)
                .HasForeignKey(d => d.TaskId)
                .HasConstraintName("FK__Reminders__TaskI__34C8D9D1");

            entity.HasOne(d => d.User).WithMany(p => p.Reminders)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK__Reminders__UserI__35BCFE0A");
        });

        modelBuilder.Entity<Task>(entity =>
        {
            entity.HasKey(e => e.TaskId).HasName("PK__Tasks__7C6949D101D15E26");

            entity.Property(e => e.TaskId)
                .ValueGeneratedNever()
                .HasColumnName("TaskID");
            entity.Property(e => e.CategoryName).HasMaxLength(50);
            entity.Property(e => e.DueDate).HasColumnType("date");
            entity.Property(e => e.PriorityName).HasMaxLength(50);
            entity.Property(e => e.StatusName).HasMaxLength(50);
            entity.Property(e => e.Title).HasMaxLength(100);
            entity.Property(e => e.TodoListId).HasColumnName("TodoListID");
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.TodoList).WithMany(p => p.Tasks)
                .HasForeignKey(d => d.TodoListId)
                .HasConstraintName("FK__Tasks__TodoListI__2A4B4B5E");

            entity.HasOne(d => d.User).WithMany(p => p.Tasks)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK__Tasks__UserID__29572725");
        });

        modelBuilder.Entity<TaskAttachment>(entity =>
        {
            entity.HasKey(e => e.AttachmentId).HasName("PK__TaskAtta__442C64DE37D22AFC");

            entity.Property(e => e.AttachmentId)
                .ValueGeneratedNever()
                .HasColumnName("AttachmentID");
            entity.Property(e => e.TaskId).HasColumnName("TaskID");
            entity.Property(e => e.UploadedAt).HasColumnType("datetime");

            entity.HasOne(d => d.Task).WithMany(p => p.TaskAttachments)
                .HasForeignKey(d => d.TaskId)
                .HasConstraintName("FK__TaskAttac__TaskI__30F848ED");

            entity.HasOne(d => d.UploadedByNavigation).WithMany(p => p.TaskAttachments)
                .HasForeignKey(d => d.UploadedBy)
                .HasConstraintName("FK__TaskAttac__Uploa__31EC6D26");
        });

        modelBuilder.Entity<TaskNote>(entity =>
        {
            entity.HasKey(e => e.NoteId).HasName("PK__TaskNote__EACE357F6B18DADA");

            entity.Property(e => e.NoteId)
                .ValueGeneratedNever()
                .HasColumnName("NoteID");
            entity.Property(e => e.CreatedAt).HasColumnType("datetime");
            entity.Property(e => e.TaskId).HasColumnName("TaskID");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.TaskNotes)
                .HasForeignKey(d => d.CreatedBy)
                .HasConstraintName("FK__TaskNotes__Creat__2E1BDC42");

            entity.HasOne(d => d.Task).WithMany(p => p.TaskNotes)
                .HasForeignKey(d => d.TaskId)
                .HasConstraintName("FK__TaskNotes__TaskI__2D27B809");
        });

        modelBuilder.Entity<TodoList>(entity =>
        {
            entity.HasKey(e => e.TodoListId).HasName("PK__TodoList__9EA57A6E5E5C6933");

            entity.Property(e => e.TodoListId)
                .ValueGeneratedNever()
                .HasColumnName("TodoListID");
            entity.Property(e => e.Title).HasMaxLength(100);
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.User).WithMany(p => p.TodoLists)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK__TodoLists__UserI__267ABA7A");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__Users__1788CCACD3A2D695");

            entity.Property(e => e.UserId)
                .ValueGeneratedNever()
                .HasColumnName("UserID");
            entity.Property(e => e.Password).HasMaxLength(255);
            entity.Property(e => e.UserName).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
