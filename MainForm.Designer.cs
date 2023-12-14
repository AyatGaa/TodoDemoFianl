namespace TodoDemo
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            allTasksBtn = new Button();
            reminderBtn = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            TaskBtn = new Button();
            tasksdataGridView = new DataGridView();
            label7 = new Label();
            label8 = new Label();
            panel1 = new Panel();
            addBtn = new Button();
            deleteBtn = new Button();
            updateBtn = new Button();
            titleBox = new TextBox();
            label1 = new Label();
            desBox = new TextBox();
            label2 = new Label();
            dateBox = new TextBox();
            label3 = new Label();
            catBox = new TextBox();
            label4 = new Label();
            priorityBox = new TextBox();
            label5 = new Label();
            statusBox = new TextBox();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)tasksdataGridView).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // allTasksBtn
            // 
            allTasksBtn.ForeColor = Color.CornflowerBlue;
            allTasksBtn.Location = new Point(31, 36);
            allTasksBtn.Name = "allTasksBtn";
            allTasksBtn.Size = new Size(223, 48);
            allTasksBtn.TabIndex = 0;
            allTasksBtn.Text = "Show All Tasks";
            allTasksBtn.UseVisualStyleBackColor = true;
            // 
            // reminderBtn
            // 
            reminderBtn.ForeColor = Color.CornflowerBlue;
            reminderBtn.Location = new Point(31, 101);
            reminderBtn.Name = "reminderBtn";
            reminderBtn.Size = new Size(223, 48);
            reminderBtn.TabIndex = 2;
            reminderBtn.Text = "Reminders";
            reminderBtn.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.ForeColor = Color.CornflowerBlue;
            button4.Location = new Point(31, 295);
            button4.Name = "button4";
            button4.Size = new Size(223, 48);
            button4.TabIndex = 5;
            button4.Text = "Show All Tasks";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.ForeColor = Color.CornflowerBlue;
            button5.Location = new Point(31, 511);
            button5.Name = "button5";
            button5.Size = new Size(223, 48);
            button5.TabIndex = 6;
            button5.Text = "Show All Tasks";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.ForeColor = Color.CornflowerBlue;
            button6.Location = new Point(31, 372);
            button6.Name = "button6";
            button6.Size = new Size(223, 48);
            button6.TabIndex = 7;
            button6.Text = "Show All Tasks";
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.ForeColor = Color.CornflowerBlue;
            button7.Location = new Point(31, 444);
            button7.Name = "button7";
            button7.Size = new Size(223, 48);
            button7.TabIndex = 8;
            button7.Text = "Show All Tasks";
            button7.UseVisualStyleBackColor = true;
            // 
            // TaskBtn
            // 
            TaskBtn.ForeColor = Color.CornflowerBlue;
            TaskBtn.Location = new Point(31, 183);
            TaskBtn.Name = "TaskBtn";
            TaskBtn.Size = new Size(223, 48);
            TaskBtn.TabIndex = 3;
            TaskBtn.Text = "Tasks";
            TaskBtn.UseVisualStyleBackColor = true;
            TaskBtn.Click += TaskBtn_Click;
            // 
            // tasksdataGridView
            // 
            tasksdataGridView.BackgroundColor = SystemColors.Control;
            tasksdataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tasksdataGridView.Location = new Point(24, 326);
            tasksdataGridView.Name = "tasksdataGridView";
            tasksdataGridView.RowHeadersWidth = 51;
            tasksdataGridView.Size = new Size(1092, 233);
            tasksdataGridView.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.Crimson;
            label7.Location = new Point(24, 7);
            label7.Name = "label7";
            label7.Size = new Size(95, 41);
            label7.TabIndex = 20;
            label7.Text = "Tasks ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.Crimson;
            label8.Location = new Point(476, 269);
            label8.Name = "label8";
            label8.Size = new Size(139, 41);
            label8.TabIndex = 21;
            label8.Text = "Tasks List";
            // 
            // panel1
            // 
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(statusBox);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(priorityBox);
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
            panel1.Location = new Point(282, 36);
            panel1.Name = "panel1";
            panel1.Size = new Size(1136, 576);
            panel1.TabIndex = 1;
            // 
            // addBtn
            // 
            addBtn.ForeColor = Color.CornflowerBlue;
            addBtn.Location = new Point(953, 90);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(163, 48);
            addBtn.TabIndex = 4;
            addBtn.Text = "Add";
            addBtn.UseVisualStyleBackColor = true;
            // 
            // deleteBtn
            // 
            deleteBtn.ForeColor = Color.CornflowerBlue;
            deleteBtn.Location = new Point(953, 161);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(163, 48);
            deleteBtn.TabIndex = 5;
            deleteBtn.Text = "Delete ";
            deleteBtn.UseVisualStyleBackColor = true;
            // 
            // updateBtn
            // 
            updateBtn.ForeColor = Color.CornflowerBlue;
            updateBtn.Location = new Point(953, 233);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(163, 48);
            updateBtn.TabIndex = 6;
            updateBtn.Text = "Update";
            updateBtn.UseVisualStyleBackColor = true;
            // 
            // titleBox
            // 
            titleBox.Location = new Point(24, 107);
            titleBox.Name = "titleBox";
            titleBox.Size = new Size(186, 47);
            titleBox.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.AliceBlue;
            label1.Location = new Point(24, 63);
            label1.Name = "label1";
            label1.Size = new Size(74, 41);
            label1.TabIndex = 9;
            label1.Text = "Title";
            // 
            // desBox
            // 
            desBox.Location = new Point(265, 107);
            desBox.Name = "desBox";
            desBox.Size = new Size(186, 47);
            desBox.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.AliceBlue;
            label2.Location = new Point(265, 60);
            label2.Name = "label2";
            label2.Size = new Size(169, 41);
            label2.TabIndex = 11;
            label2.Text = "Description";
            // 
            // dateBox
            // 
            dateBox.Location = new Point(504, 107);
            dateBox.Name = "dateBox";
            dateBox.Size = new Size(186, 47);
            dateBox.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.AliceBlue;
            label3.Location = new Point(504, 59);
            label3.Name = "label3";
            label3.Size = new Size(142, 41);
            label3.TabIndex = 13;
            label3.Text = "Due Date";
            // 
            // catBox
            // 
            catBox.Location = new Point(729, 106);
            catBox.Name = "catBox";
            catBox.Size = new Size(186, 47);
            catBox.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.AliceBlue;
            label4.Location = new Point(718, 59);
            label4.Name = "label4";
            label4.Size = new Size(218, 41);
            label4.TabIndex = 15;
            label4.Text = "CategoryName";
            // 
            // priorityBox
            // 
            priorityBox.Location = new Point(334, 207);
            priorityBox.Name = "priorityBox";
            priorityBox.Size = new Size(186, 47);
            priorityBox.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.AliceBlue;
            label5.Location = new Point(334, 158);
            label5.Name = "label5";
            label5.Size = new Size(191, 41);
            label5.TabIndex = 17;
            label5.Text = "PriorityName";
            // 
            // statusBox
            // 
            statusBox.Location = new Point(573, 207);
            statusBox.Name = "statusBox";
            statusBox.Size = new Size(186, 47);
            statusBox.TabIndex = 18;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.AliceBlue;
            label6.Location = new Point(573, 158);
            label6.Name = "label6";
            label6.Size = new Size(177, 41);
            label6.TabIndex = 19;
            label6.Text = "StatusName";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RosyBrown;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1452, 733);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(TaskBtn);
            Controls.Add(reminderBtn);
            Controls.Add(panel1);
            Controls.Add(allTasksBtn);
            DoubleBuffered = true;
            Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.RoyalBlue;
            Margin = new Padding(6);
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)tasksdataGridView).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button allTasksBtn;
        private Button reminderBtn;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button TaskBtn;
        private DataGridView tasksdataGridView;
        private Label label7;
        private Label label8;
        private Panel panel1;
        private Label label6;
        private TextBox statusBox;
        private Label label5;
        private TextBox priorityBox;
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
        private Button addBtn;
    }
}