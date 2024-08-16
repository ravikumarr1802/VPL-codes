//using System;
//using System.Data.SqlClient;

//namespace ConsoleApplication
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            string connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=TestDB;Integrated Security=True;Pooling=False;Encrypt=False;";

//            SqlConnection sqlConnection1 = new SqlConnection(connectionString);

//            SqlCommand cmd = new SqlCommand();
//            cmd.CommandType = System.Data.CommandType.Text;
//            cmd.CommandText = "INSERT into student values(4, 'username1', 'subject1')";
//            cmd.Connection = sqlConnection1;

//            sqlConnection1.Open();
//            cmd.ExecuteNonQuery();
//            sqlConnection1.Close();
//        }

//    }
//}
using System;
using System.Data.SqlClient;
namespace FirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=TestDB;Integrated Security=True;Pooling=False;Encrypt=False;";
            SqlConnection con = new SqlConnection(connectionString);
            string querystring = "Select * from Student";
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = querystring;
            cmd.Connection = con;
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine(reader[0].ToString() + " " + reader[1].ToString() + " " + reader[2].ToString());
            }
        }
    }
}