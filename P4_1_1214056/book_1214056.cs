using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_1_1214056
{
    internal class book_1214056: product_1214056
    {
        protected string pageCount;

        public book_1214056(string type, string title, string pageCount) : base(type, title)
        {
            this.pageCount = pageCount;
        }

        public string PageCount
        {
            get { return pageCount; }  
            set { pageCount = value; }
        }
    }
}
