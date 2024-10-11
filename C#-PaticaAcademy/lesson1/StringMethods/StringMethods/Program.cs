using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //String Methods

            string str = "hello c#";
            string str2 = "Hello c# example";



            Console.WriteLine(str.ToUpper()); //Bütün harfleri büyük hale çevirir

            Console.WriteLine(str.ToLower()); //bütün harfleri küçük hale getirir

            Console.WriteLine(str.Length); //kaç tane character olduğunu söyler
            Console.WriteLine(str.Replace("c#","C# lesson")); //metin içerisinde değiştirmek istenen kelimeyi değiştiririz

            Console.WriteLine(String.Concat(str," programming language"));  //concat elimizdeki değişkenle birleştirir verdiğimiz parametreyi


            Console.WriteLine(str.CompareTo(str2));/*değişken 1 büüykse karakter sayısı olarak değişken 2 den bu bize 1 döndürür ama
                                                    * değişken 1 küçükse değişken 2 den buda bize -1 döndürür*/;


            Console.WriteLine(String.Compare(str,str2,true)); //burada 3.parametre ignorcase demek buraya true dersek büyük küçük harf duyarsız olur false dersek duyarlı olur.


            Console.WriteLine(str.Contains("hello")); //contains de o metinde belirtilen karakter var mı yok mu diye bakılır .


            Console.WriteLine(str.EndsWith("c#")); // stringin sonun bunla bitiyor mu diye kontrol eder

            Console.WriteLine(str.StartsWith("el"));// string bunla başlıyor mu diye bakar ve ona göre yoluna devam eder.

            Console.WriteLine(str.IndexOf("c#")); // string içindeki index değerini dönderir.Ilk karakterin indexini dönderir birden fazla ise.


            Console.WriteLine(str.Insert(5," emre ")); //ilk parametre nerden başlıcağını söyler ,2. karakter ise ne eklemek istediğimizi söyler.



            //Bir stringin Sağ ve ya Sol tarafına istediğimiz kadar bir chacter ekleme şekli 
            Console.WriteLine(str.PadLeft(20,'*'));
            Console.WriteLine(str.PadRight(20,'*'));


            Console.WriteLine(str.Remove(3));  // Belirtilen index'ten itibaren tüm karakterleri siler.

            Console.WriteLine(str.Replace("c#"," C# "));//değiştirme işlemmi için kullanılır.


            Console.WriteLine(str.Substring(3));





        }
    }
}
