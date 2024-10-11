using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTime_Math
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            //DATE TIME 
            //DateTime yunus = new DateTime();//böyle yaparasak başlangıçı 01.01.0001 alır onun yerine

            DateTime yunus = DateTime.Now;  


            Console.WriteLine(yunus.Hour);//şuan ki saati verir
            Console.WriteLine(yunus.Minute);//şuanki dakikayı verir
            Console.WriteLine(yunus.Second);//şuanki saniyeyi verir
            Console.WriteLine(yunus.Millisecond);//milisaniyeyi verir

            Console.WriteLine(yunus.Year);//yılı verir
            Console.WriteLine(yunus.Month);//yılın ayını verir
            Console.WriteLine(yunus.Day);//hangi günde oldğumuzu verir
            Console.WriteLine(yunus.Date); //Günü ayı yılı verir

            Console.WriteLine(yunus);  //sadece bunu yazarsam hem tarihi hem de saati dakika ve saniyeyle beraber verir

            Console.WriteLine(yunus.DayOfYear); //yılın kaçıncı günü olduğunu söyler
            Console.WriteLine(yunus.ToShortDateString()); //tam tarihi veriyor normal sistemdeki gibi

            Console.WriteLine(yunus.ToShortTimeString()); //direk laptoptaki gibi saati veriyor


            //add methodlarıda şuanki zaman üstüne eklemeler yapyıoruz

            //DateTime format
            Console.WriteLine("DATETİME FORMAT".PadRight(20,'*'));
            Console.WriteLine(yunus.ToString("dd"));
            Console.WriteLine(yunus.ToString("G"));
            Console.WriteLine(yunus.ToString("F"));


            //MATH LIBRARY

            Console.WriteLine(Math.Abs(-25));  //eksi değeri direk artı değer yapar
            Console.WriteLine(Math.Sin(90)); //SİN karşılığını veriyor
            Console.WriteLine(Math.Round(12.6)); // Hangisine yakınsa ona yuvarlar
            Console.WriteLine(Math.Ceiling(12.3));//daime yukarı yuvarlar  ceiling 
            Console.WriteLine(Math.Floor(12.9));//daime aşşağı yuvarlar floor


            Console.WriteLine(Math.Min(12,44));//2 sayıdan küçük olanıdönderir
            Console.WriteLine(Math.Max(33,412));//2 sayıdan büyük olanı dönderir.

            Console.WriteLine(Math.Pow(2, 5));//üssünü alır 
            Console.WriteLine(Math.Sqrt(81)); //karekökünü alır

            Console.WriteLine(Math.Log(9));// E tabanındaki logartirmik karşılığını getirir.

            Console.WriteLine(Math.Exp(3));//e üzeri verir



        }
    }
}
