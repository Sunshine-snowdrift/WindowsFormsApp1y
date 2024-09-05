using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.DBContext;

namespace WindowsFormsApp1
{
    public partial class FormAddUsers : Form
    {
        public FormAddUsers()
        {
            InitializeComponent();
        }

        Model1 model = new Model1();
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void FormAddUsers_Load(object sender, EventArgs e)
        {
            bindingSource1.DataSource = model.Roles.ToList();
        }

        private void LoginTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void emailTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void first_NameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void second_NameTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void roleIDComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            Regex reg = new Regex(@"^[A-Z0-9._%+-]+@[A-Z0-9.-]+\.[A-Z]{2,6}$",
RegexOptions.IgnoreCase);
            if (!reg.IsMatch(emailTextbox.Text))
            {
                MessageBox.Show("Почта не соотвествует требованиям!");
                return;
            }
            if (!passwordTextBox.Text.Equals(passwordTextBox2.Text))
            {
                MessageBox.Show("Пароли не равны!");
                return;
            }
            if (String.IsNullOrWhiteSpace(LoginTextBox.Text) ||
            String.IsNullOrWhiteSpace(passwordTextBox.Text) ||
            String.IsNullOrWhiteSpace(first_NameTextBox.Text) ||
            String.IsNullOrWhiteSpace(second_NameTextbox.Text) ||
            !maskedTextBox1.MaskCompleted)
            {
                MessageBox.Show("Заполните все поля!");
                return;
            }
            //Заполнение данных о новом пользователе
            Users users = new Users();
            users.ID = 0;
            users.Login = LoginTextBox.Text;
            users.Password = passwordTextBox.Text;
            users.Email = emailTextbox.Text;
            users.Phone = maskedTextBox1.Text;
            users.First_Name = first_NameTextBox.Text;
            users.Second_Name = second_NameTextbox.Text;
            users.RoleID = (int)roleIDComboBox.SelectedValue;
            users.Gender = radioButton1.Checked ? "Мужской" : "Женский";
            try
            {
                //сохранение данных в БД
                model.Users.Add(users);
                model.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            MessageBox.Show("Данные добавленны!");
            Close();
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
    }

