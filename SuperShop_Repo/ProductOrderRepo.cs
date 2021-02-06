using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using SuperShop.Data;
using System.Collections;

namespace SuperShop.Repo
{
    public delegate void DelMethod(string a, string b, string o);

    public class ProductOrderRepo
    {
        internal DataAccess Da { get; set; }
        internal DataSet Ds { get; set; }
        internal DataAccess Dap { get; set; }
        internal DataSet Dsp { get; set; }

        internal DataAccess DA { get; set; }
        internal DataSet Das { get; set; }

        public ProductOrderRepo()
        {
            this.Da = new DataAccess();
            this.Dap = new DataAccess();
            this.DA = new DataAccess();
        }

        public DataSet GetAllOrder(string id)
        {
            string sql = "select * from orderpurchase_Tbl where Oid ='" + id + "';";
            this.Ds = this.Da.ExecuteQuery(sql);


            return this.Ds;

        }

        public DataSet GetInfoCart(string id)
        {

            string sql1 = "select * from Cart_Tbl where OrdId ='" + id + "';";
            this.Das = this.DA.ExecuteQuery(sql1);

            return this.Das;
        }

        public void InsertOrder(string name, string quantity, string orderid)
        {
            ArrayList al = new ArrayList();
            this.Dsp = this.Dap.ExecuteQuery("select * from product_Tbl where Pname ='" + name + "';");
            for (int i = 0; i < this.Dsp.Tables[0].Columns.Count; i++)
            {
                al.Add(this.Dsp.Tables[0].Rows[0][i].ToString());
            }
            int cost = Convert.ToInt32(al[4]) * Convert.ToInt32(quantity);

            this.Ds = this.Da.ExecuteQuery("select * from orderpurchase_Tbl;");

            string sql1 = @"insert into orderpurchase_Tbl
            values ('" + orderid + "','" + name + "','" + al[1] + "'," + quantity + "," + al[4] + "," + cost + ",'" + DateTime.Now.ToString("MM/dd/yyyy") + "');";
            this.Da.ExecuteUpdateQuery(sql1);


            int availablequantity = Convert.ToInt32(al[3]) - Convert.ToInt32(quantity);

            string sql2 = @"update product_Tbl set Pavailablequantity = " + availablequantity + " where Pname = '" + name + "'; ";

            this.Dap.ExecuteUpdateQuery(sql2);



        }

        public void InsertToCard(string n, string quant, string oid)
        {
            ArrayList al = new ArrayList();
            this.Dsp = this.Dap.ExecuteQuery("select * from product_Tbl where Pname ='" + n + "';");
            for (int i = 0; i < this.Dsp.Tables[0].Columns.Count; i++)
            {
                al.Add(this.Dsp.Tables[0].Rows[0][i].ToString());
            }
            int cost = Convert.ToInt32(al[4]) * Convert.ToInt32(quant);

            this.Das = this.DA.ExecuteQuery("select * from Cart_Tbl;");

            string sql1 = @"insert into Cart_Tbl
            values ('" + oid + "','" + n + "'," + quant + "," + al[4] + "," + cost + ");";
            this.DA.ExecuteUpdateQuery(sql1);




        }

        public void Update(string q, string n)
        {
            ArrayList al = new ArrayList();
            this.Dsp = this.Dap.ExecuteQuery("select * from product_Tbl where Pname ='" + n + "';");
            for (int i = 0; i < this.Dsp.Tables[0].Columns.Count; i++)
            {
                al.Add(this.Dsp.Tables[0].Rows[0][i].ToString());
            }
            int cost = Convert.ToInt32(al[4]) * Convert.ToInt32(q);

            this.Das = this.DA.ExecuteQuery("select * from Cart_Tbl;");
            string sql2 = @"update Cart_Tbl set Quantity = '" + q + " ', Cost = '" + cost + "' where Proname='" + n + "' ; ";

            this.DA.ExecuteUpdateQuery(sql2);




        }


        public void DeleteProductOrder(string s, string q, string id)
        {
            this.Dsp = this.Dap.ExecuteQuery("select * from product_Tbl where Pid ='" + id + "';");

            string a = this.Dsp.Tables[0].Rows[0][3].ToString();

            int m = Convert.ToInt32(a) + Convert.ToInt32(q);

            string sql2 = @"update product_Tbl set Pavailablequantity=" + m + " where Pid='" + id + "';";
            this.Dap.ExecuteUpdateQuery(sql2);

            string sql = "delete from orderpurchase_Tbl where Oid='" + s + "';";
            this.Da.ExecuteUpdateQuery(sql);


        }

        public void DeleteInfo(string C)
        {
            string sq = "delete from Cart_Tbl where Proname='" + C + "';";
            this.DA.ExecuteUpdateQuery(sq);
        }


        public void ClearCard(string C)
        {
            string sq = "delete from Cart_Tbl where OrdId='" + C + "';";
            this.DA.ExecuteUpdateQuery(sq);
        }

        public string OrderAutoId()
        {
            int s = this.Da.ExecuteUpdateID("select isnull(max(cast(Oid as int)), 0) + 1 from orderpurchase_Tbl;");
            string b = s.ToString();
            return b;
        }

        public ArrayList InsertIntoCombo()
        {
            this.Dsp = this.Dap.ExecuteQuery("select * from product_Tbl;");
            ArrayList a1 = new ArrayList();
          
            for (int v = 0; v < this.Dsp.Tables[0].Rows.Count; v++)
            {
                a1.Add(this.Dsp.Tables[0].Rows[v][2].ToString());
                
            }
            return a1;
        }
       

        public ArrayList ListOfProduct(string name)
        {
            ArrayList bl = new ArrayList();

            this.Dsp = this.Dap.ExecuteQuery("select * from product_Tbl where Pname ='" + name + "';");

            for (int i = 0; i < this.Dsp.Tables[0].Columns.Count; i++)
            {
                bl.Add(this.Dsp.Tables[0].Rows[0][i].ToString());
            }
            return bl;
        }



        public DataSet ViewAllOrder()
        {
            this.Ds = this.Da.ExecuteQuery("select * from orderpurchase_Tbl order by Oid;");

            return this.Ds;
        }

        public int CalculateCost(string p)
        {
            int sum = 0;
            this.Das = this.DA.ExecuteQuery("select * from Cart_Tbl where OrdId='" + p + "';");
            ArrayList a1 = new ArrayList();
            for (int v = 0; v < this.Das.Tables[0].Rows.Count; v++)
            {
                a1.Add(this.Das.Tables[0].Rows[v][4].ToString());
            }
            for (int s = 0; s < a1.Count; s++)
            {
                sum += Convert.ToInt32(a1[s]);

            }
            return sum;
        }

      


    }
}
