using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal_Cash_Flow.View
{
    public class OutputItem
    {
        public static void ioutputShowReader(SqlDataReader reader)
        {
            while (reader.Read())
            {
                Console.WriteLine("Id : " + reader[0]);
                Console.WriteLine("Name : " + reader[1]);
                Console.WriteLine("Price : " + reader[2]);
                Console.WriteLine("Total : " + reader[3]);
                Console.WriteLine("Type : " + reader[4]);
                Console.WriteLine("Vendor : " + reader[5]);
                Console.WriteLine("Halal : " + reader[6]);
                Console.WriteLine("====================");
            }

            Console.ReadLine();
        }
    }
}
