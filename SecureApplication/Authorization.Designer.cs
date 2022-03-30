
namespace SecureApplication
{
    partial class Authorization
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
            this.login = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.error = new System.Windows.Forms.Label();
            this.signin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Логин:";
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(16, 30);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(247, 20);
            this.login.TabIndex = 1;
            this.login.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Authorization_KeyDown);
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(16, 75);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(247, 20);
            this.password.TabIndex = 3;
            this.password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Authorization_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Пароль:";
            // 
            // error
            // 
            this.error.Location = new System.Drawing.Point(16, 102);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(247, 16);
            this.error.TabIndex = 4;
            this.error.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // signin
            // 
            this.signin.Location = new System.Drawing.Point(61, 130);
            this.signin.Name = "signin";
            this.signin.Size = new System.Drawing.Size(150, 23);
            this.signin.TabIndex = 5;
            this.signin.Text = "Войти";
            this.signin.UseVisualStyleBackColor = true;
            this.signin.Click += new System.EventHandler(this.signin_Click);
            // 
            // Authorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 165);
            this.Controls.Add(this.signin);
            this.Controls.Add(this.error);
            this.Controls.Add(this.password);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.login);
            this.Controls.Add(this.label1);
            this.Name = "Authorization";
            this.Text = "Авторизация";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Authorization_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox login;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label error;
        private System.Windows.Forms.Button signin;
    }
}