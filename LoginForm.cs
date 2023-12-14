using Microsoft.EntityFrameworkCore;
using TodoDemo.Queries;
using TodoDemo.project;

namespace TodoDemo
{
    public partial class LoginForm : Form
    {
        ToDoFianl3Context context;

        public LoginForm()
        {
            InitializeComponent();

        }

        //var user = dbContext.Users.FirstOrDefault(u => u.UserName == inputUsername && u.Password == inputPassword);


        private void loginBtn_Click(object sender, EventArgs e)
        {
            var cid = Query.checkLogin(userNameBox.Text, passwordBox.Text);
             string userName = userNameBox.Text;
            string password = passwordBox.Text;
            if (userNameBox.Text == "" || passwordBox.Text == "")
            {
                MessageBox.Show("Empty fileds !! ");
            }
            else if ( cid != null)
            {
                MainForm mainForm = new MainForm(cid);
                mainForm.Show();
                this.Hide();
                
                
            }
            else
            {

                MessageBox.Show("invalid user name or Password");
            }
        }

        private void signupButton_Click(object sender, EventArgs e)
        {
            SignupForm signuFrm = new SignupForm();
            signuFrm.Show();
            this.Hide();
        }
    }
}
