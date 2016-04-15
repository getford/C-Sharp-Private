﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;
using System.Diagnostics;

namespace WindowsFormsApplication1
{
    public partial class DB_password_form : Form
    {
        public DB_password_form()
        {
            InitializeComponent();
        }

        private void DB_password_form_Load(object sender, EventArgs e)
        {
            Form1 f1 = this.Owner as Form1;
            if(f1 != null) { textBox_user_login_now.Text = f1.user_login_under_avatar.Text.ToString(); }

            refresh_data();     // функция обновления
        }

        public void refresh_data()      // функция обновления датагрида... после того как внесли запись, обновиться грид
        {
            SqlConnection connectDB = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\DB\Database_site.mdf;Integrated Security=True");
            try
            {
                connectDB.Open();
                string sql_query = string.Format("select * from {0}", textBox_user_login_now.Text);
                SqlCommand cmd = new SqlCommand(sql_query, connectDB);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (SqlException ex) { MessageBox.Show(ex.Message); }
            finally { connectDB.Close(); }
        }

        private void button_authorization_site_Click(object sender, EventArgs e)        // обработка авторизации
        {
            Process.Start("C:\\Program Files (x86)\\Google\\Chrome\\Application\\chrome.exe", textBox_URL_site.Text.ToString());
        }

        private void button_register_Click(object sender, EventArgs e)
        {
            SqlConnection connectDB = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\DB\Database_site.mdf;Integrated Security=True");

            try
            {
                connectDB.Open();
                string sql_query_insert = string.Format("open symmetric key SYMMETRIC_KEY decryption by asymmetric key ASYMMETRIC_KEY with password = '()w(wovbomj@%veuoextufz)b)bmh'; declare @Symmetric_key_GUID as [uniqueidentifier] set @Symmetric_key_GUID = KEY_GUID('SYMMETRIC_KEY') if (@Symmetric_key_GUID is not null) begin INSERT INTO {0} values (@Name_site, @URL_site, @Login_site, ENCRYPTBYKEY(@Symmetric_key_GUID, N'@Password_site')) end", textBox_user_login_now.Text.ToString());

                SqlCommand cmd = new SqlCommand(sql_query_insert, connectDB);
                if (textBox_name_site.Text != "" || textBox_URL_site.Text != "" || textBox_login_site.Text != "" || textBox_password_site.Text != "")
                {
                    cmd.Parameters.AddWithValue(@"Name_site", textBox_name_site.Text.ToString());
                    cmd.Parameters.AddWithValue(@"URL_site", textBox_URL_site.Text.ToString());
                    cmd.Parameters.AddWithValue(@"Login_site", textBox_login_site.Text.ToString());
                    cmd.Parameters.AddWithValue(@"Password_site", textBox_password_site.Text.ToString());
                    cmd.ExecuteNonQuery();
                    refresh_data();
                }
                else { MessageBox.Show("Error. Поля не могут быть пустыми!"); }
            }
            catch (SqlException ex) { MessageBox.Show(ex.Message); }
            finally { connectDB.Close(); }
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox_name_site.Clear();
            textBox_URL_site.Clear();
            textBox_login_site.Clear();
            textBox_password_site.Clear();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {

        }

        private void OnClick(object sender, EventArgs e)        // открывает информацию об акк
        {
            //account acc = new account();
            //acc.Show();
        }
    }
}