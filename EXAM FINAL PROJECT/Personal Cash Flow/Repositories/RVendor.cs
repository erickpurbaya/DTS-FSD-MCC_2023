using Personal_Cash_Flow.View;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Personal_Cash_Flow.Model
{
    public static class Vendor2
    {
        static string ConnectionString = "Data Source=CRESTO;Initial Catalog=PersonalCashFlow;Integrated Security=True;Connect Timeout=30;";

        static SqlConnection connection;

        public static void getAll()
        {
            Console.Clear();
            connection = new SqlConnection(ConnectionString);

            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "SELECT * FROM vendor;";

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

                OutputVendor.voutputShowReader(reader);
            }
            //Jika tidak, maka database kosong.
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

        public static void getById(int identity)
        {
            Console.Clear();
            connection = new SqlConnection(ConnectionString);

            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "SELECT * FROM vendor WHERE vID = " + identity;

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
                OutputVendor.voutputShowReader(reader);
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
            command.CommandText = "SELECT * FROM vendor WHERE vID = " + identity;

            connection.Open();

            using SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                OutputVendor.voutputShowReader(reader);
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

        public static void add(this Vendor supplier)
        {
            Console.Clear();
            connection = new SqlConnection(ConnectionString);

            connection.Open();

            SqlTransaction transaction = connection.BeginTransaction();
            try
            {
                SqlCommand command = new SqlCommand();
                command.Connection = connection;

                command.CommandText = "INSERT INTO vendor VALUES (" + Convert.ToString(supplier.vID) + ", '" +  supplier.vNAME + "', '" + supplier.vORIGIN + "', '" + supplier.vTYPE + "', " + Convert.ToString(supplier.vVERIFIED) + ");";

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
            Console.ReadLine();

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
                command.CommandText = "DELETE FROM vendor WHERE vID = " + idCari;
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

        public static void update(this Vendor supplier, int idCari)
        {
            Console.Clear();
            connection = new SqlConnection(ConnectionString);

            connection.Open();

            SqlTransaction transaction = connection.BeginTransaction();
            try
            {
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "UPDATE vendor SET vID = " + supplier.vID + ", vNAME = '" + supplier.vNAME + "', vORIGIN = '" + supplier.vORIGIN + "', vTYPE = '" + supplier.vTYPE + "', vVERIFIED = " + supplier.vVERIFIED + " WHERE vID = " + idCari;
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
