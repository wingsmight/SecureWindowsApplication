using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecureApplication
{
    public partial class AddReview : Form
    {
        private string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source='E:\Users\Дмитрий\Desktop\Desktop\Учеба\4 курс\8 семестр\Информационная безопасность\lab4_IB\lab4_IB\bin\Release\db.accdb';Persist Security Info=True";
        private OleDbConnection myOleDbConnection;
        private string username;
        public bool addFlag = false;


        public AddReview(string user)
        {
            username = user;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                myOleDbConnection = new OleDbConnection(connectionString);
                myOleDbConnection.Open();

                OleDbCommand myOleDbCommand = new OleDbCommand("SELECT count(*) FROM reviews", myOleDbConnection);

                //OleDbDataReader reader = myOleDbCommand.ExecuteNonQuery();
                int id = Convert.ToInt32(myOleDbCommand.ExecuteScalar());


                myOleDbCommand = new OleDbCommand("INSERT INTO reviews values(?,?,?,?,?)", myOleDbConnection);
                myOleDbCommand.Parameters.Add("@id", OleDbType.Integer).Value = id;
                myOleDbCommand.Parameters.Add("@name", OleDbType.VarChar).Value = username;
                myOleDbCommand.Parameters.Add("@rating", OleDbType.VarChar).Value = rating.Text.ToString();
                myOleDbCommand.Parameters.Add("@review", OleDbType.VarChar).Value = reviewText.Text.ToString();
                myOleDbCommand.Parameters.Add("@product", OleDbType.VarChar).Value = product.Text.ToString();

                if (myOleDbCommand.ExecuteNonQuery() > 0)
                {
                    addFlag = true;
                    this.Close();
                }
                myOleDbConnection.Close();

            }
            catch (Exception ex)
            {
                //error.Text = ex.ToString();
                addFlag = false;
                MessageBox.Show(ex.ToString());
                myOleDbConnection.Close();
            }

        }
    }
}
