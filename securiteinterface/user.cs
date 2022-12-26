using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace securiteinterface
{
    [Serializable()]
    public class user : ISerializable
    {
    
        public string username;
        public string userprenom;
        public string userpassword;
        public int iduser;
        public string userbirthday;
        public string usertype;

        public user(int id, string name, string prenom, string password, string type, string birthday)
        {


            iduser = id;
            username = name;
            userprenom = prenom;
            userpassword = password;
            usertype = type;
            userbirthday = birthday;

        }


        public user(SerializationInfo info ,StreamingContext ctxt)
        {


            iduser =(int) info.GetValue("id",typeof(int));
            username = (string)info.GetValue("username", typeof(string));
            userprenom = (string)info.GetValue("userprenom", typeof(string));
            userpassword = (string)info.GetValue("userpassword", typeof(string));
            usertype = (string)info.GetValue("usertype", typeof(string));
            userbirthday = (string)info.GetValue("userbirthday", typeof(string));

        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            //throw new NotImplementedException();

            info.AddValue("id", iduser);
            info.AddValue("username", username);
            info.AddValue("userprenom", userprenom);
            info.AddValue("userpassword", userpassword);
            info.AddValue("usertype", usertype);
            info.AddValue("userbirthday", userbirthday);




        }
    }
}
