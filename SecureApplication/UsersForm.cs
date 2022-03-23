using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecureApplication
{
    public partial class UsersForm : Form
    {
        public UsersForm()
        {
            InitializeComponent();
        }


        private void UsersForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbDataSet.users". При необходимости она может быть перемещена или удалена.
            // this.usersTableAdapter.Fill(this.dbDataSet.users);
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                if (Convert.ToInt32(dataGridView1[3, i].Value) == 0)
                    dataGridView1[2, i].Value = "Администратор";
                if (Convert.ToInt32(dataGridView1[3, i].Value) == 1)
                    dataGridView1[2, i].Value = "Менеджер";
                if (Convert.ToInt32(dataGridView1[3, i].Value) == 2)
                    dataGridView1[2, i].Value = "Пользователь";

            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    if (dataGridView1[2, i].Value.ToString() == "Администратор")
                        dataGridView1[3, i].Value = 0;
                    if (dataGridView1[2, i].Value.ToString() == "Менеджер")
                        dataGridView1[3, i].Value = 1;
                    if (dataGridView1[2, i].Value.ToString() == "Пользователь")
                        dataGridView1[3, i].Value = 2;
                }
                // this.usersTableAdapter.Update(this.dbDataSet.users);
                error.Text = "Данные сохранены";
            }
            catch
            {
                error.Text = "ошибка сохранения данных";
            }
        }
        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
