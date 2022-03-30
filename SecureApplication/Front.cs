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
    public partial class Front : Form
    {
        public bool authFlag = false;
        public string userName = "";
        public int userType = -1;
        private string[] types = { "Администратор", "Менеджер", "Пользователь" };


        public Front()
        {
            InitializeComponent();
        }


        private void authorization_button_Click(object sender, EventArgs e)
        {
            if (!authFlag)
            {
                Authorization auth = new Authorization();
                auth.ShowDialog();
                if (!String.IsNullOrEmpty(auth.userName))
                {
                    this.userName = auth.userName;
                    this.userType = auth.userType;
                    authFlag = true;
                    userNameLabel.Text = "Имя пользователя: " + userName;
                    typeUserLabel.Text = "Права: " + types[userType];
                    authorization_button.Text = "Выйти";

                    if (userType == 0)
                    {
                        users.Visible = true;
                        reg_button.Visible = true;
                        btnSave.Visible = true;
                        reg_button.Text = "Зарегистрировать";
                    }
                    else if (userType == 1)
                    {
                        users.Visible = false;
                        reg_button.Visible = false;
                        btnSave.Visible = true;
                        reg_button.Text = "Регистрация";
                    }
                    else
                    {
                        users.Visible = false;
                        reg_button.Visible = false;
                        reg_button.Text = "Регистрация";
                    }
                    add.Visible = true;
                    users.Visible = true;
                }
            }
            else
            {
                add.Visible = false;
                btnSave.Visible = false;
                users.Visible = false;
                users.Visible = false;
                reg_button.Visible = true;
                reg_button.Text = "Регистрация";
                userType = -1;
                userName = "";
                userNameLabel.Text = "Имя пользователя:";
                typeUserLabel.Text = "Права:";
                authFlag = false;
                authorization_button.Text = "Войти";
            }
        }
        private void reg_button_Click(object sender, EventArgs e)
        {
            Registration reg = new Registration(userType);
            reg.ShowDialog();
            if (reg.regFlag && userType != 0)
            {
                authorization_button_Click(sender, e);
            }
        }
        private void Front_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbDataSet.reviews". При необходимости она может быть перемещена или удалена.
            //this.reviewsTableAdapter.Fill(this.dbDataSet.reviews);

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                //this.reviewsTableAdapter.Update(this.dbDataSet.reviews);
                error.Text = "Данные сохранены";
            }
            catch
            {
                error.Text = "ошибка сохранения данных";
            }
        }
        private void users_Click(object sender, EventArgs e)
        {
            UsersForm form = new UsersForm();
            form.ShowDialog();
        }
        private void add_Click(object sender, EventArgs e)
        {
            AddReview form = new AddReview(userName);
            form.ShowDialog();
            //if (form.addFlag)
            //    this.reviewsTableAdapter.Fill(this.dbDataSet.reviews);
        }
    }
}
