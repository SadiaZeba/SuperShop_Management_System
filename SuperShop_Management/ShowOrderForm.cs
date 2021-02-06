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
    public partial class ShowOrderForm : Form
    {
        internal ManagerForm MM { get; set; }
        
        
        internal ProductOrderRepo PO { get; set; }
        
        
        public ShowOrderForm()
        {
            InitializeComponent();
            this.PO = new ProductOrderRepo();
        }

        public ShowOrderForm(ManagerForm mf)
        {
            InitializeComponent();
            this.PO = new ProductOrderRepo();
            this.MM = mf;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            this.dgvInfo.AutoGenerateColumns = false;
            var result = this.PO.ViewAllOrder();
            this.dgvInfo.DataSource = result.Tables[0];
        }

        private void btnBO_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.MM.Visible = true;
        }

        private void ShowOrderForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnShow_MouseHover(object sender, EventArgs e)
        {
            this.btnShow.BackColor = Color.AliceBlue;
        }

        private void btnShow_MouseLeave(object sender, EventArgs e)
        {
            this.btnShow.BackColor = Color.LightSkyBlue;
        }

        private void btnBO_MouseHover(object sender, EventArgs e)
        {
            this.btnBO.BackColor = Color.AliceBlue;
        }

        private void btnBO_MouseLeave(object sender, EventArgs e)
        {
            this.btnBO.BackColor = Color.LightSkyBlue;
        }


    }
}
