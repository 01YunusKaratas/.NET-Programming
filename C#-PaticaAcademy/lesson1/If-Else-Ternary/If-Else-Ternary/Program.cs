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




            // IF,Else,Ternary dersi 
// Case ifadelerinin sırası önemli değildir.
// Bilinenin aksine default ifadesi en son yazılmak zorunda değildir.
// Default ifadesi zorunlu değildir. Yazılmasa da olur.


#region ifelseternary
/*bool condition = false;


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

   Console.WriteLine(sonuç);*/
#endregion


    
// IF,Else,Ternary dersi 
// Case ifadelerinin sırası önemli değildir.
// Bilinenin aksine default ifadesi en son yazılmak zorunda değildir.
// Default ifadesi zorunlu değildir. Yazılmasa da olur.


int month = DateTime.Now.Month;   //Ay bilgisini verdi

switch (month)
{
    case 1:

        Console.WriteLine("This month  is a : January");
        break;

    
    case 2:
        Console.WriteLine("This month  is a : February");
        break;
    
    case 3:

        Console.WriteLine("This month  is a : March");
        break;

    case 4:
        Console.WriteLine("This month  is a : April");
        break;

    case 5:
        Console.WriteLine("This month  is a : May");
        break;

    case 6:
        Console.WriteLine("This month  is a : June");
        break;


    case 7:
        Console.WriteLine("This month  is a : July");
        break;

    case 8:
        Console.WriteLine("This month  is a : Agust");
        break;

    case 9:
        Console.WriteLine("This month  is a : September");
        break;

    case 10:
        Console.WriteLine("This month  is a : October");
        break;

    case 11:
        Console.WriteLine("This month  is a : November");
        break;

    case 12:
        Console.WriteLine("This month  is a : December");
        break;

    default: 
        Console.WriteLine("...");
        break;
    //Default olmak zorunda değil her zaman

        }
    }
}
