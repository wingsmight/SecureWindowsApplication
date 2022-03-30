
namespace SecureApplication
{
    partial class Registration
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
            this.label1 = new System.Windows.Forms.Label();
            this.login_textBox = new System.Windows.Forms.TextBox();
            this.password_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.passwordVer_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.captcha = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.error = new System.Windows.Forms.Label();
            this.reg_button = new System.Windows.Forms.Button();
            this.userlevel_combobox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Логин:";
            // 
            // login_textBox
            // 
            this.login_textBox.Location = new System.Drawing.Point(162, 5);
            this.login_textBox.Name = "login_textBox";
            this.login_textBox.Size = new System.Drawing.Size(199, 20);
            this.login_textBox.TabIndex = 1;
            // 
            // password_textBox
            // 
            this.password_textBox.Location = new System.Drawing.Point(162, 31);
            this.password_textBox.Name = "password_textBox";
            this.password_textBox.Size = new System.Drawing.Size(199, 20);
            this.password_textBox.TabIndex = 3;
            this.password_textBox.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Пароль:";
            // 
            // passwordVer_textBox
            // 
            this.passwordVer_textBox.Location = new System.Drawing.Point(162, 57);
            this.passwordVer_textBox.Name = "passwordVer_textBox";
            this.passwordVer_textBox.Size = new System.Drawing.Size(199, 20);
            this.passwordVer_textBox.TabIndex = 5;
            this.passwordVer_textBox.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Подтверждение пароля:";
            // 
            // captcha
            // 
            this.captcha.Location = new System.Drawing.Point(162, 109);
            this.captcha.Name = "captcha";
            this.captcha.Size = new System.Drawing.Size(199, 20);
            this.captcha.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 26);
            this.label5.TabIndex = 6;
            this.label5.Text = "Введите сумму\r\nс картинки";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Уровень прав:";
            this.label4.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(103, 113);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 16);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(132, 113);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 16);
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // error
            // 
            this.error.Location = new System.Drawing.Point(162, 147);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(199, 32);
            this.error.TabIndex = 12;
            this.error.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // reg_button
            // 
            this.reg_button.Location = new System.Drawing.Point(162, 182);
            this.reg_button.Name = "reg_button";
            this.reg_button.Size = new System.Drawing.Size(193, 28);
            this.reg_button.TabIndex = 13;
            this.reg_button.Text = "Зарегистрироваться";
            this.reg_button.UseVisualStyleBackColor = true;
            this.reg_button.Click += new System.EventHandler(this.reg_button_Click);
            // 
            // userlevel_combobox
            // 
            this.userlevel_combobox.FormattingEnabled = true;
            this.userlevel_combobox.Items.AddRange(new object[] {
            "Администратор",
            "Менеджер",
            "Пользователь"});
            this.userlevel_combobox.Location = new System.Drawing.Point(162, 82);
            this.userlevel_combobox.Name = "userlevel_combobox";
            this.userlevel_combobox.Size = new System.Drawing.Size(199, 21);
            this.userlevel_combobox.TabIndex = 14;
            this.userlevel_combobox.Visible = false;
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 220);
            this.Controls.Add(this.userlevel_combobox);
            this.Controls.Add(this.reg_button);
            this.Controls.Add(this.error);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.captcha);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.passwordVer_textBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.password_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.login_textBox);
            this.Controls.Add(this.label1);
            this.Name = "Registration";
            this.Text = "Регистрация";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox login_textBox;
        private System.Windows.Forms.TextBox password_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox passwordVer_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox captcha;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label error;
        private System.Windows.Forms.Button reg_button;
        private System.Windows.Forms.ComboBox userlevel_combobox;
    }
}