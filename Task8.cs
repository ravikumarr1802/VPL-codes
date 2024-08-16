using System;
using MySql.Data;
using MySql.Data.MySqlClient;
namespace Program;
class Program
{
    public static void Main(string[] args)
    {
        string strcon = "server=localhost; userid=root; password=#ravi!$#1802; database=vpl";
        using var con = new MySqlConnection(strcon);
        con.Open();
        using var cmd = new MySqlCommand();
        cmd.Connection = con;
        cmd.CommandText = "Insert into mytable values('Raghu',24,'10 A');";
        cmd.ExecuteNonQuery();
        Console.WriteLine("Record Inserted");
    }
}