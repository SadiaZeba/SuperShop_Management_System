using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SuperShop.Data;
using SuperShop.Repo;

namespace SuperShopManagementSystem
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string id = this.txtLogId.Text;
            string password = this.txtPaslog.Text;
            LoginRepo l = new LoginRepo();
            int sm = l.SalesmanLogin(id, password);

            if (l.ManagerLogin(id, password) == 03)
            {
                this.Visible = false;
                MessageBox.Show("Login Sucessfully.");
                ManagerForm m1 = new ManagerForm(this);
                m1.Visible = true;

                this.txtLogId.Text = "";
                this.txtPaslog.Text = "";
            }

            else if (sm == 12)
            {
                this.Visible = false;
                MessageBox.Show("Login Sucessfully.");
                OrderInfoForm of = new OrderInfoForm(this);
                of.Visible = true;

                this.txtLogId.Text = "";
                this.txtPaslog.Text = "";
            }
            else if (l.ManagerLogin(id, password) == 01 || sm == 10)
            {
                MessageBox.Show("Wrong Password.");
            }
            else if (l.ManagerLogin(id, password) == 02 || sm == 11)
            {
                MessageBox.Show("Wrong UserId.");
            }
            else
            {
                MessageBox.Show("Wrong UserId and Password.");
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        


    }
}
