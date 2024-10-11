 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {

            worker w1 = new worker(); //ınstance
            
            w1.Show();

        }
    }



    class worker
    {

        public string name { get; set; }
        public int id { get; set; }
        public string surname { get; set; }
        public string department {  get; set; }
        

        //Static functionlar sınıfın örneğine bağlı kalmadan çalışırlar .Instance oluşturmadan stati methodlara ulaşılır direk.

        public string info()
        {
            Console.WriteLine("Enter the name :");
            name = Console.ReadLine();
            Console.WriteLine("Enter the surname :");
            surname=Console.ReadLine();
            Console.WriteLine("Enter the department :");
            department = Console.ReadLine();
            Console.WriteLine("Enter the ID:");
            id=int.Parse(Console.ReadLine());

            
            return $"NAME :{name} \n SURNAME:{surname} \n DEPARTMENT :{department} \n ID :{id}";

        }

        public  void  Show()
        {

            Console.WriteLine(info());


            
        }



    }
}