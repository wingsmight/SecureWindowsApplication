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
    public partial class Authorization : Form
    {
        private string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source='C:\Users\i.kondratev.2018\Desktop\db.accdb';Persist Security Info=True";
        private OleDbConnection myOleDbConnection;
        public string userName = "";
        public int userType = -1;


        public Authorization()
        {
            InitializeComponent();
            myOleDbConnection = new OleDbConnection(connectionString);
        }


        private void signin_Click(object sender, EventArgs e)
        {
            try
            {
                if (password.Text.Length > 10 || login.Text.Length > 10)
                {
                    error.Text = "Слишком длинный логин или пароль";
                    return;
                }

                OleDbCommand myOleDbCommand = new OleDbCommand("SELECT * FROM users where name = ?", myOleDbConnection);
                myOleDbCommand.Parameters.Add("@login", OleDbType.VarChar).Value = login.Text.ToString();

                myOleDbConnection.Open();
                OleDbDataReader reader = myOleDbCommand.ExecuteReader();

                string hashPass = md5(password.Text.ToString());

                if (reader.Read())
                {
                    var pass = reader.GetString(2);
                    if (pass == hashPass)
                    {
                        userName = login.Text.ToString();
                        userType = Convert.ToInt32(reader.GetString(3));
                        this.Close();
                    }
                    else
                    {
                        error.Text = "Неверный логин или пароль";
                    }
                }
                else
                {
                    error.Text = "Неверный логин или пароль";
                }
                reader.Close();
                myOleDbConnection.Close();
            }
            catch (Exception ex)
            {
                error.Text = ex.ToString();
            }
        }

        private string md5(string value)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] checkSum = md5.ComputeHash(Encoding.UTF8.GetBytes(value));
            string result = BitConverter.ToString(checkSum).Replace("-", String.Empty);
            return result;
        }

        private void Authorization_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                signin_Click(sender, e);
        }
    }
}
