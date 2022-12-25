// See https://aka.ms/new-console-template for more information
/*Console.WriteLine("Hello, World!");
*/

using System;

namespace monitoring
{


    class implmoniter : MarshalByRefObject, monitoringinterface.Moniterinterface
    {


        public override object InitializeLifetimeService()
        {


            return null;
        }   
        public double Monitergaz()
        {
            throw new NotImplementedException();

        }

        public double Moniterhumd()
        {
            //throw new NotImplementedException();
            return 70.50;
        }

        public bool Monitermovment()
        {
            throw new NotImplementedException();
        }

        public int Monitertemp()
        {
            //throw new NotImplementedException();
            return 40;

        }
    }



}