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

            try {

                Console.WriteLine("test awdi");
                TcpChannel channel = new TcpChannel();
                ChannelServices.RegisterChannel(channel);


                securiteinterface.Interface1 remop = (securiteinterface.Interface1)Activator.GetObject(typeof(securiteinterface.Interface1), "tcp://localhost:5050/remop");
                Console.WriteLine(remop.ToString());
                Console.WriteLine("test admin part");

                int a=10 ,b=20 ;
                Console.WriteLine((remop.Testremote(a,b)).ToString());
                //System.Console.ReadLine();


            }
            catch (Exception e) { Console.WriteLine(e); }
        
        
        }





    }


}