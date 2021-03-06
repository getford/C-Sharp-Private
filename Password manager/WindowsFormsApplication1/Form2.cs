﻿using System;
using System.Windows.Forms;

using System.Data.SqlClient;
using System.Diagnostics;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent(); 
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)              // log in
        {
            string pw = string.Empty;       // сюда положим расшифрованный пароль
            SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\DB\Database.mdf;Integrated Security=True");
            try
            {
                connect.Open();
                string sql_quert_select_password = string.Format("open symmetric key SYMMETRIC_KEY decryption by asymmetric key ASYMMETRIC_KEY with password = '%(wbwgoo$'; select CONVERT(nvarchar(50), DECRYPTBYKEY(user_password)) as [user_password] from [dbo].[introduce] where user_login = '" + textBox1.Text.ToString() + "'");
                SqlCommand cmd_select = new SqlCommand(sql_quert_select_password, connect);
                SqlDataReader dr = cmd_select.ExecuteReader();
                if (textBox1.Text.ToString() == "" || textBox2.Text.ToString() == "")
                {
                    MessageBox.Show("Поля заполнены не корректно (возможно вы не ввели логин или пароль!). Пожалуйста, попробуйте снова!");
                    textBox1.Clear();
                    textBox2.Clear();
                }
                else
                {
                    while (dr.Read())
                    {
                        pw += dr["user_password"];

                        if (textBox2.Text.ToString() == pw.ToString())
                        {
                            Form1 f1_main = new Form1();
                            f1_main.Owner = this;
                            f1_main.Show();
                            Hide();
                        }
                        else
                        {
                            MessageBox.Show("Введен не верный пароль!. Если вы забыли ваш пароль, воспользуйтесь формой восстановления пароля!");
                        }
                    }
                    dr.Close();
                }
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connect.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)              // close button
        {
            Application.Exit();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)     // регистрация 
        {
            if (linkLabel2.Enabled == true)
            {
                foreach (Form f in Application.OpenForms)            // не разрешаем открыть еще одну форму
                {
                    if (f.Name == "SignInForm")
                    {
                        MessageBox.Show("Форма уже открыта", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                SignInForm sgn_form = new SignInForm();
                sgn_form.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)      // свернуть
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            foreach (Form f in Application.OpenForms)            // не разрешаем открыть еще одну форму
            {
                if (f.Name == "Form_Restore_Password")
                {
                    MessageBox.Show("Форма уже открыта", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            Form_Restore_Password frm = new Form_Restore_Password();
            frm.Show();
        }

        private void Key_Down(object sender, KeyEventArgs e)  // сюда писать обработку нажатия кнопок
        {
            if(e.KeyCode == Keys.Enter)     // при нажатие на "Enter" будет обрабатываться кнопка "Войти"
            {
                button1_Click(sender, e);
            }
        }

        private void button_help_Click(object sender, EventArgs e)
        {
            Process.Start(AppDomain.CurrentDomain.BaseDirectory );
            //Form_help fh = new Form_help();         // открывает форму справки, в которой будут ссылки на руководство пользователя ...
            //fh.Show();
        }
    }
}
