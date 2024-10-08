using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If_Else_Ternary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //IF,Else,Ternary dersi 


            bool condition = false;


            if (condition)
            {
                Console.WriteLine($"Condition is :{condition}");
            }
            else
            {
                Console.WriteLine($"Condition is : {condition}");
            }




            int time = DateTime.Now.Hour; //Şuanki saati alıyoruz

            

            if (time < 18)
            {
                Console.WriteLine("Gündüz vakti => Saat :" +time);
            }
            else
            {
                Console.WriteLine("Gece Vakti => Saat :" +time);
            }

            //yukarıda ki code yerine tek satırda Ternary Operatörü de kullanabiliriz

            string sonuç = time < 18 ? "Gündüz vakti" : "Gece vakti";

            Console.WriteLine(sonuç);
        }
    }
}
