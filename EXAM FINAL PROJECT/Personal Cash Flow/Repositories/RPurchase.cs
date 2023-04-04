using Personal_Cash_Flow.View;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal_Cash_Flow.Model
{
    public static class Purchase2
    {
        static string ConnectionString = "Data Source=CRESTO;Initial Catalog=PersonalCashFlow;Integrated Security=True;Connect Timeout=30;";

        static SqlConnection connection;

        public static void getAll()
        {
            Console.Clear();
            connection = new SqlConnection(ConnectionString);

            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "SELECT * FROM purchase;";

            connection.Open();

            using SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {

                OutputPurchase.poutputShowReader(reader);
            }
            else
            {
                Console.WriteLine("Data not found!");
            }
            reader.Close();

            connection.Close();
            Console.ReadLine();
        }

        public static void getById(int identity)
        {
            Console.Clear();
            connection = new SqlConnection(ConnectionString);

            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "SELECT * FROM purchase WHERE pID = " + identity;

            connection.Open();

            using SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                /*while (reader.Read())
                {
                    Console.WriteLine("Id : " + reader[0]);
                    Console.WriteLine("Name : " + reader[1]);
                    Console.WriteLine("Origin : " + reader[2]);
                    Console.WriteLine("Type : " + reader[3]);
                    Console.WriteLine("Verified : " + reader[4]);
                    Console.WriteLine("====================");
                }*/
                OutputPurchase.poutputShowReader(reader);
            }
            else
            {
                Console.WriteLine("Data not found!");
            }

            //Menutup reader.
            reader.Close();

            //Menutup koneksi.
            connection.Close();

            Console.ReadLine();
        }

        public static int checkID(int identity)
        {
            Console.Clear();
            connection = new SqlConnection(ConnectionString);

            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "SELECT * FROM purchase WHERE pID = " + identity;

            connection.Open();

            using SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                OutputPurchase.poutputShowReader(reader);
            }
            else
            {
                identity = 0;
                Console.WriteLine("Data not found!");
            }

            //Menutup reader.
            reader.Close();

            //Menutup koneksi.
            connection.Close();

            return identity;
        }

        public static void add(this Purchase beli)
        {
            Console.Clear();
            connection = new SqlConnection(ConnectionString);

            connection.Open();

            SqlTransaction transaction = connection.BeginTransaction();
            try
            {
                SqlCommand command = new SqlCommand();
                command.Connection = connection;

                command.CommandText = "INSERT INTO purchase VALUES (" + Convert.ToString(beli.pID) + ", '" + beli.pDATE + "', " + Convert.ToString(beli.pTOTAL) + ", '" + beli.pITEM + "', " + Convert.ToString(beli.pvID) + ", " + Convert.ToString(beli.pPAID) + ");";

                Console.WriteLine(command.CommandText);

                command.Transaction = transaction;

                int result = command.ExecuteNonQuery();

                transaction.Commit();
                if (result > 0)
                {
                    Console.WriteLine("Data successfully added!");
                }
                else
                {
                    Console.WriteLine("Data insertion failed!");
                }

                connection.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                try
                {
                    transaction.Rollback();
                }
                catch (Exception rollback)
                {
                    Console.WriteLine(rollback.Message);
                }
            }

        }



        public static void delete(int idCari)
        {
            Console.Clear();
            connection = new SqlConnection(ConnectionString);

            connection.Open();

            SqlTransaction transaction = connection.BeginTransaction();
            try
            {
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "DELETE FROM purchase WHERE pID = " + idCari;
                command.Transaction = transaction;

                int result = command.ExecuteNonQuery();

                transaction.Commit();
                if (result > 0)
                {
                    Console.WriteLine("Data successfully deleted!");
                }
                else
                {
                    Console.WriteLine("Data deletion failed!");
                }

                connection.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                try
                {
                    transaction.Rollback();
                }
                catch (Exception rollback)
                {
                    Console.WriteLine(rollback.Message);
                }
            }

            Console.ReadLine();
        }

        public static void update(this Purchase beli, int idCari)
        {
            Console.Clear();
            connection = new SqlConnection(ConnectionString);

            connection.Open();

            SqlTransaction transaction = connection.BeginTransaction();
            try
            {
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "UPDATE purchase SET pID = " + Convert.ToString(beli.pID) + ", pDATE = '" + Convert.ToString(beli.pDATE) + "', pTOTAL = " + Convert.ToString(beli.pTOTAL) + ", pITEM = '" + beli.pITEM + "', pvID = " + Convert.ToString(beli.pvID) + ", pPAID = " + Convert.ToString(beli.pPAID) + " WHERE pID = " + idCari + ";";

                command.Transaction = transaction;

                int result = command.ExecuteNonQuery();

                transaction.Commit();
                if (result > 0)
                {
                    Console.WriteLine("Data successfully updated!");
                }
                else
                {
                    Console.WriteLine("Failed to update!");
                }

                connection.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                try
                {
                    transaction.Rollback();
                }
                catch (Exception rollback)
                {
                    Console.WriteLine(rollback.Message);
                }
            }

            Console.ReadLine();
        }
    }
}
