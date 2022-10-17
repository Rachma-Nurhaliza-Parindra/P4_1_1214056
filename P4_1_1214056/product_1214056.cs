using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace P4_1_1214056
{
    public class product_1214056
    {
        //protected string myType = "Book";
        private string myType;
        private string myTitle;

        public product_1214056()
        {

        }
        public product_1214056(string type, string title)
        {
            this.myType = type;
            this.myTitle = title;
        }

        public string MyType 
        {
            get
            {
                return myType;
            }
            set
            {
                myType = value;
            }
        }
        public string MyTitle
        {
            get
            {
                return myTitle;
            }
            set
            {
                myTitle = value;
            }
        }
    }
}
