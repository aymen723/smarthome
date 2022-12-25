using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;



namespace monitoring
{
    public class Mainmoni
    {
        static void Main(string[] args)
        {

            TcpChannel channel = new TcpChannel(7000);
            ChannelServices.RegisterChannel(channel);
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(monitoring.implmoniter), "moniobj", WellKnownObjectMode.Singleton);



            Console.WriteLine("Le serveur a démarré avec succès");
            Console.ReadLine();
        }



    }
}
