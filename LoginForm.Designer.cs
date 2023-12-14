namespace TodoDemo
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            userNameText = new Label();
            userNameBox = new TextBox();
            passwordBox = new TextBox();
            passwordText = new Label();
            loginBtn = new Button();
            pictureBox1 = new PictureBox();
            signupButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // userNameText
            // 
            userNameText.AutoSize = true;
            userNameText.Location = new Point(129, 204);
            userNameText.Name = "userNameText";
            userNameText.Size = new Size(165, 41);
            userNameText.TabIndex = 0;
            userNameText.Text = "User Name";
            // 
            // userNameBox
            // 
            userNameBox.BackColor = SystemColors.HighlightText;
            userNameBox.Location = new Point(300, 204);
            userNameBox.Name = "userNameBox";
            userNameBox.Size = new Size(276, 47);
            userNameBox.TabIndex = 1;
            // 
            // passwordBox
            // 
            passwordBox.Location = new Point(300, 301);
            passwordBox.Name = "passwordBox";
            passwordBox.Size = new Size(276, 47);
            passwordBox.TabIndex = 2;
            // 
            // passwordText
            // 
            passwordText.AutoSize = true;
            passwordText.Location = new Point(129, 304);
            passwordText.Name = "passwordText";
            passwordText.Size = new Size(143, 41);
            passwordText.TabIndex = 2;
            passwordText.Text = "Password";
            // 
            // loginBtn
            // 
            loginBtn.BackColor = Color.LightBlue;
            loginBtn.Cursor = Cursors.Hand;
            loginBtn.ForeColor = Color.Indigo;
            loginBtn.Location = new Point(247, 391);
            loginBtn.Margin = new Padding(0);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(144, 52);
            loginBtn.TabIndex = 3;
            loginBtn.Text = "Sign in";
            loginBtn.UseVisualStyleBackColor = false;
            loginBtn.Click += loginBtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(247, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(218, 127);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // signupButton
            // 
            signupButton.BackColor = Color.LightBlue;
            signupButton.Cursor = Cursors.Hand;
            signupButton.ForeColor = Color.Indigo;
            signupButton.Location = new Point(432, 391);
            signupButton.Margin = new Padding(0);
            signupButton.Name = "signupButton";
            signupButton.Size = new Size(144, 52);
            signupButton.TabIndex = 5;
            signupButton.Text = "Sign up";
            signupButton.UseVisualStyleBackColor = false;
            signupButton.Click += signupButton_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RosyBrown;
            ClientSize = new Size(718, 531);
            Controls.Add(signupButton);
            Controls.Add(pictureBox1);
            Controls.Add(loginBtn);
            Controls.Add(passwordBox);
            Controls.Add(passwordText);
            Controls.Add(userNameBox);
            Controls.Add(userNameText);
            Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(6);
            Name = "LoginForm";
            Text = "Log-in Form";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label userNameText;
        private TextBox userNameBox;
        private TextBox passwordBox;
        private Label passwordText;
        private Button loginBtn;
        private PictureBox pictureBox1;
        private Button signupBtn;
        private Button signupButton;
    }
}
