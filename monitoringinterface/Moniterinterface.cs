using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace monitoringinterface
{
    public interface Moniterinterface
    {


        int Monitertemp();
        double Moniterhumd();
        double Monitergaz();
        bool Monitermovment();



    }
}
