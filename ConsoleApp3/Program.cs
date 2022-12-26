// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using securiteinterface;
using System;
using System.Collections;
using System.Collections.Generic;
using MySql.Data.MySqlClient;


namespace securiteserver
{


    class Program : MarshalByRefObject ,securiteinterface.Interface1
    {

        public override object InitializeLifetimeService()
        {

           
            return null;
        }

        public double Consommationenergy()
        {
            throw new NotImplementedException();

        }       

        public void Createuser(securiteinterface.user uuser)
        {
            throw new NotImplementedException();
        }

        public List<securiteinterface.user> History()
        {
            throw new NotImplementedException();
        }

       

        public void Showlive()
        {
            throw new NotImplementedException();
        }

        public void Stateofhouse()
        {
            throw new NotImplementedException();
        }

        public int Testremote(int a , int b)
        {
            //throw new NotImplementedException();
            int c;
            c = a + b;
            return c;
        }

        public List<user> Showall()
        {
            //throw new NotImplementedException();
            List<user> list = new List<user>();

            try
            {


                string MyConnection2 = "datasource=localhost;port=3306;database=smarthome;username=root;password=4033;sslMode=None";
                string query = "SELECT * FROM smarthome.user";

                MySqlConnection con = new MySqlConnection(MyConnection2);
                MySqlCommand command = new MySqlCommand(query, con);
                con.Open();
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {

                    user uuser = new user(Int32.Parse(reader.GetString("iduser")), reader.GetString("username"), reader.GetString("userprenom"), reader.GetString("userpassword"), reader.GetString("usertype"), reader.GetString("userbirthday"));
                    list.Add(uuser);
                    Console.WriteLine(uuser.username);
                    //Console.WriteLine(reader.GetString("username"));

                }





            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);


            }


            return list;



        }
    }
}