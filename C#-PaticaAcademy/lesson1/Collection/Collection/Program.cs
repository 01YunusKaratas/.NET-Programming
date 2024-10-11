using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //Arraylerin içindeki elemanlar daima aynı türdür
            //koleksiyonlar nesnelerden oluşur 

            //Değer tipleri :int ,float,char,bool
            //Referans Tipleri : stringler,diziler,kolleksiyonlar ..


            // bir değeri tipini bir referans tipine dönüştürmeye BOXING tam tersine ise UNBOXING olayı deniyor 
            //Performans açısından bu değer tiplerini referans tiplere dönüştürmek zahmetli oluyor .
            //bu nedenle bu işlemlerden kaçınmak için generics gibi modern C# özelliklerini kullanmak daha verimli bir yaklaşım olacaktır.



            //LIST CLASS

           //List<T> class

            List<int> number = new List<int>();

            number.Add(1);
            number.Add(2);  
            number.Add(3);
                
            number.Add(4);
                
            number.Add(5);
            number.Add(6);
            number.Add(7);    


            List<string> color = new List<string>();

            color.Add("red");
            color.Add("yellow");
            color.Add("green");
            color.Add("blue");
            color.Add("purple");
            color.Add("black");



            foreach(int i in number)
            {
                Console.Write(i +" ");
            }

            foreach (string i in color)
            {
                Console.WriteLine(i + " ");


            }
            
            Console.WriteLine("Color count : "+color.Count);
            Console.WriteLine("Number count :"+number.Count);

            //basit ce direk foreach kullanma yöntemi 
            number.ForEach(x => Console.WriteLine(x));

            color.ForEach(x => Console.WriteLine(x));

            //remove collectiondan elemanı çıkarır direk 

            color.Remove("red"); //direk isim ile çıkarma var
            number.Remove(4);


            //removeAt var buda index ile çıkarma şekli

            color.RemoveAt(1);
            number.RemoveAt(3);

            // liste de var mı yok mu diye bakar contains arama yapar.

            Console.WriteLine(number.Contains(2));

            //Elemanı yazıp onun indeksine erişme BınarySearch ile yapılır.


            Console.WriteLine(color.BinarySearch("purple"));

            //Arrayı Kolleksiyona çevirme  işlemi böyle yapılır

            string[] str = { "elma", "armut", "çilek" };

            List<string> list = new List<string>(str);

            foreach(string s1 in list)
            {
                Console.WriteLine(s1);
            }



            list.Clear();
            foreach (string s1 in list)
            {
                Console.WriteLine(s1);
                Console.WriteLine("Liste boş");
            }

        }
    }
}
