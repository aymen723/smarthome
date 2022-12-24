// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using securiteinterface;
using System;

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
    }
}