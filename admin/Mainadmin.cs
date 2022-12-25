// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System;


namespace admin
{
    class Mainadmin
    {




        static void Main(string[]args){

            try
            {


                Testmoniter();


                //Testseruriteserverside();


            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        
        
        }


        static void Testseruriteserverside()
        {

            try
            {

                Console.WriteLine("test awdi");
                TcpChannel channel = new TcpChannel();
                ChannelServices.RegisterChannel(channel);

                securiteinterface.Interface1 remop = (securiteinterface.Interface1)Activator.GetObject(typeof(securiteinterface.Interface1), "tcp://localhost:5050/remop");
                Console.WriteLine(remop.ToString());
                Console.WriteLine("test admin part");

                int a = 10, b = 20;
                Console.WriteLine((remop.Testremote(a, b)).ToString());
                //System.Console.ReadLine();


            }
            catch (Exception e) { Console.WriteLine(e); }

        }


        static void Testmoniter()
        {

            try
            {

                TcpChannel channel = new TcpChannel();
                ChannelServices.RegisterChannel(channel);


                monitoringinterface.Moniterinterface moniobj = (monitoringinterface.Moniterinterface)Activator.GetObject(typeof(monitoringinterface.Moniterinterface), "tcp://localhost:7000/moniobj");
                Console.WriteLine(moniobj.Monitertemp());
                Console.WriteLine("temp is :");
                //Console.WriteLine(moniobj.Monitertemp());
            }
            catch(Exception e)
            {

                Console.WriteLine(e);

            }


        }




    }


}