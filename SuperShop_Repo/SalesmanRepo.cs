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
    public class SalesmanRepo
    {
        internal DataAccess Da { get; set; }
        internal DataSet Ds { set; get; }
        public SalesmanRepo()
        {
            this.Da = new DataAccess();
        }
       
        
        
        public string IdAuto()
        {
            int a = this.Da.ExecuteUpdateID("select isnull(max(cast(Eserial as int)), 0) + 1 from Employee_Tbl;");
            string b = "s-" + a.ToString().PadLeft(4, '0');
            return b;
        }
       
      
        
        
        
        public void InsertInfo(ArrayList a)
        {
            bool flag = false;
            for (int i = 0; i < this.Ds.Tables[0].Rows.Count; i++)
            {
                if (this.Ds.Tables[0].Rows[i][1].ToString() == a[0].ToString())
                {
                    flag = true;
                    break;
                }
            }

            if (flag == true)
            {
                string sql = @"update Employee_Tbl set Ename='" + a[1] + "',Eaddress='" + a[5] + "',Esalary=" + a[4] + ",Eemail='" + a[3] + "',Epassword='" + a[2] + "' where Eid='" + a[0] + "';";
                this.Da.ExecuteUpdateQuery(sql);
            }
            else
            {
                string sql1 = @"insert into Employee_Tbl values('" + a[0] + "','" + a[1] + "','" + a[5] + "','" + a[3] + "','" + a[4] + "','salesman','" + a[2] + "');";
                this.Da.ExecuteUpdateQuery(sql1);
            }
        }
       
        
        public DataSet GetAllInfo(string sql = "select * from Employee_Tbl where Erole='salesman';")
        {
            this.Ds = this.Da.ExecuteQuery(sql);
            return this.Ds;
        }
       
      
        
        public void DeleteInfo(string s)
        {
            string sql = "delete from Employee_Tbl where Eid='" + s + "';";
            this.Da.ExecuteUpdateQuery(sql);
        }

      
        
        public string SearchInfo(string s1)
        {
            string s = "select * from Employee_Tbl where Erole='salesman' and (Eid like '" + s1 + "%' or Ename like '" + s1 + "%' and Erole='salesman');";
            return s;
        }

    }
}
