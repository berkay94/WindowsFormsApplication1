using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

     

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList ul = new ArrayList();
            ul.Add("Reven");
            ul.Add("Merchant");
            ul.Add("Services");
            ul.Add(".Com");
            ul.Add("Author");
            ul.Add("Satalaj");
            ul.Add("More");
            ul.Add("Bird");
            ul.Add("Love");
            ul.Add("Asp");
            ul.Add("Random");
            ul.Add("Select");

            ArrayList ultemp = new ArrayList();

            Random r = new Random();

            for (int counter = 0; counter < 5; counter++)
            {

                int item = r.Next(ul.Count);

                ultemp.Add(ul[item]);

                ul.RemoveAt(item);

                Console.WriteLine("Randon item is {0}.", ultemp[counter]);

            }

            Console.ReadLine();
        }
    }
}
