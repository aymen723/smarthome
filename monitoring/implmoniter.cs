// See https://aka.ms/new-console-template for more information
/*Console.WriteLine("Hello, World!");
*/

using System;

namespace monitoring
{


    class implmoniter : MarshalByRefObject, monitoringinterface.Moniterinterface
    {
        public double Monitergaz()
        {
            throw new NotImplementedException();
        }

        public double Moniterhumd()
        {
            throw new NotImplementedException();
        }

        public bool Monitermovment()
        {
            throw new NotImplementedException();
        }

        public int Monitertemp()
        {
            throw new NotImplementedException();
        }
    }



}