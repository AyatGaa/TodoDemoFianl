using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TodoDemo
{
    public partial class TaskForm : Form
    {
        public static int cid = 0;
        public TaskForm(int id)
        {
            InitializeComponent();
            cid = id;
            tasksdataGridView.DataSource = Queries.Query.getTaskByUserID(cid);

        }

        private void TaskForm_Load(object sender, EventArgs e)
        {

        }
    }
}
