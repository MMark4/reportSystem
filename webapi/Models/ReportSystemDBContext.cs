namespace reportsystemwebapi.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.EntityFrameworkCore;
    using MySql.Data.MySqlClient;

    public class ReportSystemDBContext : DbContext
    {
        private string ConnectionString { get; set; }  
  
        public ReportSystemDBContext(string connectionString)  
        {  
             ConnectionString = connectionString;  
        }  

        private MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }


        public IEnumerable<TestCycle> GetTestCycles ()
        {
            List<TestCycle> list = new List<TestCycle>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM TestCycles", conn);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                while (reader.Read())
                {
                    list.Add(new TestCycle()
                    {
                        TestCycleID = reader.GetInt32(1),
                        AUTName =reader.GetString(2),
                        ExecutedBy=reader.GetString(3),
                        ReportZip =reader.GetString(4),
                        RequestedBy =reader.GetString(5),
                        BuildNo = reader.GetInt32(6),
                        ApplicationVersion = reader.GetString(7),
                        DateOfExecution= reader.GetDateTime(8),
                        TestType= reader.GetString(9),
                        MachineName= reader.GetString(10),
                        RowId = reader.GetInt32(11)
                    });
                }
            }
            return list;
        }
    }
}
}