using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Runtime.Remoting;
//using System.Runtime.Remoting.Channels;
//using System.Runtime.Remoting.Channels.Tcp;

namespace securiteinterface
{
    public interface Interface1
    {

        void Showlive();
        void Stateofhouse();
        List<user> History();
        double Consommationenergy();
        void Createuser(user uuser);


    }
}
