using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SuperShop.Repo;

namespace SuperShopManagementSystem
{
    public partial class ManagerForm : Form
    {
        private LoginForm LogF { get; set; }
        public ManagerForm()
        {
            InitializeComponent();
        }
         public ManagerForm(LoginForm lf)
        {
            InitializeComponent();
            this.LogF = lf;
        }

         private void ManagerForm_FormClosing(object sender, FormClosingEventArgs e)
         {
             Application.Exit();
         }

         private void btnLogout_Click(object sender, EventArgs e)
         {
             this.Visible = false;
             this.LogF.Visible = true;
         }

         private void btnSM_Click(object sender, EventArgs e)
         {
             this.Visible = false;
             SalesmanForm sm = new SalesmanForm(this);
             sm.Visible = true;
         }

         private void btnPr_Click(object sender, EventArgs e)
         {
             this.Visible = false;
             ProductForm p1 = new ProductForm(this);
             p1.Visible = true;
         }

         private void btnOrder_Click(object sender, EventArgs e)
         {
             this.Visible = false;
             ShowOrderForm sh = new ShowOrderForm(this);
             sh.Visible = true;
         }

         private void btnSM_MouseHover(object sender, EventArgs e)
         {
             this.btnSM.BackColor = Color.Beige;
         }

         private void btnSM_MouseLeave(object sender, EventArgs e)
         {
             this.btnSM.BackColor = Color.LightSkyBlue;
         }

         private void btnPr_MouseHover(object sender, EventArgs e)
         {
             this.btnPr.BackColor = Color.Beige;
         }

         private void btnPr_MouseLeave(object sender, EventArgs e)
         {
             this.btnPr.BackColor = Color.LightSkyBlue;
         }

         private void btnOrder_MouseHover(object sender, EventArgs e)
         {
             this.btnOrder.BackColor = Color.Beige;
         }

         private void btnOrder_MouseLeave(object sender, EventArgs e)
         {
             this.btnOrder.BackColor = Color.LightSkyBlue;
         }






    }
}
