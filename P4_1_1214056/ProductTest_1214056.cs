using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace P4_1_1214056
{
    internal class ProductTest_1214056
    {
        static void Main(string[] args)
        {
            /*product_1214056 myProduct = new product_1214056();

            myProduct.MyType = "DVD";

            Console.WriteLine(myProduct.MyType);*/

            book_1214056 product1 = new book_1214056("Book","c# Object Oriented Solution", "300");
            DVD_1214056 product2 = new DVD_1214056("She's Hulk", "110");

            /*Console.WriteLine("\"the book {0} has {1} pages\"",myBook.MyTitle, myBook.PageCount);*/
            Console.WriteLine("product 1 is a {0} called \"{1}\" and has {2} pages", product1.MyType, product1.MyTitle, product1.PageCount);
            Console.WriteLine("product 2 is a {0} called \"{1}\" and has {2} minutes duration", product2.MyType, product2.MyTitle, product2.Duration);
        }
    }
}
