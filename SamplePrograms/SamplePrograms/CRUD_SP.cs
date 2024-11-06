using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SamplePrograms
{
    class CRUD_SP
    {
        static string ConnectionString = "Data Source=NB-NEETHU\\SQLEXPRESS;Initial Catalog=Online_business;Integrated Security=True";
        SqlConnection conn = new SqlConnection(ConnectionString);
        static void Main(string[] args)
        { 
             string Location = "";
            string loc = "";
            int salary;
            
            Console.WriteLine("Enter salary");
            salary = Int32.Parse(Console.ReadLine());

            CRUD_SP crdsp = new CRUD_SP();
            crdsp.GetempLocationANDsalarybase(loc, salary);
            crdsp.getallEmployee();
            crdsp.getempLocationbase(ConnectionString,Location);
           // crdsp.GetempLocationANDsalarybase(loc,salary);
            //Console.WriteLine("Enter salary");
           // salary = Int32.Parse(Console.ReadLine());

            Console.ReadLine();    
            



        }
        public void getallEmployee()
        {
            SqlCommand cmd;
            SqlDataReader rd;
            string sql, output = "";
            conn.Open();
            using (cmd = new SqlCommand("sp_GetEmployee", conn))
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                using (rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        output = output + rd.GetValue(0) + " - " + rd.GetValue(1) + " - " + rd.GetValue(2) + "-" + " - " + rd.GetValue(3) + " - " + rd.GetValue(4) + "\n";
                    }
                    Console.WriteLine("-------Get All Employee------");
                    Console.WriteLine(output);

                }
            }
            conn.Close();

        }
        public void getempLocationbase(string ConnectionString ,string location)
        {

            SqlCommand cmd;
           
            string sql,output= "";

            try
            {
                conn.Open();
                using (cmd = new SqlCommand("GetEmployeesByLocation", conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    Console.WriteLine("Enter location:");
                    location = Console.ReadLine();
                    Console.WriteLine($"You entered the location: {location}");
                    cmd.Parameters.AddWithValue("@Location", location);
             
                  
                   

                    using (SqlDataReader rd = cmd.ExecuteReader())
                    {
                        
                        while (rd.Read()) 
                        {
                            output = output + rd.GetValue(0) + " - " + rd.GetValue(1) + " - " + rd.GetValue(2) + "-" + " - " + rd.GetValue(3) + " - " + rd.GetValue(4) + "\n";
                        }
                        Console.WriteLine(output);

                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
            finally
            {
                conn.Close();
            }

        }
        public void GetempLocationANDsalarybase( string Location, int Salary)
        {

            SqlCommand cmd;

            string sql, output = "";

            try
            {
                conn.Open();
                using (cmd = new SqlCommand("GetEmployeesByLocationAndSalary", conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    Console.WriteLine("Enter location:");
                    Location = Console.ReadLine();
                    Console.WriteLine("Enter salary");
                    int salary = Int32.Parse(Console.ReadLine());

                    Console.WriteLine($"You entered the location: {Location} and Salary{Salary}");

                    cmd.Parameters.AddWithValue("@Location", Location);
                    cmd.Parameters.AddWithValue("@Salary", Salary);
                   

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            Console.WriteLine($"ID: {reader["EmployeeID"]}, Name: {reader["Name"]}, Email: {reader["Email"]}, Location:{reader["Location"]}, Salary:{reader["Salary"]}");
                            
                           // Console.WriteLine("Error");
                        }
                       

                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
            finally
            {
                conn.Close();
            }


        }

    }
}


