using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Dictionary<int,string>countries=new Dictionary<int, string>();
            countries.Add(91, "India");
            countries.Add(1, "USA");
            countries.Remove(1);
            foreach(var item in countries)
            {
                Console.WriteLine(item.Key+" "+item.Value);
            }
            Console.ReadLine();
        }
    }
}
