using Business.Concrete;
using Entities.Concrete;
using System;


namespace Workaround
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SelamVer("Murat");
            
            string[] ogrenciler = new string[3];
            ogrenciler[0] = "Murat";
            ogrenciler[1] = "Orçin";
            ogrenciler[2] = "Ali";

            ogrenciler = new string[4];
            ogrenciler[3] = "Ahmet";

            for (int i = 0; i < ogrenciler.Length; i++)
            {
                Console.WriteLine(ogrenciler[i]);
            }

            Person person1 = new Person();
            person1.DateOfBirthYear = 1983;
            person1.FirstName = "ALİ VELİ";
            person1.LastName = "PAYA";
            person1.NationalIdentity = 12345678902;

            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);
            
            Console.ReadLine();

        }

        static void SelamVer(string isim = "isimsiz")
        {
            Console.WriteLine("Merhaba " + isim);
        }


    }


}
