﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            toolTip1.SetToolTip(button1, "Нажмите для генерации пароля");       // Всплывающая подсказка
            toolTip2.ToolTipTitle = ("Путь к файлу C:\\ ... .txt");
            toolTip2.SetToolTip(button4, "Нажмите для сохранения в файл!");

            Form2 f2 = this.Owner as Form2;         // указываем родительскую форму из котороый будет получено поле (поле должно быть public)
            if (f2 != null)
            {
                textBox_user_login_under_avatar.Text = f2.textBox1.Text.ToString();
                string st = textBox_user_login_under_avatar.Text.ToString();
            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == null)
                Close();
            else
            {
                SaveFileDialog save_password = new SaveFileDialog();

                save_password.FileName = Environment.UserName + "_password.txt";
                save_password.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                if (save_password.ShowDialog() == DialogResult.OK)
                {
                    System.IO.StreamWriter wr = new System.IO.StreamWriter(save_password.FileName);
                    wr.Write("Data & Time:  " + System.DateTimeOffset.Now + " UTC" + Environment.NewLine + Environment.NewLine);
                    wr.Write("User:         " + Environment.UserName + Environment.NewLine);
                    wr.Write("PC Name:      " + Environment.MachineName + Environment.NewLine);
                    wr.Write("OS Version:   " + Environment.OSVersion + Environment.NewLine + Environment.NewLine + Environment.NewLine);
                    wr.Write("          *** Password's ***" + Environment.NewLine);
                    wr.Write(textBox2.Text);
                    wr.Close();
                    Application.Exit();
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)          // сохранить как (сохраняет сганирированные пароли в файл)
        {
            if (textBox2.Text == "")
            {
                MessageBox.Show("Не создано ни одного пароля!");
            }
            else
            {
                SaveFileDialog save_password = new SaveFileDialog();

                save_password.FileName = Environment.UserName + "_password.txt";
                save_password.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

                if (save_password.ShowDialog() == DialogResult.OK)
                {
                    System.IO.StreamWriter wr = new System.IO.StreamWriter(save_password.FileName);
                    wr.Write("Data & Time:  " + System.DateTimeOffset.Now + " UTC" + Environment.NewLine + Environment.NewLine);
                    wr.Write("User:         " + Environment.UserName + Environment.NewLine);
                    wr.Write("PC Name:      " + Environment.MachineName + Environment.NewLine);
                    wr.Write("OS Version:   " + Environment.OSVersion + Environment.NewLine + Environment.NewLine + Environment.NewLine);
                    wr.Write("          *** Password's ***" + Environment.NewLine);
                    wr.Write(textBox2.Text);
                    wr.Close();
                }
                else { }
            }
        }

        private void button4_Click(object sender, EventArgs e)      // сохранение паролей в файл, файл по умолчанию(диск c:\\)
        {

            System.IO.StreamWriter wr = new System.IO.StreamWriter(@"C:\" + Environment.UserName + "_password.txt");

            if (button4.Enabled == true)
            {
                wr.Write("Data & Time:  " + System.DateTimeOffset.Now + " UTC" + Environment.NewLine + Environment.NewLine);
                wr.Write("User:         " + Environment.UserName + Environment.NewLine);
                wr.Write("PC Name:      " + Environment.MachineName + Environment.NewLine);
                wr.Write("OS Version:   " + Environment.OSVersion + Environment.NewLine + Environment.NewLine + Environment.NewLine);
                wr.Write("          *** Password's ***" + Environment.NewLine);
                wr.Write(textBox2.Text);
                wr.Close();
                if (wr != null)
                {
                    wr.Close();
                    MessageBox.Show("Данные успешно записаны!\nФайл находиться на диске C:\\username_password.txt");
                }
                else { }
            }
            else { }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Версия приложения: v3.3.3");
        }   // версия приложенния
        private void историяОбновленийToolStripMenuItem_Click(object sender, EventArgs e)
        {

            MessageBox.Show(
                $"История обновлений:\n\nv1.0.0 - Создано окно (09.02.2016)\nv1.0.1 - Добавлена панель меню (файл, настройки, о приложении)\nv1.0.2 - Генерация цифрового пароля по кнопке Generation\nv1.0.3 - Добавлена генерация пароля цифро-буквенного с выводом в окошко\nv2.0.0 - Генерация паролей c кракозябрами\nv2.1.0 - Добавлена кнопка copy и clear\nv3.0.0 - Весь базовый функционал\nv3.1.0 - Добавлена иконка приложения(а также в трее). Добавлены цифры\nv3.2.0 - Подсветка пароля цветом (зависит от сложности)\nv3.3.2 - Добавлена возможность выводы сгенерированных паролей в файл\nv3.3.3 - Исправленые мелкие баги");
        }

        public void button1_Click(object sender, EventArgs e)              // кнопка генерации
        {
            if (checkBox1.Checked == true || checkBox2.Checked == true || checkBox3.Checked == true || checkBox4.Checked == true)
            {
                if (track_bar_password_lengh.Value == 4)     // если по дефлдту длина пароля 4 фон сразу красный
                {
                    textBox1.BackColor = Color.Red;
                }
                else { }

                char s;
                char[] liter_full = new char[] { '!', '@', '#', '$', '%', '&', '(', ')', '[', ']', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
                char[] liter_m = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };   // 26
                char[] liter_b = new char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };   // 26
                char[] liter_c = new char[] { '!', '@', '#', '$', '%', '&', '(', ')', '[', ']' };   // 10
                char[] liter_m_b = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };   // 52
                char[] liter_m_c = new char[] { '!', '@', '#', '$', '%', '&', '(', ')', '[', ']', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };   // 26
                char[] liter_b_c = new char[] { '!', '@', '#', '$', '%', '&', '(', ')', '[', ']', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };   // 26
                char[] liter_n = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
                char[] liter_c_n = new char[] { '!', '@', '#', '$', '%', '&', '(', ')', '[', ']', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };   // 20
                char[] liter_m_n = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };   // 26
                char[] liter_b_n = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };   // 26
                char[] liter_m_b_c = new char[] { '!', '@', '#', '$', '%', '&', '(', ')', '[', ']', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };   // 52
                char[] liter_m_b_n = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };   // 52
                char[] liter_m_c_n = new char[] { '!', '@', '#', '$', '%', '&', '(', ')', '[', ']', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };   // 26
                char[] liter_b_c_n = new char[] { '!', '@', '#', '$', '%', '&', '(', ')', '[', ']', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };   // 26

                Random rnd = new Random();

                int N;
                N = (int)track_bar_password_lengh.Value;


                if (checkBox2.Checked == true && checkBox1.Checked == false && checkBox3.Checked == false && checkBox4.Checked == false)     // маленькие
                {
                    textBox1.Clear();
                    for (int i = 0; i < N; i++)
                    {
                        s = liter_m[rnd.Next(26)];
                        textBox1.Text += (s);
                    }
                    textBox2.Text += textBox1.Text + Environment.NewLine;
                }
                else { }

                if (checkBox2.Checked == false && checkBox1.Checked == true && checkBox3.Checked == false && checkBox4.Checked == false)    // большие
                {
                    textBox1.Clear();
                    for (int i = 0; i < N; i++)
                    {
                        s = liter_b[rnd.Next(26)];
                        textBox1.Text += (s);
                    }
                    textBox2.Text += textBox1.Text + Environment.NewLine;
                }
                else { }

                if (checkBox2.Checked == false && checkBox1.Checked == false && checkBox3.Checked == true && checkBox4.Checked == false)    // кракозябры
                {
                    textBox1.Clear();
                    for (int i = 0; i < N; i++)
                    {
                        s = liter_c[rnd.Next(10)];
                        textBox1.Text += (s);
                    }
                    textBox2.Text += textBox1.Text + Environment.NewLine;
                }
                else { }

                if (checkBox2.Checked == false && checkBox1.Checked == false && checkBox3.Checked == false && checkBox4.Checked == true)    // цифры
                {
                    textBox1.Clear();
                    for (int i = 0; i < N; i++)
                    {
                        s = liter_n[rnd.Next(10)];
                        textBox1.Text += (s);
                    }
                    textBox2.Text += textBox1.Text + Environment.NewLine;
                }
                else { }

                if (checkBox2.Checked == true && checkBox1.Checked == true && checkBox3.Checked == false && checkBox4.Checked == false)     // маленькие большие
                {
                    textBox1.Clear();
                    for (int i = 0; i < N; i++)
                    {
                        s = liter_m_b[rnd.Next(52)];
                        textBox1.Text += (s);
                    }
                    textBox2.Text += textBox1.Text + Environment.NewLine;
                }
                else { }

                if (checkBox2.Checked == true && checkBox1.Checked == false && checkBox3.Checked == true && checkBox4.Checked == false)     // малекние кракозябры
                {
                    textBox1.Clear();
                    for (int i = 0; i < N; i++)
                    {
                        s = liter_m_c[rnd.Next(36)];
                        textBox1.Text += (s);
                    }
                    textBox2.Text += textBox1.Text + Environment.NewLine;
                }
                else { }

                if (checkBox2.Checked == true && checkBox1.Checked == false && checkBox3.Checked == false && checkBox4.Checked == true)     // малекние цифры
                {
                    textBox1.Clear();
                    for (int i = 0; i < N; i++)
                    {
                        s = liter_m_n[rnd.Next(36)];
                        textBox1.Text += (s);
                    }
                    textBox2.Text += textBox1.Text + Environment.NewLine;
                }
                else { }
                if (checkBox2.Checked == false && checkBox1.Checked == true && checkBox3.Checked == false && checkBox4.Checked == true)     // большие цифры
                {
                    textBox1.Clear();
                    for (int i = 0; i < N; i++)
                    {
                        s = liter_b_n[rnd.Next(36)];
                        textBox1.Text += (s);
                    }
                    textBox2.Text += textBox1.Text + Environment.NewLine;
                }
                else { }

                if (checkBox2.Checked == false && checkBox1.Checked == true && checkBox3.Checked == true && checkBox4.Checked == false)     // большие кракозябры
                {
                    textBox1.Clear();
                    for (int i = 0; i < N; i++)
                    {
                        s = liter_b_c[rnd.Next(36)];
                        textBox1.Text += (s);
                    }
                    textBox2.Text += textBox1.Text + Environment.NewLine;
                }
                else { }

                if (checkBox2.Checked == true && checkBox1.Checked == true && checkBox3.Checked == true && checkBox4.Checked == false)     // маленькие большие кракозябры
                {
                    textBox1.Clear();
                    for (int i = 0; i < N; i++)
                    {
                        s = liter_m_b_c[rnd.Next(56)];
                        textBox1.Text += (s);
                    }
                    textBox2.Text += textBox1.Text + Environment.NewLine;
                }
                else { }

                if (checkBox2.Checked == true && checkBox1.Checked == true && checkBox3.Checked == false && checkBox4.Checked == true)     // маленькие большие цифры
                {
                    textBox1.Clear();
                    for (int i = 0; i < N; i++)
                    {
                        s = liter_m_b_n[rnd.Next(56)];
                        textBox1.Text += (s);
                    }
                    textBox2.Text += textBox1.Text + Environment.NewLine;
                }
                else { }

                if (checkBox2.Checked == true && checkBox1.Checked == false && checkBox3.Checked == true && checkBox4.Checked == true)     // маленькие кракозябры цифры
                {
                    textBox1.Clear();
                    for (int i = 0; i < N; i++)
                    {
                        s = liter_m_c_n[rnd.Next(46)];
                        textBox1.Text += (s);
                    }
                    textBox2.Text += textBox1.Text + Environment.NewLine;
                }
                else { }

                if (checkBox2.Checked == false && checkBox1.Checked == false && checkBox3.Checked == true && checkBox4.Checked == true)     // кракозябры цифры
                {
                    textBox1.Clear();
                    for (int i = 0; i < N; i++)
                    {
                        s = liter_c_n[rnd.Next(20)];
                        textBox1.Text += (s);
                    }
                    textBox2.Text += textBox1.Text + Environment.NewLine;
                }
                else { }

                if (checkBox2.Checked == false && checkBox1.Checked == true && checkBox3.Checked == true && checkBox4.Checked == true)      // большие кракозябры цифры
                {
                    textBox1.Clear();
                    for (int i = 0; i < N; i++)
                    {
                        s = liter_b_c_n[rnd.Next(46)];
                        textBox1.Text += (s);
                    }
                    textBox2.Text += textBox1.Text + Environment.NewLine;
                }
                else { }

                if (checkBox2.Checked == true && checkBox1.Checked == true && checkBox3.Checked == true && checkBox4.Checked == true)       // маленькие большие кракозябры цифры 
                {
                    textBox1.Clear();
                    for (int i = 0; i < N; i++)
                    {
                        s = liter_full[rnd.Next(72)];
                        textBox1.Text += (s);
                    }
                    textBox2.Text += textBox1.Text + Environment.NewLine;
                }
                else { }
            }
            else { MessageBox.Show("Выберите состав пароля!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }

        private void благодарностьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Хотелось бы поблагодарить моего друга fish, \n за помощь с графической составляющей приложения, \nа также за тестирование данного приложения");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.BackColor = Color.White;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.ToString() != "")
                Clipboard.SetText(textBox1.Text);
            else
                MessageBox.Show("Вы не можете скопировать пустое поле!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
        }

        private void ночнаяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.Gray;
            textBox1.BackColor = Color.Gray;
            textBox2.BackColor = Color.Gray;
        }

        private void дневнаяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            textBox1.BackColor = Color.WhiteSmoke;
            textBox2.BackColor = Color.WhiteSmoke;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (button5.Enabled == true)
                textBox2.Clear();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            button4.Enabled = true;
        }

        private void выходToolStripMenuItem1_Click(object sender, EventArgs e)      // файл -> выход
        {
            Application.Exit();
        }

        private void разработчикToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Vladimir Zhigalo ©. BSTU 2016 FIT SIT(Software Information Technology)");
        }

        private void OnClick(object sender, EventArgs e)        // информация об аккаунте пользователя
        {
            foreach(Form f in Application.OpenForms)            // не разрешаем открыть еще одну форму
            {
                if(f.Name == "account")
                {
                    MessageBox.Show("Форма уже открыта", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            account acc = new account();
            acc.Owner = this;
            acc.Show();
        }

        private void track_bar_password_lengh_Scroll(object sender, EventArgs e)        // ползунок для выбора длины создаваемого пароля
        {
            track_bar_password_lengh.Minimum = 4;
            track_bar_password_lengh.Maximum = 29;
            textBox3.Text = track_bar_password_lengh.Value.ToString();

            int N;
            N = (int)track_bar_password_lengh.Value;

            if (N >= 4 && N < 6)
            {
                textBox1.BackColor = Color.Red;
            }
            else { }
            if (N >= 6 && N < 8)
            {
                textBox1.BackColor = Color.Orange;
            }
            else { }
            if (N >= 8 && N <= 11)
            {
                textBox1.BackColor = Color.Olive;
            }
            else { }
            if (N >= 12 && N <= 29)
            {
                textBox1.BackColor = Color.Green;
            }
            else { }
        }

        private void MoveToDBPasswords_Click(object sender, EventArgs e)        // окрывает форму с базой паролей пользователя. Проедоставляет возможность авторизации на ращличных ресурсах
        {
            foreach (Form f in Application.OpenForms)            // не разрешаем открыть еще одну форму
            {
                if (f.Name == "DB_password_form")
                {
                    MessageBox.Show("Форма уже открыта", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            DB_password_form dbpf = new DB_password_form();
            dbpf.Owner = this;
            dbpf.Show();
        }
    }
}
