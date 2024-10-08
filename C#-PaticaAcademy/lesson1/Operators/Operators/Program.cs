using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Atama ve İşlemli Atama Operatörleri (=, +=, -=, *=, /=)
            // Mantıksal Operatörler (||, &&, !)
            // İlişkisel Operatörler (==,!=, <, >, >=,<=)
            // Aritmetik (+, -, *, /, %, ++, --)




            //1->  Atama ve İşlemli Atama Operatörleri (=, +=, -=, *=, /=)


            int x = 5;
            int y = 12;


            y = y + 2;  //artırmalı atama

            y += 2; // kısayolu

            Console.WriteLine(y);   
            Console.WriteLine(x);


            y /= 2;
            x *= 2;
            Console.WriteLine(x);
            Console.WriteLine(y);



            //2-> Mantıksal Operatörler

            int a = 5;
            int b = 12;

            if(a ==5 && b ==12)  //And operatörü
            {
                Console.WriteLine("A :"+a +"B:"+b);
                Console.WriteLine("Sayılar birbirine eşittir.");
            }

            bool c = false;
            bool d = true;


            if(d== true || c == true) //Or operatörü 
            {
                Console.WriteLine("D veya C den bir tanesi doğrudur");
            }


            int k = 12;

            if(k != 12) {

                Console.WriteLine("K 12 eşit değildir");
            }
            else
            {
                Console.WriteLine("K 12 eşittir");
            }

            //3->İlişkisel Operatörler (==,!=, <, >, >=,<=)


            int e = 5;
            int f = 4;

            bool sonuç = e<f;


            Console.WriteLine(sonuç);

            if(e == f)
            {
                Console.WriteLine($"{e} ,{f}  e eşittir");
            }else if (e > f)
            {
                Console.WriteLine($"{e} ,{f} ten büyüktür");
            }else if(e < f)
            {
                Console.WriteLine($"{f} ,{e}  ten küçüktür");
            }
            else
            {
                Console.WriteLine($"dOĞRU BİLGİ GİRİNİZ");
            }


            //4->Aritmetik (+, -, *, /, %, ++, --)


            int ömer = 5;
            int yavuz = 12;

            float result = (float)ömer * (float)yavuz;


            Console.WriteLine(result);


        }
    }
}
