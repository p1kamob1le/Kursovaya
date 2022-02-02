using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormReg : Form
    {
        public FormReg()
        {
            InitializeComponent();

            textBoxUsername.Text = "Введите логин";
            textBoxUserpass.Text = "Введите пароль";
        }

        private void buttonReg_Click(object sender, EventArgs e)
        {
            if (textBoxUsername.Text == "Введите логин")
            {
                MessageBox.Show("Введите логин");
                return;
            }
            if (textBoxUserpass.Text == "Введите пароль")
            {
                MessageBox.Show("Введите пароль");
                return;
            }

            if (checkUser())
            
                return;
            

            User user = new User();

            

            MySqlCommand command = new MySqlCommand("INSERT INTO `users` (`login`, `pass`) VALUES (@login, @pass);", user.GetConnection());

            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = textBoxUsername.Text;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = textBoxUserpass.Text;

            

            user.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Регистрация прошла успешно");
                this.Hide();
                FormAuth formauth = new FormAuth();
                formauth.Show();
            }
            else
                MessageBox.Show("Такой пользователь уже существует");
            user.closeConnection();

        }

        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void buttonCan_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void textBoxUsername_Enter(object sender, EventArgs e)
        {
           if (textBoxUsername.Text=="Введите логин")
            textBoxUsername.Text = "";
        }

        private void textBoxUsername_Leave(object sender, EventArgs e)
        {
            if (textBoxUsername.Text == "")
                textBoxUsername.Text = "Введите логин";
        }

        private void textBoxUserpass_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxUserpass_Enter(object sender, EventArgs e)
        {
            if (textBoxUserpass.Text == "Введите пароль")
                textBoxUserpass.Text = "";
        }

        private void textBoxUserpass_Leave(object sender, EventArgs e)
        {
            if (textBoxUserpass.Text == "")
            textBoxUserpass.Text = "Введите пароль";
        }
        public Boolean checkUser()
        {
            User user = new User();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL", user.GetConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = textBoxUsername.Text;
            

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Такой пользователь уже существует");
                return true;
            }

            else
                
            return false;
        }

        private void labelauth_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAuth formauth = new FormAuth();
            formauth.Show();
        }
    }
}
