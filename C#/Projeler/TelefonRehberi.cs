using System;
using System.Collections.Generic;

namespace csharpProgramlama
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonManager personManager = new PersonManager();

            anamenu:
            Arayuz.arayuz();

            
            String Entry = Console.ReadLine();
            while (true)
            {
                if (Entry == "1")
                {
                    personManager.personAdd();
                    goto anamenu;
                }
                else if (Entry == "2")
                {

                    personManager.personDelete();
                    break;
                }
                else if (Entry == "3")
                {
                    personManager.personUpdate();
                    break;
                }
                else if (Entry == "4")
                {
                    personManager.guideSearch();
                    break;
                }
                else if (Entry == "5")
                {
                    personManager.personSearch();
                    break;
                }
                else if (Entry == "6")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Geçersiz işlem");
                    Console.ReadLine();
                    break;
                }
            }
        }
    }

    public class Person
    {
        public string Name;
        public string lastName;
        public string Phone;

        public Person(string Name, string lastName, string Phone)
        {
            this.Name = Name;
            this.lastName = lastName;
            this.Phone = Phone;
        }
    }
    public class Arayuz
    {
        public static void arayuz()
        {
            Console.WriteLine(
                "(1) Yeni Numara Kaydetmek" +
                "\n(2) Varolan Numarayı Silmek" +
                "\n(3) Varolan Numarayı Güncelleme" +
                "\n(4) Rehberi Listelemek" +
                "\n(5) Rehberde Arama Yapmak" +
                "\n(6) Çıkmak için");
        }
    }
    public class People
    {
        public List<Person> person = new List<Person>();
        public void people()
        {
            person.Add(new Person("Ali", "Karagöz", "1234567"));
            person.Add(new Person("Berkay", "Çağlar", "12345678"));
            person.Add(new Person("Enes", "Alper", "123456789"));
        }
    }
    public class PersonManager : People
    {
        public void personAdd()
        {
            Console.WriteLine("İsminiz:");
            string name = Console.ReadLine();
            Console.WriteLine("Soyadınız:");
            string lastName = Console.ReadLine();
            Console.WriteLine("Telefon Numaranız:");
            string phone = Console.ReadLine();
            Person person = new Person(name, lastName, phone);

            Console.WriteLine("{0} HOŞGELDİN!", person.Name.ToUpper());
            
        }

        public void personDelete()
        {
            people();
            Console.WriteLine("Lütfen silmek istediğiniz kişinin ismini veya soyadını yazınız:");
            var search = Console.ReadLine();
            bool kayitvarmi = false;
            for (var i = 0; i < person.Count; i++)
            {
                if (search == person[i].Name || search == person[i].lastName)
                {
                    Console.WriteLine("Kullanıcı {0} silmek istediğinize eminmisiniz y/n", person[i].Phone);
                    var answer = Console.ReadLine();
                    kayitvarmi = true;

                    if (answer == "y")
                    {
                        Console.WriteLine("Başarı ile silinmiştir");
                    }
                }
            }
            if (!kayitvarmi)
            {
                Console.WriteLine("Böyle bir kullanıcı bulamadık");
            }
            Console.ReadLine();
        }
        public void personUpdate()
        {
            people();
            Console.WriteLine("Lütfen güncellemek istediğiniz kişinin ismini veya soyadını yazınız:");
            var search = Console.ReadLine();
            bool kayitvarmi = false;
            for (var i = 0; i < person.Count; i++)
            {
                if (search == person[i].Name || search == person[i].lastName)
                {
                    Console.WriteLine("Adı:{0}" +
                    "\nSoyadı:{1}" +
                    "\nNumarası:{2}" +
                    "\n**************", person[i].Name, person[i].lastName, person[i].Phone);
                }
            }
            if (!kayitvarmi)
            {
                Console.WriteLine("Böyle bir kullanıcı bulamadık");
            }
            Console.ReadLine();
        }

        public void guideSearch()
        {
            people();
            for (var i = 0; i < person.Count; i++)
            {
                Console.WriteLine("Adı:{0}" +
                "\nSoyadı:{1}" +
                "\nNumarası:{2}" +
                "\n**************", person[i].Name, person[i].lastName, person[i].Phone);
            }

            Console.ReadLine();

        }

        public void personSearch()
        {
            people();
            Console.WriteLine("Arama yapmak istediğiniz tipi seçiniz" +
                "\n**************************************" +
                "\nİsim ve Soyadına göre arama yapmak için (1)" +
                "\nNumaraya göre arama yapmak için (2)");
            var search = Console.ReadLine();
            if (search == "1")
            {
                Console.WriteLine("Lütfen arama yapmak istediğiniz kişinin adını veya soyadını yazınız");
                var answer = Console.ReadLine();
                bool kayitvarmi = false;
                for (var i = 0; i < person.Count; i++)
                {
                    if (answer == person[i].Name || answer == person[i].lastName)
                    {
                        Console.WriteLine("Adı:{0}" +
                        "\nSoyadı:{1}" +
                        "\nNumarası:{2}" +
                        "\n**************", person[i].Name, person[i].lastName, person[i].Phone);
                        kayitvarmi = true;
                    }
                }
                if (!kayitvarmi)
                {
                    Console.WriteLine("Böyle bir kullanıcı bulamadık");
                }
            }
            else if (search == "2")
            {
                Console.WriteLine("Lütfen numarayı tuşlayınız");
                string answer = Console.ReadLine();
                bool kayitvarmi = false;
                for (var i = 0; i < person.Count; i++)
                {
                    if (answer == person[i].Phone)
                    {
                        Console.WriteLine("Adı:{0}" +
                        "\nSoyadı:{1}" +
                        "\nNumarası:{2}" +
                        "\n**************", person[i].Name, person[i].lastName, person[i].Phone);
                        kayitvarmi = true;
                    }
                }
                if (!kayitvarmi)
                {
                    Console.WriteLine("Böyle bir kullanıcı bulamadık");
                }
            }
            else
            {
                Console.WriteLine("Geçersiz veye hatalı tuşlama yaptınız.");
            }
            Console.ReadLine();
        }

    }
}