using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_app
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //öğrenci ve notlar isminde 2 tane array oluştur ardından kullanıcıdan 3 tane eleman eklet
            //ilk 2 öğrenci ad ve soyad yazdır.


            string[] ögrenci = new string[3];
            int[] not = new int[3];

            int total = 0;

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Lütfen öğrenci ismi giriniz:");
                ögrenci[i] = Console.ReadLine();
                Console.WriteLine("Lütfen öğrenci notunu giriniz :");
                not[i] = int.Parse(Console.ReadLine());

                total += not[i];

            }


            Console.WriteLine("******ÖĞRENCİ TABLOSU******");
            foreach(string a in ögrenci)
            {
                Console.WriteLine($"{a} -> öğrenci");
            }

            Console.WriteLine("******NOTE TABLOSU******");
            foreach (int x in not)
            {
                Console.WriteLine($"Note :{x}");
            }




            Console.WriteLine(total);
        }
    }
}
