namespace TodoDemo
{
    partial class TaskForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            catBox = new TextBox();
            label3 = new Label();
            dateBox = new TextBox();
            label2 = new Label();
            desBox = new TextBox();
            label1 = new Label();
            titleBox = new TextBox();
            updateBtn = new Button();
            deleteBtn = new Button();
            TaskBtn = new Button();
            addBtn = new Button();
            reminderBtn = new Button();
            panel1 = new Panel();
            statusComboBox = new ComboBox();
            priorityComboBox = new ComboBox();
            tasksdataGridView = new DataGridView();
            allTasksBtn = new Button();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tasksdataGridView).BeginInit();
            SuspendLayout();
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Crimson;
            label8.Location = new Point(476, 269);
            label8.Name = "label8";
            label8.Size = new Size(134, 38);
            label8.TabIndex = 21;
            label8.Text = "Tasks List";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Crimson;
            label7.Location = new Point(24, 11);
            label7.Name = "label7";
            label7.Size = new Size(91, 38);
            label7.TabIndex = 20;
            label7.Text = "Tasks ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F);
            label6.ForeColor = Color.AliceBlue;
            label6.Location = new Point(573, 170);
            label6.Name = "label6";
            label6.Size = new Size(137, 31);
            label6.TabIndex = 19;
            label6.Text = "StatusName";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F);
            label5.ForeColor = Color.AliceBlue;
            label5.Location = new Point(334, 170);
            label5.Name = "label5";
            label5.Size = new Size(148, 31);
            label5.TabIndex = 17;
            label5.Text = "PriorityName";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F);
            label4.ForeColor = Color.AliceBlue;
            label4.Location = new Point(718, 59);
            label4.Name = "label4";
            label4.Size = new Size(167, 31);
            label4.TabIndex = 15;
            label4.Text = "CategoryName";
            // 
            // catBox
            // 
            catBox.Font = new Font("Segoe UI", 13.8F);
            catBox.Location = new Point(729, 106);
            catBox.Margin = new Padding(3, 4, 3, 4);
            catBox.Name = "catBox";
            catBox.Size = new Size(186, 38);
            catBox.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F);
            label3.ForeColor = Color.AliceBlue;
            label3.Location = new Point(504, 59);
            label3.Name = "label3";
            label3.Size = new Size(109, 31);
            label3.TabIndex = 13;
            label3.Text = "Due Date";
            // 
            // dateBox
            // 
            dateBox.Font = new Font("Segoe UI", 13.8F);
            dateBox.Location = new Point(504, 107);
            dateBox.Margin = new Padding(3, 4, 3, 4);
            dateBox.Name = "dateBox";
            dateBox.Size = new Size(186, 38);
            dateBox.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F);
            label2.ForeColor = Color.AliceBlue;
            label2.Location = new Point(265, 60);
            label2.Name = "label2";
            label2.Size = new Size(131, 31);
            label2.TabIndex = 11;
            label2.Text = "Description";
            // 
            // desBox
            // 
            desBox.Font = new Font("Segoe UI", 13.8F);
            desBox.Location = new Point(265, 107);
            desBox.Margin = new Padding(3, 4, 3, 4);
            desBox.Name = "desBox";
            desBox.Size = new Size(186, 38);
            desBox.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F);
            label1.ForeColor = Color.AliceBlue;
            label1.Location = new Point(24, 64);
            label1.Name = "label1";
            label1.Size = new Size(58, 31);
            label1.TabIndex = 9;
            label1.Text = "Title";
            // 
            // titleBox
            // 
            titleBox.Font = new Font("Segoe UI", 13.8F);
            titleBox.Location = new Point(24, 107);
            titleBox.Margin = new Padding(3, 4, 3, 4);
            titleBox.Name = "titleBox";
            titleBox.Size = new Size(186, 38);
            titleBox.TabIndex = 8;
            // 
            // updateBtn
            // 
            updateBtn.Font = new Font("Segoe UI", 13.8F);
            updateBtn.ForeColor = Color.CornflowerBlue;
            updateBtn.Location = new Point(953, 233);
            updateBtn.Margin = new Padding(3, 4, 3, 4);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(163, 48);
            updateBtn.TabIndex = 6;
            updateBtn.Text = "Update";
            updateBtn.UseVisualStyleBackColor = true;
            // 
            // deleteBtn
            // 
            deleteBtn.Font = new Font("Segoe UI", 13.8F);
            deleteBtn.ForeColor = Color.CornflowerBlue;
            deleteBtn.Location = new Point(953, 161);
            deleteBtn.Margin = new Padding(3, 4, 3, 4);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(163, 48);
            deleteBtn.TabIndex = 5;
            deleteBtn.Text = "Delete ";
            deleteBtn.UseVisualStyleBackColor = true;
            // 
            // TaskBtn
            // 
            TaskBtn.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TaskBtn.ForeColor = Color.CornflowerBlue;
            TaskBtn.Location = new Point(23, 355);
            TaskBtn.Margin = new Padding(3, 4, 3, 4);
            TaskBtn.Name = "TaskBtn";
            TaskBtn.Size = new Size(223, 48);
            TaskBtn.TabIndex = 12;
            TaskBtn.Text = "Tasks";
            TaskBtn.UseVisualStyleBackColor = true;
            // 
            // addBtn
            // 
            addBtn.Font = new Font("Segoe UI", 13.8F);
            addBtn.ForeColor = Color.CornflowerBlue;
            addBtn.Location = new Point(953, 90);
            addBtn.Margin = new Padding(3, 4, 3, 4);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(163, 48);
            addBtn.TabIndex = 4;
            addBtn.Text = "Add";
            addBtn.UseVisualStyleBackColor = true;
            // 
            // reminderBtn
            // 
            reminderBtn.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            reminderBtn.ForeColor = Color.CornflowerBlue;
            reminderBtn.Location = new Point(23, 274);
            reminderBtn.Margin = new Padding(3, 4, 3, 4);
            reminderBtn.Name = "reminderBtn";
            reminderBtn.Size = new Size(223, 48);
            reminderBtn.TabIndex = 11;
            reminderBtn.Text = "Reminders";
            reminderBtn.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(statusComboBox);
            panel1.Controls.Add(priorityComboBox);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(catBox);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(dateBox);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(desBox);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(titleBox);
            panel1.Controls.Add(tasksdataGridView);
            panel1.Controls.Add(updateBtn);
            panel1.Controls.Add(deleteBtn);
            panel1.Controls.Add(addBtn);
            panel1.Location = new Point(291, 38);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1136, 576);
            panel1.TabIndex = 10;
            // 
            // statusComboBox
            // 
            statusComboBox.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            statusComboBox.FormattingEnabled = true;
            statusComboBox.Items.AddRange(new object[] { "Im Progress", "To Do" });
            statusComboBox.Location = new Point(573, 207);
            statusComboBox.Name = "statusComboBox";
            statusComboBox.Size = new Size(161, 39);
            statusComboBox.TabIndex = 23;
            // 
            // priorityComboBox
            // 
            priorityComboBox.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            priorityComboBox.FormattingEnabled = true;
            priorityComboBox.Items.AddRange(new object[] { "High", "Meduim", "Low" });
            priorityComboBox.Location = new Point(334, 207);
            priorityComboBox.Name = "priorityComboBox";
            priorityComboBox.Size = new Size(161, 39);
            priorityComboBox.TabIndex = 22;
            // 
            // tasksdataGridView
            // 
            tasksdataGridView.BackgroundColor = SystemColors.Control;
            tasksdataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tasksdataGridView.Location = new Point(24, 326);
            tasksdataGridView.Margin = new Padding(3, 4, 3, 4);
            tasksdataGridView.Name = "tasksdataGridView";
            tasksdataGridView.RowHeadersWidth = 51;
            tasksdataGridView.Size = new Size(1092, 233);
            tasksdataGridView.TabIndex = 7;
            // 
            // allTasksBtn
            // 
            allTasksBtn.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            allTasksBtn.ForeColor = Color.CornflowerBlue;
            allTasksBtn.Location = new Point(23, 191);
            allTasksBtn.Margin = new Padding(3, 4, 3, 4);
            allTasksBtn.Name = "allTasksBtn";
            allTasksBtn.Size = new Size(223, 48);
            allTasksBtn.TabIndex = 9;
            allTasksBtn.Text = "Show All Tasks";
            allTasksBtn.UseVisualStyleBackColor = true;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // TaskForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RosyBrown;
            ClientSize = new Size(1446, 625);
            Controls.Add(TaskBtn);
            Controls.Add(reminderBtn);
            Controls.Add(panel1);
            Controls.Add(allTasksBtn);
            Margin = new Padding(3, 4, 3, 4);
            Name = "TaskForm";
            Text = "taskForm";
            Load += TaskForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tasksdataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox catBox;
        private Label label3;
        private TextBox dateBox;
        private Label label2;
        private TextBox desBox;
        private Label label1;
        private TextBox titleBox;
        private Button updateBtn;
        private Button deleteBtn;
        private Button TaskBtn;
        private Button addBtn;
        private Button reminderBtn;
        private Panel panel1;
        private DataGridView tasksdataGridView;
        private Button allTasksBtn;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private ComboBox statusComboBox;
        private ComboBox priorityComboBox;
    }
}