using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Polymorphism  : bir nesnenin farklı sınıfların türünde davranabilmesi anlamına gelir ve genellikle method overriding ile ilişkilidir.
            //Polimorphism C# da hayatımıza bir tane daha kelime katıyor oda "virtual" anahtar kelimesi


            kedi kedi = new kedi();
            kedi.SesÇıkarır();

        }
    }


    public class Canlılar  // "sealed" kelimesi ni kullnarısak bir class için o classtan hiçbir örnek method kullanamayız.
                           //sealed anahtar kelimesi, bir sınıfın ya da metodun üst sınıftan miras alınmasını (inheritance) istemediğinde kullanılır.
    {
        protected void Beslenme()
        {
            Console.WriteLine("Canlılar Beslenir");
        }
        protected void Solunum()
        {
            Console.WriteLine("Canlılar solunum yapar");
        }

        protected void Boşaltım()
        {
            Console.WriteLine("Canlılar boşaltım yapar..");
        } 
        public  virtual void SesÇıkarır() //burada override alabilmek için VIRTUAL kelimesini kullanıyoruz
        {
            Console.WriteLine("Canlılar ses çıkarır.");
        }



    }


    public class kedi : Canlılar
    {
        public kedi()
        {
            base.Solunum();
            base.Boşaltım();
            base.Beslenme();

        }

        public override void SesÇıkarır() //override ile yukarıdaki virtual methodu alıyoruz.
        {
            base.SesÇıkarır();//bunu yaparsak üst sınfıdan gelen yazıyıda yazdırırız .
            Console.WriteLine("Kediler miyavlar");
        }
    }
}
