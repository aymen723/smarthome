using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace securiteserver
{
    public class User
    {

        int iduser;
        string username;
        string userprenom;
        string userpassword;
        string usertype;
        string userbirthday;

        public User(int id, string name ,string prenom,string password,string type,string birthday) { 
          iduser= id;
           username= name;
           userprenom= prenom;
           userpassword= password;
           usertype= type;
           userbirthday= birthday;


        
        }    




    }
}
