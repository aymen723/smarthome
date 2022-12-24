using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Runtime.Remoting;  
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;

namespace securiteserver
{
    internal class securitemain
    {
            

        static void Main(string[] args)
        {   

            ChannelServices.RegisterChannel(new TcpClientChannel(), false);



        }
    }
}
