using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.DBContext;

namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        Model1 model = new Model1();

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            UserList.DataSource = model.Users.ToList();
        }

        private void UserList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonAdd_Click_Click(object sender, EventArgs e)
        {
            FormAddUsers form = new FormAddUsers();
            form.ShowDialog();
            UserList.DataSource = model.Users.ToList();
        }
    }
}
