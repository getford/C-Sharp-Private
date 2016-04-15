﻿namespace WindowsFormsApplication1
{
    partial class DB_password_form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DB_password_form));
            this.textBox_name_site = new System.Windows.Forms.TextBox();
            this.textBox_URL_site = new System.Windows.Forms.TextBox();
            this.textBox_login_site = new System.Windows.Forms.TextBox();
            this.textBox_password_site = new System.Windows.Forms.TextBox();
            this.button_authorization_site = new System.Windows.Forms.Button();
            this.button_register = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.qqqBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database_siteDataSet = new WindowsFormsApplication1.Database_siteDataSet();
            this.qqqTableAdapter = new WindowsFormsApplication1.Database_siteDataSetTableAdapters.qqqTableAdapter();
            this.Label_user_login_now = new System.Windows.Forms.Label();
            this.textBox_user_login_now = new System.Windows.Forms.TextBox();
            this.button_clear = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.groupBox_textboxes = new System.Windows.Forms.GroupBox();
            this.groupBox_buttons = new System.Windows.Forms.GroupBox();
            this.listView_site_login_password = new System.Windows.Forms.ListView();
            this.monthCalendar_valid_time = new System.Windows.Forms.MonthCalendar();
            this.Name_site = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.URL_site = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Login_site = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password_site = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qqqBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database_siteDataSet)).BeginInit();
            this.groupBox_textboxes.SuspendLayout();
            this.groupBox_buttons.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_name_site
            // 
            this.textBox_name_site.Location = new System.Drawing.Point(6, 19);
            this.textBox_name_site.Name = "textBox_name_site";
            this.textBox_name_site.Size = new System.Drawing.Size(279, 20);
            this.textBox_name_site.TabIndex = 1;
            // 
            // textBox_URL_site
            // 
            this.textBox_URL_site.Location = new System.Drawing.Point(6, 45);
            this.textBox_URL_site.Name = "textBox_URL_site";
            this.textBox_URL_site.Size = new System.Drawing.Size(279, 20);
            this.textBox_URL_site.TabIndex = 2;
            // 
            // textBox_login_site
            // 
            this.textBox_login_site.Location = new System.Drawing.Point(6, 71);
            this.textBox_login_site.Name = "textBox_login_site";
            this.textBox_login_site.Size = new System.Drawing.Size(279, 20);
            this.textBox_login_site.TabIndex = 3;
            // 
            // textBox_password_site
            // 
            this.textBox_password_site.Location = new System.Drawing.Point(6, 97);
            this.textBox_password_site.Name = "textBox_password_site";
            this.textBox_password_site.Size = new System.Drawing.Size(279, 20);
            this.textBox_password_site.TabIndex = 4;
            // 
            // button_authorization_site
            // 
            this.button_authorization_site.Location = new System.Drawing.Point(52, 14);
            this.button_authorization_site.Name = "button_authorization_site";
            this.button_authorization_site.Size = new System.Drawing.Size(185, 23);
            this.button_authorization_site.TabIndex = 5;
            this.button_authorization_site.Text = "Авторизация";
            this.button_authorization_site.UseVisualStyleBackColor = true;
            this.button_authorization_site.Click += new System.EventHandler(this.button_authorization_site_Click);
            // 
            // button_register
            // 
            this.button_register.Location = new System.Drawing.Point(52, 43);
            this.button_register.Name = "button_register";
            this.button_register.Size = new System.Drawing.Size(185, 23);
            this.button_register.TabIndex = 6;
            this.button_register.Text = "Записать в бд";
            this.button_register.UseVisualStyleBackColor = true;
            this.button_register.Click += new System.EventHandler(this.button_register_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name_site,
            this.URL_site,
            this.Login_site,
            this.Password_site});
            this.dataGridView1.DataSource = this.qqqBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(535, 450);
            this.dataGridView1.TabIndex = 0;
            // 
            // qqqBindingSource
            // 
            this.qqqBindingSource.DataMember = "qqq";
            this.qqqBindingSource.DataSource = this.database_siteDataSet;
            // 
            // database_siteDataSet
            // 
            this.database_siteDataSet.DataSetName = "Database_siteDataSet";
            this.database_siteDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // qqqTableAdapter
            // 
            this.qqqTableAdapter.ClearBeforeFill = true;
            // 
            // Label_user_login_now
            // 
            this.Label_user_login_now.AutoSize = true;
            this.Label_user_login_now.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_user_login_now.ForeColor = System.Drawing.Color.Black;
            this.Label_user_login_now.Location = new System.Drawing.Point(12, 474);
            this.Label_user_login_now.Name = "Label_user_login_now";
            this.Label_user_login_now.Size = new System.Drawing.Size(195, 18);
            this.Label_user_login_now.TabIndex = 7;
            this.Label_user_login_now.Text = "Вы вошли под именем: ";
            // 
            // textBox_user_login_now
            // 
            this.textBox_user_login_now.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_user_login_now.Cursor = System.Windows.Forms.Cursors.No;
            this.textBox_user_login_now.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.textBox_user_login_now.ForeColor = System.Drawing.Color.Yellow;
            this.textBox_user_login_now.Location = new System.Drawing.Point(213, 468);
            this.textBox_user_login_now.Multiline = true;
            this.textBox_user_login_now.Name = "textBox_user_login_now";
            this.textBox_user_login_now.ReadOnly = true;
            this.textBox_user_login_now.ShortcutsEnabled = false;
            this.textBox_user_login_now.Size = new System.Drawing.Size(178, 26);
            this.textBox_user_login_now.TabIndex = 8;
            this.textBox_user_login_now.TabStop = false;
            this.textBox_user_login_now.Click += new System.EventHandler(this.OnClick);
            // 
            // button_clear
            // 
            this.button_clear.Location = new System.Drawing.Point(52, 72);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(185, 23);
            this.button_clear.TabIndex = 9;
            this.button_clear.Text = "Очистить поля";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(52, 101);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(185, 23);
            this.button_delete.TabIndex = 10;
            this.button_delete.Text = "Удалить запись";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // groupBox_textboxes
            // 
            this.groupBox_textboxes.Controls.Add(this.textBox_name_site);
            this.groupBox_textboxes.Controls.Add(this.textBox_URL_site);
            this.groupBox_textboxes.Controls.Add(this.textBox_login_site);
            this.groupBox_textboxes.Controls.Add(this.textBox_password_site);
            this.groupBox_textboxes.Location = new System.Drawing.Point(586, 12);
            this.groupBox_textboxes.Name = "groupBox_textboxes";
            this.groupBox_textboxes.Size = new System.Drawing.Size(291, 149);
            this.groupBox_textboxes.TabIndex = 11;
            this.groupBox_textboxes.TabStop = false;
            // 
            // groupBox_buttons
            // 
            this.groupBox_buttons.Controls.Add(this.button_register);
            this.groupBox_buttons.Controls.Add(this.button_authorization_site);
            this.groupBox_buttons.Controls.Add(this.button_delete);
            this.groupBox_buttons.Controls.Add(this.button_clear);
            this.groupBox_buttons.Location = new System.Drawing.Point(586, 167);
            this.groupBox_buttons.Name = "groupBox_buttons";
            this.groupBox_buttons.Size = new System.Drawing.Size(291, 136);
            this.groupBox_buttons.TabIndex = 12;
            this.groupBox_buttons.TabStop = false;
            // 
            // listView_site_login_password
            // 
            this.listView_site_login_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView_site_login_password.Location = new System.Drawing.Point(910, 12);
            this.listView_site_login_password.Name = "listView_site_login_password";
            this.listView_site_login_password.Size = new System.Drawing.Size(430, 438);
            this.listView_site_login_password.TabIndex = 13;
            this.listView_site_login_password.UseCompatibleStateImageBehavior = false;
            // 
            // monthCalendar_valid_time
            // 
            this.monthCalendar_valid_time.Location = new System.Drawing.Point(592, 315);
            this.monthCalendar_valid_time.Name = "monthCalendar_valid_time";
            this.monthCalendar_valid_time.TabIndex = 14;
            this.monthCalendar_valid_time.TabStop = false;
            // 
            // Name_site
            // 
            this.Name_site.DataPropertyName = "Name_site";
            this.Name_site.HeaderText = "Name_site";
            this.Name_site.Name = "Name_site";
            // 
            // URL_site
            // 
            this.URL_site.DataPropertyName = "URL_site";
            this.URL_site.HeaderText = "URL_site";
            this.URL_site.Name = "URL_site";
            // 
            // Login_site
            // 
            this.Login_site.DataPropertyName = "Login_site";
            this.Login_site.HeaderText = "Login_site";
            this.Login_site.Name = "Login_site";
            // 
            // Password_site
            // 
            this.Password_site.DataPropertyName = "Password_site";
            this.Password_site.HeaderText = "Password_site";
            this.Password_site.Name = "Password_site";
            this.Password_site.ReadOnly = true;
            // 
            // DB_password_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1468, 599);
            this.Controls.Add(this.monthCalendar_valid_time);
            this.Controls.Add(this.listView_site_login_password);
            this.Controls.Add(this.groupBox_buttons);
            this.Controls.Add(this.groupBox_textboxes);
            this.Controls.Add(this.textBox_user_login_now);
            this.Controls.Add(this.Label_user_login_now);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DB_password_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ваша база паролей";
            this.Load += new System.EventHandler(this.DB_password_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qqqBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database_siteDataSet)).EndInit();
            this.groupBox_textboxes.ResumeLayout(false);
            this.groupBox_textboxes.PerformLayout();
            this.groupBox_buttons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Database_siteDataSet database_siteDataSet;
        private System.Windows.Forms.BindingSource qqqBindingSource;
        private Database_siteDataSetTableAdapters.qqqTableAdapter qqqTableAdapter;
        private System.Windows.Forms.TextBox textBox_name_site;
        private System.Windows.Forms.TextBox textBox_URL_site;
        private System.Windows.Forms.TextBox textBox_login_site;
        private System.Windows.Forms.TextBox textBox_password_site;
        private System.Windows.Forms.Button button_authorization_site;
        private System.Windows.Forms.Button button_register;
        private System.Windows.Forms.Label Label_user_login_now;
        public System.Windows.Forms.TextBox textBox_user_login_now;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.GroupBox groupBox_textboxes;
        private System.Windows.Forms.GroupBox groupBox_buttons;
        private System.Windows.Forms.ListView listView_site_login_password;
        private System.Windows.Forms.MonthCalendar monthCalendar_valid_time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name_site;
        private System.Windows.Forms.DataGridViewTextBoxColumn URL_site;
        private System.Windows.Forms.DataGridViewTextBoxColumn Login_site;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password_site;
    }
}