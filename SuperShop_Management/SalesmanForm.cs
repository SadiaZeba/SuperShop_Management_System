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
using System.Collections;

namespace SuperShopManagementSystem
{
    public partial class SalesmanForm :Form
    {
        internal ManagerForm MF { get; set; }
        internal SalesmanRepo smr { get; set; }
        public SalesmanForm()
        {
            InitializeComponent();
            this.smr = new SalesmanRepo();
        }
         public SalesmanForm(ManagerForm m)
        {
            InitializeComponent();
            this.smr = new SalesmanRepo();
            this.MF = m;
        }
         private void PopulateGridView()
         {
             this.dgvSalesman.AutoGenerateColumns = false;
             var result = this.smr.GetAllInfo();
             this.dgvSalesman.DataSource = result.Tables[0];
         }

         private void SalesmanForm_Load(object sender, EventArgs e)
         {
             this.txtIdS.Text = this.smr.IdAuto();
             this.PopulateGridView();
         }

         private void btnSave_Click(object sender, EventArgs e)
         {
             try
             {
                 ArrayList A1 = new ArrayList();
                 
                 A1.Add(this.txtIdS.Text);
                 A1.Add(this.txtNameS.Text);
                 A1.Add(this.txtPasS.Text);
                 A1.Add(this.txtEmailS.Text);
                 A1.Add(this.txtSalS.Text);
                 A1.Add(this.txtAdrS.Text);
                
                 this.smr.InsertInfo(A1);
                 this.PopulateGridView();
                 this.ClearAll();
             }
             catch (Exception ex)
             {
                 MessageBox.Show("Please Insert appropriate Information");
             }
         }
         private void ClearAll()
         {
             this.txtIdS.Text = this.smr.IdAuto();

             this.txtNameS.Clear();

             this.txtAdrS.Clear();
             this.txtSalS.Clear();
             this.txtEmailS.Clear();
             this.txtPasS.Clear();
         }

         private void dgvSalesman_MouseDoubleClick(object sender, MouseEventArgs e)
         {
             this.txtIdS.Text = this.dgvSalesman.CurrentRow.Cells[0].Value.ToString();
             this.txtNameS.Text = this.dgvSalesman.CurrentRow.Cells[1].Value.ToString();
            
             this.txtAdrS.Text = this.dgvSalesman.CurrentRow.Cells[2].Value.ToString();
             
             this.txtEmailS.Text = this.dgvSalesman.CurrentRow.Cells[3].Value.ToString();
             this.txtSalS.Text = this.dgvSalesman.CurrentRow.Cells[4].Value.ToString();
             this.txtPasS.Text = this.dgvSalesman.CurrentRow.Cells[5].Value.ToString();
         }

         private void btnDeleteS_Click(object sender, EventArgs e)
         {
             try
             {
                 string s = this.dgvSalesman.CurrentRow.Cells[0].Value.ToString();

                 this.smr.DeleteInfo(s);
                 this.PopulateGridView();
                 this.ClearAll();
             }
             catch (Exception ex)
             {
                 MessageBox.Show("select a row first.");
             }
         }

         private void txtSearchS_TextChanged(object sender, EventArgs e)
         {
             string ss = this.txtSearchS.Text;
             this.dgvSalesman.AutoGenerateColumns = false;
             var result = this.smr.GetAllInfo(this.smr.SearchInfo(ss));
             this.dgvSalesman.DataSource = result.Tables[0];
         }

         private void btnBack_Click(object sender, EventArgs e)
         {
             this.Visible = false;
             this.MF.Visible = true;
         }

         private void SalesmanForm_FormClosing(object sender, FormClosingEventArgs e)
         {
             Application.Exit();
         }

     }
}
