using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dictionary Dersi 

            //Key value pair den oluşur .

            //Key :Value

            Dictionary<int, string> dic = new Dictionary<int, string>();


            dic.Add(1, "yunus emre");
            dic.Add(2, "ömer yavuz");
            dic.Add(3, "kadir yıldız");
            dic.Add(4, "emre hasan");


            //Dictionary elemanlarına erişim 
            Console.WriteLine("------------Elemanlara Erişim------------");

            foreach (var i in dic)
            {
                Console.WriteLine(i);
            }

            //count

            Console.WriteLine(dic.Count);


            //Contains
            Console.WriteLine(dic.ContainsKey(1));
            Console.WriteLine(dic.ContainsValue("emre"));


            //KEYS AND VALUES

            foreach (var i in dic.Keys)
            {
                Console.WriteLine($"{i}");

            }


            foreach (var i in dic.Values)
            {
                Console.WriteLine($"{i}");

            }



        }

    }
}
