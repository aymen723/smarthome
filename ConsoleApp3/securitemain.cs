using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Runtime.Remoting;  
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using securiteinterface;

namespace securiteserver
{
    internal class securitemain
    {
            

        static void Main(string[] args)
        {


            try
            {
                TcpChannel channel = new TcpChannel (5050);
                ChannelServices.RegisterChannel(channel);
                RemotingConfiguration.RegisterWellKnownServiceType(typeof(securiteserver.Program), "remop", WellKnownObjectMode.Singleton);

                Console.WriteLine("Le serveur a démarré avec succès");
                Console.ReadLine();




            }
            catch (Exception ex)
            {


            }



        }
    }
}
