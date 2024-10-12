using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //OBJECT ORIENTED PROGRAMMING
            //object oriented için 3 tane öneml işey var :Encapsulation, Polymorphısm,Inheritance 
            //C# da kalıtım  ':' ile gösteriliyor 
            //Eğer biz protected kullanırsak üst sınıf methodlarını , alt sınıfda da kullanmak istersek constructorı çağırıp ordan devam etmeliyiz 
            //ve bu işlemi yaparken yeni bir kelime olarak "base" anahtar kelimesini kullanıcaz javada ki super gibi.


            kuşlar k1 = new kuşlar(); //ınstance


            Console.WriteLine("***** Tohumsuz Bitkiler *****");

            tohumsuzBitkiler k=new tohumsuzBitkiler();//ınstance
            
            
            



          
        }
    }

    public class canlılar
    {

        protected  void beslenme()
        {
            Console.WriteLine("Canlılar Beslenir...");
        }

        protected void solunm()
        {

            Console.WriteLine("Canlılar solunum yapar..");
        }

    }

    public class bitkiler: canlılar
    {

        protected void fotosentez()
        {
            Console.WriteLine("Bitkiler fotosentez yapar.");
        }


       

    }
    public class tohumluBitkiler:bitkiler
    {
        public void tohumlaCogalma()
        {
            Console.WriteLine("Tohumlu bitkiler tohumla çoğalır.");
        }
    }


    public class tohumsuzBitkiler : bitkiler
    {
        public tohumsuzBitkiler()
        {
            base.beslenme(); //canlılardan geliyor
            base.solunm();//canlılardan geliyor
            base.fotosentez();//bitkiler sınıfından geliyor
            sporlaCogalma();//kendi methodu direk çağrılsın diye ekledim.
        }
        public void sporlaCogalma()
        {
            Console.WriteLine("Tohumsuz bitkiler sporlar çoğalır");
        }
    }


    public class  hayvanlar :canlılar
    {

       protected void adaptasyon()
        {
            Console.WriteLine("Hayvanlar adaptasyon kurabilir.");
        }
        
    }

    public class sürüngenler : hayvanlar
    {
        public void sürünme()
        {
            Console.WriteLine("Sürüngenler sürünerek hareket eder.");
        }
    }

    public class kuşlar : hayvanlar
    {   

        public kuşlar()
        { //burda bu işlemi yaparak direk üst sınıflardaki bilgileri sadece miras alan yerler kullanmasını sağladık

            base.adaptasyon();
            base.beslenme();
            base.solunm();

            uçmak();
        }
        
        public void uçmak()
        {
            Console.WriteLine("Kuşlar uçar");
        }
    }


}
