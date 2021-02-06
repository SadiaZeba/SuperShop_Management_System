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
   
   public class ProductRepo
    {
        internal DataAccess Da { get; set; }
        internal DataSet Ds { get; set; }
        public ProductRepo()
        {
            this.Da = new DataAccess();
        }

        public DataSet GetAllProductInfo(string sql = "select * from product_Tbl;")
        {
            this.Ds = this.Da.ExecuteQuery(sql);
            return this.Ds;
        }


        public string ProductsAutoId()
        {
            int w = this.Da.ExecuteUpdateID("select isnull(max(cast(Pserial as int)), 0) + 1 from product_Tbl;");
            string x = "p-" + w.ToString().PadLeft(4, '0');
            return x;
        }
        
        public void InsertProduct(ArrayList p)
        {
            bool flag = false;
            for (int c = 0; c < this.Ds.Tables[0].Rows.Count; c++)
            {
                if (this.Ds.Tables[0].Rows[c][1].ToString() == p[0].ToString())
                {
                    flag = true;
                    break;
                }
            }
              if (flag == true)
            {
                string sql1 = @"update product_Tbl set Pname='" + p[1] + "',Pavailablequantity='" + p[2] + "',Pprice=" + p[3] + ",Pexpirydate='" + p[4] + "' where pid='" + p[0] + "';";
                this.Da.ExecuteUpdateQuery(sql1);
            }
              else
              {
                  string sql = @"insert into product_Tbl values ('" + p[0] + "','" + p[1] + "'," + p[2] + "," + p[3] + ",'" + p[4] + "');";
                  this.Da.ExecuteUpdateQuery(sql);
              }
        }
      
        public void DeleteProduct(string s)
        {
            string sql = "delete from product_Tbl where Pid='" + s + "';";
            this.Da.ExecuteUpdateQuery(sql);
        }

        public string SearchProduct(string s)
        {
            string sql = "select * from product_Tbl where Pid like '" + s + "%' or pname like '" + s + "%'";

            return sql;
        }
       


    }
}
