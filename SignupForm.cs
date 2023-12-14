using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TodoDemo.Queries;
using TodoDemo.project;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace TodoDemo
{
    public partial class SignupForm : Form
    {
       
        public SignupForm()
        {
            InitializeComponent();
        }


        // Check if the username already exists (optional, depending on your requirements)
 
private void singupBtn_Click(object sender, EventArgs e)
        {
            // Assuming txtUsername and txtPassword contain the user input
            var cid = Query.checkLogin(userNameBoxSign.Text, passwordBoxSign.Text);
             if (cid == null)
            {
                MessageBox.Show("Username already exists. Please choose a different username.");

            }
            else if (userNameBoxSign.Text == "" || passwordBoxSign.Text == "")
            {
                MessageBox.Show("Empty fileds !! ");
            }
             else
            {
                Query.signup(userNameBoxSign.Text, passwordBoxSign.Text);
                // Optionally show a success message or perform any additional actions
                MessageBox.Show("User created successfully!");
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
                this.Hide();
            }



        }
    }
}
