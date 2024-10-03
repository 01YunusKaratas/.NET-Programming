using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Ex1
            int age = 10;

            if (age < 10)
                Console.WriteLine("Küçük..");
            else if (age == 10)
                Console.WriteLine("Eşit..");
            else
                Console.WriteLine("Büyük..");
            Console.WriteLine("Yaş :" + age);

            #endregion

            #region Ex2
            int sayi = 10;

            Console.WriteLine(sayi++); // 10   11
            Console.WriteLine(--sayi);//  10     10
            Console.WriteLine(++sayi); // 11      11

            /*
             * 11 11 10    2
             * 10 10 11    10
             * 11 9  11    1 
             * 10 11 10    1
             */
            #endregion

            #region Ex3
            int opt = 5;
            switch (opt)
            {
                case 1:
                    Console.WriteLine("Seçim 1");
                    break;
                case 2:
                    Console.WriteLine("Seçim 2");
                    break;
                case 3:
                    Console.WriteLine("Seçim 3");
                    break;
                default:
                    Console.WriteLine("Yanlış Değer");
                    break;

            }
            #endregion

            #region Ex4
            string[] sehirler = new string[3] { "Manisa", "İzmir", "Aydın" };

            for (int i = 0; i < sehirler.Length; i++)
                Console.WriteLine(sehirler[i]);

            sehirler = new string[4];
            sehirler[3] = "Ankara";

            for (int i = 0; i < sehirler.Length; i++)
                Console.WriteLine(sehirler[i]);

            List<string> iller = new List<string> { "Manisa", "İzmir", "Aydın" };

            foreach (string s in iller)
                Console.WriteLine(s);
            iller.Add("Ankara");

            foreach (string s in iller)
                Console.WriteLine(s);

            int say = 5;
            while (say < 10)
            {
                say++;
                Console.WriteLine(say);

            }
            #endregion

            #region Ex5
            string cumle = "Manisa Celal Bayar Üniversitesi";

            var result = cumle.Length;// Karakter sayısı
            var result1 = cumle.Clone();//içeriği kopyalar
            var result2 = cumle.EndsWith("i");
            var result3 = cumle.IndexOf("Bayar");
            var result4 = cumle.LastIndexOf("kal");
            var result5 = cumle.Insert(0, "MCBU ");
            var result6 = cumle.Substring(15);
            var result7 = cumle.ToLower();
            var result8 = cumle.ToUpper();
            var result9 = cumle.Replace("Manisa", "İzmir");
            var result10 = cumle.Remove(0, 7);

            Console.WriteLine(result10);
            #endregion

            Console.ReadLine();
        }
    }
}
