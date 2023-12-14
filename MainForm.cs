using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TodoDemo.project;

namespace TodoDemo
{
    public partial class MainForm : Form
    {
        public static int cid = 0;
        public MainForm(int id)
        {
            InitializeComponent();
               cid = id;

        }


        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void TaskBtn_Click(object sender, EventArgs e)
        {
            ToDoFianl3Context context = new ToDoFianl3Context();
       
           TaskForm taskform = new TaskForm(cid);
           taskform.Show();
           this.Hide();

        }
    }
}
