using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectSignUp
{
    internal class Class2

    {

     static   string constr = @"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Lenovo\\source\\repos\\projectSignUp\\projectSignUp\\Flight.mdf;Integrated Security=True";
    static    SqlConnection conn=new SqlConnection(constr);

    static    void calling()
        {
            conn.Open();
            string query = "insert into student values (@id,@name,@salary)";
            

           SqlCommand comm=new SqlCommand(query, conn);
            comm.Parameters.AddWithValue("@id", 1);
            comm.Parameters.AddWithValue("@name", "ali");
            comm.Parameters.AddWithValue("@salary", 10000);
            comm.ExecuteNonQuery();
            conn.Close();
        }
    }

}
