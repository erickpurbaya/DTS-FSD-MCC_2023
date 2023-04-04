using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal_Cash_Flow.View
{
    public class OutputVendor
    {
        public static void voutputShowReader(SqlDataReader reader)
        {
                while (reader.Read())
                {
                    Console.WriteLine("Id : " + reader[0]);
                    Console.WriteLine("Name : " + reader[1]);
                    Console.WriteLine("Origin : " + reader[2]);
                    Console.WriteLine("Type : " + reader[3]);
                    Console.WriteLine("Verified : " + reader[4]);
                    Console.WriteLine("====================");
                }
        }
    }
}
