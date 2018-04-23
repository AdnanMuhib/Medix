using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Server
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public void registeruser(string username, string password)
        {
            UserClass u = new UserClass();
            u.Username = username;
            u.Password = password;
            UserDL.obj.Add(u);
        }

        public bool isvaliduser(string username, string password)
        {
            bool isfound = false;
            foreach (UserClass u in UserDL.obj)
            {
                if (u.Username == username && u.Password == password)
                {
                    isfound = true;

                }

            }
            return isfound;
        }

        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }
}
