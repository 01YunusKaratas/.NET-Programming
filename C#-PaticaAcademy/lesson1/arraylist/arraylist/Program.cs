using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arraylist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ArrayListler sadece belli bir türe özgü değil her türü bir arada barındırma özelliği var 
            //Listler ise belli turleri tutabiliyorlar.
            ArrayList list = new ArrayList();
            list.Add(1);
            list.Add(2);

            list.Add("emre");
            list.Add("harun");
            list.Add("cemre");
            list.Add(true);

            foreach(var item in list)
            {
                Console.WriteLine(item);        
            }



            //addRange

            List<int> sarıamca = new List<int>();
            sarıamca.Add(1);
            sarıamca.Add(2);
            sarıamca.Add(65);
            sarıamca.Add(3);


            list.AddRange(sarıamca);


            int count = 0;
            foreach (var item in list)
            {   
                count++;    
                Console.WriteLine(item);
            }

            Console.WriteLine(count);


            //sort

            //list.Sort();  //direk yaparsak compare edemez içinde birden fazla farklı type var


            //BinarySearch 

            //önce kendi içinde sıralıcaz ve sonra binraysearch yapcaz



            //reverse
            list.Reverse();




        }
    }
}
