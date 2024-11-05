using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SamplePrograms
{

    class CRUD_OPERATION
    {
        static string ConnectionString = "Data Source=NB-NEETHU\\SQLEXPRESS;Initial Catalog=Online_business;Integrated Security=True";
        SqlConnection conn = new SqlConnection(ConnectionString);



        static void Main(string[] args)
        {
            CRUD_OPERATION crd = new CRUD_OPERATION();
           crd. getData();
            crd.addData();
            crd.updateData();
            crd.deleteData();
            Console.ReadKey();



        }
        public  void getData()
        {
            SqlCommand cmd;
            SqlDataReader rd;
            string sql, output = "";
            conn.Open();
            sql = "Select CustomerID, Address,City,PostalCode,Country from Customers";
            cmd = new SqlCommand(sql, conn);
            rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                output = output + rd.GetValue(0) + " - " +
                                    rd.GetValue(1) + "\n" +
                rd.GetValue(2) + "\n" +
                rd.GetValue(3) + "\n" +
                rd.GetValue(4) + "\n";

            }
            Console.WriteLine(output);

            conn.Close();
        }
        public void addData()
        {
            SqlCommand cmd;
            
            string sql = "";
            conn.Open();
            sql = "insert into Customers values(10,'NewVilla','City',128,'SRILANKA')";

            cmd = new SqlCommand(sql, conn);
            
            cmd.ExecuteNonQuery();
            conn.Close();
            


        }
        public void updateData()
        {
            SqlCommand cmd;
            SqlDataReader rd;
            string sql = "";
            conn.Open();
            sql = "update Customers set Address ='Neethuvilla' where CustomerID = 7";
            cmd = new SqlCommand(sql, conn);

            cmd.ExecuteNonQuery();
            conn.Close();

        }
        public void deleteData()
        {
            SqlCommand cmd;
            SqlDataReader rd;
            string sql = "";
            conn.Open();
            sql = "Delete from Customers where CustomerID = 6";
            cmd = new SqlCommand(sql, conn);

            cmd.ExecuteNonQuery();
            conn.Close();
        }

    }
}
