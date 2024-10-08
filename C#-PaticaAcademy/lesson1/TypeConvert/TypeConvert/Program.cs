using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeConvert
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Type conversions -> Implicit conversions(bilinçsiz)  and Explicit Conversion(Bilinçli)

            //Implicit dönüşümü biz hiçbir şey yapmadan makine yapıyor 


            byte a = 4;
            sbyte b = 5;
            short c = 6;


            int d = a+b + c;    

            Console.WriteLine(d);


            string name = "yunus emre karataş";
            char s = 'a';
            object k = name + s;

            Console.WriteLine(k);

            //Burada Implicit Conversions  oldu .



            //Explicit Conversions

            float e = 21.4f;

            int f = 32;


            double result = e + (double)f;  //Burada da Explicit  yapıyoruz yani kendi isteğimizle 
            
            Console.WriteLine(result);


            string sayı = "12";

            int sonuç =Convert.ToInt32(sayı) * 12;  //burada ise stringi inte çevirdik yani Explicit
            Console.WriteLine(sonuç);//Convert.To.. ile de olur istersek int.Parse() ilede olur.



            int xx = 66;

            string xy = "emre";


            string full = xy + xx.ToString();

            Console.WriteLine(full);    
        }
    }
}
