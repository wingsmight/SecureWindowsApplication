
namespace SecureApplication
{
    partial class Front
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
            this.userNameLabel = new System.Windows.Forms.Label();
            this.typeUserLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.users = new System.Windows.Forms.DataGridView();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.User = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rating = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Review = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.add = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.reg_button = new System.Windows.Forms.Button();
            this.authorization_button = new System.Windows.Forms.Button();
            this.error = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.users)).BeginInit();
            this.SuspendLayout();
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Location = new System.Drawing.Point(13, 13);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(106, 13);
            this.userNameLabel.TabIndex = 0;
            this.userNameLabel.Text = "Имя пользователя:";
            // 
            // typeUserLabel
            // 
            this.typeUserLabel.AutoSize = true;
            this.typeUserLabel.Location = new System.Drawing.Point(16, 30);
            this.typeUserLabel.Name = "typeUserLabel";
            this.typeUserLabel.Size = new System.Drawing.Size(42, 13);
            this.typeUserLabel.TabIndex = 1;
            this.typeUserLabel.Text = "Права:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(444, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Пользователи";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // users
            // 
            this.users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.users.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Number,
            this.User,
            this.Rating,
            this.Review,
            this.Product});
            this.users.Location = new System.Drawing.Point(13, 47);
            this.users.Name = "users";
            this.users.Size = new System.Drawing.Size(573, 236);
            this.users.TabIndex = 3;
            // 
            // Number
            // 
            this.Number.HeaderText = "Номер";
            this.Number.Name = "Number";
            // 
            // User
            // 
            this.User.HeaderText = "Пользователь";
            this.User.Name = "User";
            // 
            // Rating
            // 
            this.Rating.HeaderText = "Рейтинг";
            this.Rating.Name = "Rating";
            // 
            // Review
            // 
            this.Review.HeaderText = "Отзыв";
            this.Review.Name = "Review";
            // 
            // Product
            // 
            this.Product.HeaderText = "Товар";
            this.Product.Name = "Product";
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(13, 318);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(137, 23);
            this.add.TabIndex = 4;
            this.add.Text = "Добавить отзыв";
            this.add.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(156, 318);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(104, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // reg_button
            // 
            this.reg_button.Location = new System.Drawing.Point(351, 318);
            this.reg_button.Name = "reg_button";
            this.reg_button.Size = new System.Drawing.Size(129, 23);
            this.reg_button.TabIndex = 6;
            this.reg_button.Text = "Зарегистрировать";
            this.reg_button.UseVisualStyleBackColor = true;
            // 
            // authorization_button
            // 
            this.authorization_button.Location = new System.Drawing.Point(486, 318);
            this.authorization_button.Name = "authorization_button";
            this.authorization_button.Size = new System.Drawing.Size(100, 23);
            this.authorization_button.TabIndex = 7;
            this.authorization_button.Text = "Выйти";
            this.authorization_button.UseVisualStyleBackColor = true;
            // 
            // error
            // 
            this.error.Location = new System.Drawing.Point(13, 292);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(573, 23);
            this.error.TabIndex = 8;
            // 
            // Front
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 353);
            this.Controls.Add(this.error);
            this.Controls.Add(this.authorization_button);
            this.Controls.Add(this.reg_button);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.add);
            this.Controls.Add(this.users);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.typeUserLabel);
            this.Controls.Add(this.userNameLabel);
            this.Name = "Front";
            this.Text = "Программа";
            ((System.ComponentModel.ISupportInitialize)(this.users)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.Label typeUserLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView users;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn User;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rating;
        private System.Windows.Forms.DataGridViewTextBoxColumn Review;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button reg_button;
        private System.Windows.Forms.Button authorization_button;
        private System.Windows.Forms.Label error;
    }
}