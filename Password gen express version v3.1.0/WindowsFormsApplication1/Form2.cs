﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.CodeDom;


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

        private void button3_Click(object sender, EventArgs e)      // test button
        {
            System.IO.StreamWriter File_login = new System.IO.StreamWriter(@"C:\LogIn_App_password_GEN.txt");
            if(button3.Enabled == true)
            {
                File_login.Write("getford");
                File_login.WriteLine(System.DateTime.Now);
                if (File_login != null)
                    File_login.Close();
            }
            else
            {
                MessageBox.Show("Error");
            }
            File_login.Close();
        }

        private void button1_Click(object sender, EventArgs e)              // log in
        {
            System.IO.StreamReader File_login = new System.IO.StreamReader(@"C:\1LogIn_App_password_GEN.txt");

            if(String.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("231");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)              // sign in
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)       // login textbox
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)       // password  textbox
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
