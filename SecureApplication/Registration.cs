using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecureApplication
{
    public partial class Registration : Form
    {
        private string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source='C:\Users\i.kondratev.2018\Desktop\db.accdb';Persist Security Info=True";
        private OleDbConnection myOleDbConnection;
        public bool regFlag = false;
        private bool isAdmin = false;
        private int userType = -1;
        private int capt1, capt2;


        public Registration(int userType)
        {
            InitializeComponent();
            if (userType == 0)
            {
                isAdmin = true;
                userlevel_combobox.Visible = true;
                label4.Visible = true;
            }
            myOleDbConnection = new OleDbConnection(connectionString);
            createCaptcha();
            //userlevel_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        }


        private Image DrawText(String text, Font font, Color textColor, Color backColor)
        {
            Image img = new Bitmap(1, 1);
            Graphics drawing = Graphics.FromImage(img);
            SizeF textSize = drawing.MeasureString(text, font);

            img.Dispose();
            drawing.Dispose();

            img = new Bitmap((int)textSize.Width, (int)textSize.Height);
            drawing = Graphics.FromImage(img);
            drawing.Clear(backColor);
            Brush textBrush = new SolidBrush(textColor);
            drawing.DrawString(text, font, textBrush, 0, 0);
            drawing.Save();

            textBrush.Dispose();
            drawing.Dispose();

            return img;
        }


        private void createCaptcha()
        {
            Random rnd = new Random();
            capt1 = rnd.Next(1, 50);
            capt2 = rnd.Next(1, 50);
            captcha.Text = "";
            pictureBox1.Image = DrawText(capt1.ToString(), new Font(FontFamily.GenericSansSerif, 8.25F, label1.Font.Style), Color.Black, Color.White);
            pictureBox2.Image = DrawText(capt2.ToString(), new Font(FontFamily.GenericSansSerif, 8.25F, label1.Font.Style), Color.Black, Color.White);
        }
        private void reg_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (login_textBox.Text == "" || password_textBox.Text == "")
                {
                    error.Text = "Заполнены не все поля";
                    return;
                }
                if (login_textBox.Text.Length < 4)
                {
                    error.Text = "Слишком короткий логин";
                    return;
                }
                if (password_textBox.Text.Length < 4)
                {
                    error.Text = "Слишком короткий пароль";
                    return;
                }
                if (password_textBox.Text != passwordVer_textBox.Text)
                {
                    error.Text = "Неверно введено подтверждение пароля";
                    return;
                }
                if (Convert.ToInt32(captcha.Text) != capt1 + capt2)
                {
                    error.Text = "Неверно введена CAPTCHA";
                    createCaptcha();
                    return;
                }
                if (userlevel_combobox.Text == "")
                    userType = 2;
                else
                    userType = userlevel_combobox.SelectedIndex;

                OleDbCommand myOleDbCommand = new OleDbCommand("SELECT * FROM users where name = ?", myOleDbConnection);
                myOleDbCommand.Parameters.Add("@login", OleDbType.VarChar).Value = login_textBox.Text.ToString();

                myOleDbConnection.Open();
                OleDbDataReader reader = myOleDbCommand.ExecuteReader();

                if (reader.Read())
                {
                    error.Text = "Пользователь с таким именем уже существует";
                    return;
                }
                reader.Close();

                myOleDbCommand = new OleDbCommand("SELECT count(*) FROM users", myOleDbConnection);
                int id = Convert.ToInt32(myOleDbCommand.ExecuteScalar());

                myOleDbCommand = new OleDbCommand("INSERT INTO users values(?,?,?,?)", myOleDbConnection);
                myOleDbCommand.Parameters.Add("@id", OleDbType.Integer).Value = id;
                myOleDbCommand.Parameters.Add("@name", OleDbType.VarChar).Value = login_textBox.Text.ToString();
                myOleDbCommand.Parameters.Add("@password", OleDbType.VarChar).Value = md5(password_textBox.Text.ToString());
                myOleDbCommand.Parameters.Add("@type", OleDbType.VarChar).Value = userType.ToString();

                if (myOleDbCommand.ExecuteNonQuery() > 0)
                {
                    regFlag = true;
                    this.Close();
                }
                myOleDbConnection.Close();

            }
            catch (Exception ex)
            {
                //error.Text = ex.ToString();
                MessageBox.Show(ex.ToString());
                myOleDbConnection.Close();
            }
        }
        private string md5(string value)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] checkSum = md5.ComputeHash(Encoding.UTF8.GetBytes(value));
            string result = BitConverter.ToString(checkSum).Replace("-", String.Empty);
            return result;
        }
    }
}
