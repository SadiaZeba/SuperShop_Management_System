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
    public partial class OrderInfoForm : Form
    {

        internal ProductOrderRepo por { get; set; }
        internal LoginForm LF { get; set; }



        public OrderInfoForm()
        {
            InitializeComponent();
            this.por = new ProductOrderRepo();
        }

        public OrderInfoForm(LoginForm lf)
        {
            InitializeComponent();
            this.por = new ProductOrderRepo();
            this.LF = lf;
        }


        private void PopulateGridView()
        {
            this.dgvOrderInfo.AutoGenerateColumns = false;
            var result = this.por.GetAllOrder(this.txtIdO.Text);
            this.dgvOrderInfo.DataSource = result.Tables[0];

            var res = this.por.GetInfoCart(this.txtIdO.Text);

            this.dgvCart.DataSource = res.Tables[0];

        }



        private void Products()
        {
            ArrayList a1 = this.por.InsertIntoCombo();
            for (int i = 0; i < a1.Count; i++)
            {
                this.cmbItemName.Items.Add(a1[i]);
            }
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            try
            {

                if (this.cmbItemName.Text == "")
                {
                    MessageBox.Show("select product you want.");
                }
                else if (this.txtQuantityO.Text == "")
                {
                    MessageBox.Show("Enter Quantity you want.");
                }
                else
                {


                    ArrayList a1 = this.por.ListOfProduct(this.cmbItemName.Text);

                    int a = Convert.ToInt32(a1[3]);
                    int b = Convert.ToInt32(this.txtQuantityO.Text);
                    int c = a - b;

                    if (c < 0)
                    {
                        MessageBox.Show("Not available this product.");
                    }
                    else
                    {
                        DelMethod dm = this.por.InsertOrder;
                        dm(this.cmbItemName.Text, this.txtQuantityO.Text, this.txtIdO.Text);

                        DelMethod dd = this.por.InsertToCard;
                        dd(this.cmbItemName.Text, this.txtQuantityO.Text, this.txtIdO.Text);



                        this.PopulateGridView();


                        this.txtQuantityO.Text = "";
                        this.cmbItemName.Text = "";
                    }

                }
            }



            catch (Exception ex)
            {
                MessageBox.Show("Exception");
            }

        }

        private void btnSub_Click(object sender, EventArgs e)
        
        {
            try
            {
                this.txtTotalCost.Text = this.por.CalculateCost(this.txtIdO.Text).ToString();

                int d = Convert.ToInt32(this.txtDiscount.Text);

                if (d == 0)
                {
                    this.txtDis.Text = this.txtTotalCost.Text;
                }
                else
                {
                    int p = Convert.ToInt32(this.txtTotalCost.Text);
                    double T = p - (p * (d * .01));
                    this.txtDis.Text = T.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please enter zero for no Discount.");
            }
             
          
            
            }
            

           


        







        private void btnDelOrder_Click(object sender, EventArgs e)
        {
            try
            {
                string s = this.dgvOrderInfo.CurrentRow.Cells[1].Value.ToString();
                string q = this.dgvOrderInfo.CurrentRow.Cells[4].Value.ToString();
                string id = this.dgvOrderInfo.CurrentRow.Cells[3].Value.ToString();

                DelMethod d1 = this.por.DeleteProductOrder;
                d1(s, q, id);

                string r = this.dgvCart.CurrentRow.Cells[1].Value.ToString();

                this.por.DeleteInfo(r);

                this.PopulateGridView();

                this.txtQuantityO.Text = "";

                this.cmbItemName.Text = "";
            }

            catch (Exception ex)
            {
                MessageBox.Show("Please select item first");
            }
        }



        private void OrderInfoForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.LF.Visible = true;
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            this.por.Update(this.txtQuantityO.Text, this.cmbItemName.Text);
            this.PopulateGridView();



        }

        private void OrderInfoForm_Load(object sender, EventArgs e)
        {
            this.Products();
            this.PopulateGridView();
            this.txtIdO.Text = this.por.OrderAutoId();
        }

        private void dgvCart_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.txtQuantityO.Text = this.dgvCart.CurrentRow.Cells[2].Value.ToString();
            this.cmbItemName.Text = this.dgvCart.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {


            this.por.ClearCard(this.txtIdO.Text);
            this.PopulateGridView();
        }
    }
}

