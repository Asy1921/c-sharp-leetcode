using System.Data;
using System.Data.SqlClient;
namespace LeetCodeProblems;
public partial class LCProblems
{
    public void TestSQL()
    {
        // Connection string
        string connectionString = "Server= ZS-Dentsql01;database=PDCoach_9901ZS3867_Dev ;user id=PDCoach_9901ZS3867_Dev ;password= SveVu1Q%SveVu1QW5;TrustServerCertificate=True;";

        // Create connection
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            try
            {
                // Open connection
                connection.Open();
                Console.WriteLine("Connected to SQL Server.");

                // Perform database operations here
                string sqlQuery = "SELECT Top 5 * FROM tbl_Employee_Roster";
                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    // Execute the query
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        // Check if the reader has rows
                        if (reader.HasRows)
                        {
                            // Read and display data
                            while (reader.Read())
                            {

                                var id = reader.GetValue(reader.GetOrdinal("Emp ID"));


                                Console.WriteLine($"ID: {id}");
                            }
                        }
                        else
                        {
                            Console.WriteLine("No data found.");
                        }
                    }
                }

                // Close connection
                connection.Close();
                Console.WriteLine("Connection closed.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}