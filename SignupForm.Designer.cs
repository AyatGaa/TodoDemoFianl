namespace TodoDemo
{
    partial class SignupForm
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
            userNameText = new Label();
            userNameBoxSign = new TextBox();
            passwordBoxSign = new TextBox();
            passwordText = new Label();
            label1 = new Label();
            singupBtn = new Button();
            SuspendLayout();
            // 
            // userNameText
            // 
            userNameText.AutoSize = true;
            userNameText.ForeColor = SystemColors.ActiveCaptionText;
            userNameText.Location = new Point(71, 185);
            userNameText.Name = "userNameText";
            userNameText.Size = new Size(165, 41);
            userNameText.TabIndex = 0;
            userNameText.Text = "User Name";
            // 
            // userNameBoxSign
            // 
            userNameBoxSign.Location = new Point(252, 185);
            userNameBoxSign.Name = "userNameBoxSign";
            userNameBoxSign.Size = new Size(315, 47);
            userNameBoxSign.TabIndex = 1;
       
            // 
            // passwordBoxSign
            // 
            passwordBoxSign.Location = new Point(252, 290);
            passwordBoxSign.Name = "passwordBoxSign";
            passwordBoxSign.Size = new Size(315, 47);
            passwordBoxSign.TabIndex = 3;
            // 
            // passwordText
            // 
            passwordText.AutoSize = true;
            passwordText.Location = new Point(71, 290);
            passwordText.Name = "passwordText";
            passwordText.Size = new Size(143, 41);
            passwordText.TabIndex = 4;
            passwordText.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(244, 29);
            label1.Name = "label1";
            label1.Size = new Size(323, 106);
            label1.TabIndex = 5;
            label1.Text = "Sign Up";
            // 
            // singupBtn
            // 
            singupBtn.ForeColor = SystemColors.InfoText;
            singupBtn.Location = new Point(429, 390);
            singupBtn.Name = "singupBtn";
            singupBtn.Size = new Size(138, 49);
            singupBtn.TabIndex = 6;
            singupBtn.Text = "Sign Up";
            singupBtn.UseVisualStyleBackColor = true;
            singupBtn.Click += singupBtn_Click;
            // 
            // SignupForm
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RosyBrown;
            ClientSize = new Size(801, 523);
            Controls.Add(singupBtn);
            Controls.Add(label1);
            Controls.Add(passwordBoxSign);
            Controls.Add(passwordText);
            Controls.Add(userNameBoxSign);
            Controls.Add(userNameText);
            Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(6);
            Name = "SignupForm";
            Text = "SignupFormcs";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label userNameText;
        private TextBox userNameBoxSign;
        private TextBox passwordBoxSign;
        private Label passwordText;
        private Label label1;
        private Button singupBtn;
    }
}