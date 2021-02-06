using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using SuperShop.Data;

namespace SuperShop.Repo
{
    public class LoginRepo
    {
        internal DataAccess Da { get; set; }
        internal DataSet Ds { set; get; }
        public LoginRepo()
        {
            this.Da = new DataAccess();
        }
         public int ManagerLogin(string userid, string password)
        {
         
             this.Ds = this.Da.ExecuteQuery("select * from Employee_Tbl where Erole = 'Manager';");
             
             bool flag1 = false,
                 flag2 = false;

             for (int i = 0; i < this.Ds.Tables[0].Rows.Count; i++)
            {
                if (this.Ds.Tables[0].Rows[i]["Eid"].ToString().Equals(userid))
                {
                    flag1 = true;
                }
                if (this.Ds.Tables[0].Rows[i]["Epassword"].ToString() == password)
                {
                    flag2 = true;
                }
            }
             if (flag1 == true && flag2 == false)
             {
                 return 01;
             }
             else if (flag1 == false && flag2 == true)
             {
                 return 02;
             }
             else if (flag1 == true && flag2 == true)
             {
                 return 03;
             }
             else
             {
                 return 04;

             }
        }
         public int SalesmanLogin(string userid, string password)
        {
           this.Ds = this.Da.ExecuteQuery("select * from Employee_Tbl where Erole = 'salesman';");
              bool flag1 = false, flag2 = false;

              for (int i = 0; i < this.Ds.Tables[0].Rows.Count; i++)
            {
                if (this.Ds.Tables[0].Rows[i]["Eid"].ToString().Equals(userid))
                {
                    flag1 = true;
                }
                if (this.Ds.Tables[0].Rows[i]["Epassword"].ToString() == password)
                {
                    flag2 = true;
                }
            }
              if (flag1 == true && flag2 == false)
              {
                  return 10;
              }
              else if (flag1 == false && flag2 == true)
              {
                  return 11;
              }
              else if (flag1 == true && flag2 == true)
              {
                  return 12;
              }
              else
              {
                  return 13;

              }
           }

    }
}
