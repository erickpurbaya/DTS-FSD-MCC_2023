using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal_Cash_Flow.View
{
    public class OutputPurchase
    {
        public static void poutputShowReader(SqlDataReader reader)
        {
            while (reader.Read())
            {
                Console.WriteLine("Id : " + reader[0]);
                Console.WriteLine("Date : " + reader[1]);
                Console.WriteLine("Total : " + reader[2]);
                Console.WriteLine("Item : " + reader[3]);
                Console.WriteLine("VendorID : " + reader[4]);
                Console.WriteLine("Paid : " + reader[5]);
                Console.WriteLine("====================");
            }
        }
    }
}
