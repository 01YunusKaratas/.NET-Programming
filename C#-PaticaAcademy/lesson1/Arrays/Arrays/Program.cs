using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Diziler dersi


            //Dizi tanımlama

            string[] color = new string[5];  //direk dizi boyutu belirleyerek yapabiliriz
            string[] colors = new string[] { }; //Boş dizi tanımlayabiliriz
            string[] colors2 = {"yellow","purple","black","red","green"}; //direk tanımlayabiliriz içerik ve boyutu


            int[] dizi;  //direk böyle birşey atamadan tanımlayabiliriz

            dizi = new int[5];

            dizi[0] = 0;
            dizi[1] = 1;
                
            dizi[2] = 2;
            dizi[3] = 3;
            dizi[4] = 4;


            //For each ile içeriğini döndürebiliriz.
            foreach(int i in dizi)
            {
                Console.WriteLine(i);
            }


            //Diğer örnek 

            Console.WriteLine("Sayı giriniz :");
            int num = Convert.ToInt32(Console.ReadLine());

            int[] arry =new int[num];

            int total = 0;

            Console.WriteLine($"{num} tane sayı giriniz :");
            for (int i = 0; i < num; i++)
            {
                
                arry[i] =Convert.ToInt32(Console.ReadLine());

            }

            foreach(int i in arry)
            {
                total += i;
                
            }

            Console.WriteLine($"TOTAL :{total}");
            Console.WriteLine($"AVERAGE : {(double)total/num}");

            
            //Array  Sınıfı Methodları 

            //Array.Sort

            //int[] sayılar = { 7,6,5,4,3,2,1 };

            //Array.Sort(sayılar);  // Diziyi küçükten büyüğe doğru sıraladı


            //Array.Clear(sayılar,0,sayılar.Length); //içerikleri sildi numeric dizi olduğu için sıfır olarak setledi

            //Array.Reverse(sayılar); //Diziyi tam tersi olucak şekilde çevirdi.

            // Console.WriteLine(Array.IndexOf(sayılar, 7)); //Dizinin içindeki sayıların indexini verir

            /*Array.Resize<int>(ref sayılar, 10);

            Bu function da Arrayi yeniden boyutlandırmaya yarıyor 
            sayılar[7] = 11;
            sayılar[8] = 12;
            sayılar[9] = 13;*/


            /*foreach (int i in sayılar)
            {
                Console.WriteLine(i);   
            }*/

            




        }
    }
}
