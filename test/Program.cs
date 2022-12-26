// See https://aka.ms/new-console-template for more information
using System;


using MySql.Data.MySqlClient;

namespace test

{

    class Program
    {

        static void Main(string[] args)
        {

            try
            {


                //MySqlSslMode mode = MySqlSslMode.None;
                string MyConnection2 = "datasource=localhost;port=3306;database=smarthome;username=root;password=4033;sslMode=None";
                string query = "SELECT * FROM smarthome.user";

                MySqlConnection con = new MySqlConnection(MyConnection2);
                MySqlCommand command = new MySqlCommand(query, con);
                con.Open();
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {

                    Console.WriteLine(reader.GetString("username"));

                }


            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);

            }


        }
    }
}