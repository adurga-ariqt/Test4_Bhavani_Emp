using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test4_Bhavani_Emp
{
    internal class DB_Connection_Employee: EmployeeList
    {
        string? connection;
        SqlConnection? con;
        string? query;
        public void DBconnection()
        {
            var Emplist = EmployeeListMethod();
            connection = "Server=LAPTOP-4UV87UTN;Database=Durgabhavani;Trusted_Connection = true;TrustServerCertificate=True";
            SqlConnection con = new SqlConnection(connection);
            //query = "insert into Employee(EmpName,EmpAge,Gender,DeptID)" + "values (@EmpName,@EmpAge,@EmpGender,@DeptID)";
            query = "insert into Emp values (@EmpName,@EmpAge,@Gender,@DeptID)";
            int isdone = 0;
            foreach (var dept in Emplist)
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.Add("@EmpName", System.Data.SqlDbType.NVarChar, 100).Value = dept.EmpName;
                cmd.Parameters.Add("@EmpAge", System.Data.SqlDbType.NVarChar, 100).Value = dept.EmpAge;
                cmd.Parameters.Add("@Gender", System.Data.SqlDbType.NVarChar, 100).Value = dept.EmpGender;
                cmd.Parameters.Add("@DeptID", System.Data.SqlDbType.NVarChar, 100).Value = dept.DeptID;
                isdone = cmd.ExecuteNonQuery();
                con.Close();
            }
            if (isdone == 1)
            {
                Console.WriteLine("Values  Inserted");
            }
        }
    }
}
