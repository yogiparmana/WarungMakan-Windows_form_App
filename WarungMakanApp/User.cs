using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarungMakanApp
{
    public class User
    {
        string b;
        public User(String a)
        {
            this.b = a;
        }
        public User()
        {
            nama = b;
        }
       

        public string nama { get { return b; } set {  } }
        public string tempt_duduk { get; set; }
    }
}
