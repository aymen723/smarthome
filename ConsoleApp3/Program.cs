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

        public void Createuser(user uuser)
        {
            throw new NotImplementedException();
        }

        public List<user> History()
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

        public void Showall()
        {
            //throw new NotImplementedException();
            try
            {


                string MyConnection2 = "datasource=localhost;port=3306;username=aymen;password=4033";
                string query = "SELECT * FROM smarthome.user";
                MySqlConnection con = new MySqlConnection(MyConnection2);
                MySqlCommand command = new MySqlCommand(query, con);




            }
            catch(Exception e)
            {

                Console.WriteLine(e.Message);


            }



          

        }
    }
}