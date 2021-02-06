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
using SuperShop.Data;
using System.Collections;

namespace SuperShopManagementSystem
{
    public partial class ProductForm : Form
    {
        internal ManagerForm m1 { get; set; }
        internal ProductRepo pr { get; set; }
        public ProductForm()
        {
            InitializeComponent();
            this.pr = new ProductRepo();
        }

         public ProductForm(ManagerForm MF)
        {
            InitializeComponent();
            this.pr = new ProductRepo();
            this.m1 = MF;
        }

         private void PopulateGridView()
         {
             this.dgvPro.AutoGenerateColumns = false;
             var result = this.pr.GetAllProductInfo();
             this.dgvPro.DataSource = result.Tables[0];
         }

         private void ProductForm_Load(object sender, EventArgs e)
         {
             this.txtIdP.Text = this.pr.ProductsAutoId();
             this.PopulateGridView();
         }

         private void btnAddP_Click(object sender, EventArgs e)
         {
             try
             {
                 ArrayList p1 = new ArrayList();
                 p1.Add(this.txtIdP.Text);
                 p1.Add(this.txtPname.Text);
                 p1.Add(this.txtPquantity.Text);
                 p1.Add(this.txtPrice.Text);
                 p1.Add(this.dtpExp.Text);
                
                 this.pr.InsertProduct(p1);
                 this.PopulateGridView();
                 this.Clear();
             }
             catch (Exception ex)
             {
                 MessageBox.Show("Please Insert data.");
             }
         }
         private void Clear()
         {

             this.txtIdP.Text = this.pr.ProductsAutoId();
             this.txtPname.Clear();
             this.txtPquantity.Clear();
             this.txtPrice.Clear();
             this.dtpExp.Text = "";
                 
                
             
         }

         private void dgvPro_MouseDoubleClick(object sender, MouseEventArgs e)
         {
             this.txtIdP.Text = this.dgvPro.CurrentRow.Cells[0].Value.ToString();
             this.txtPname.Text = this.dgvPro.CurrentRow.Cells[1].Value.ToString();
             this.txtPquantity.Text = this.dgvPro.CurrentRow.Cells[2].Value.ToString();
             this.txtPrice.Text = this.dgvPro.CurrentRow.Cells[3].Value.ToString();
             this.dtpExp.Text = this.dgvPro.CurrentRow.Cells[4].Value.ToString();
         }

         private void btnDelP_Click(object sender, EventArgs e)
         {
             try
             {
                 string s = this.dgvPro.CurrentRow.Cells[0].Value.ToString();
                 this.pr.DeleteProduct(s);
                 this.PopulateGridView();
                 this.Clear();
                 
             }
             catch (Exception ex)
             {
                 MessageBox.Show("Select row first");
             }
         }

         private void ProductForm_FormClosing(object sender, FormClosingEventArgs e)
         {
             Application.Exit();
         }

         private void btnBackP_Click(object sender, EventArgs e)
         {
             this.Visible = false;
             this.m1.Visible = true;
         }

         private void txtSearchP_TextChanged(object sender, EventArgs e)
         {

             string s = this.txtSearchP.Text;

             this.dgvPro.AutoGenerateColumns = false;
             var data = this.pr.GetAllProductInfo(this.pr.SearchProduct(s));
             this.dgvPro.DataSource = data.Tables[0];
         }




        
    }
}
