using System;

namespace csharpProgramlama
{
    class Program
    {
        static void Main(string[] args)
        {


            void Soru1(){


                Console.Write("Adet: ");
                int adet = Convert.ToInt32(Console.ReadLine());

                int[] sayilar = new int[adet];

                Console.WriteLine("Sayilari giriniz. ");
                for(int i = 0; i < adet; i++){
                    Console.Write("{0}. sayı: ",i+1);
                    sayilar[i] = Convert.ToInt32(Console.ReadLine());
                }


                for(int i = 0; i < sayilar.Length; i++){
                    if(sayilar[i] % 2 == 0){
                        Console.Write(sayilar[i] + " ");
                    }
                }
                
            }

            void Soru2(){

                int sayi1,sayi2;
                Console.WriteLine("İki sayı giriniz.");
                Console.Write("1.sayı: ");
                sayi1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("2.sayı: ");
                sayi2 = Convert.ToInt32(Console.ReadLine());

                int[] dizi = new int[sayi1];
                Console.WriteLine("{0} adet sayı giriniz.",sayi1);
                
                for(int i = 0; i < sayi1; i++){
                    Console.Write("{0}. sayıyı giriniz: ",i+1);
                    dizi[i] = Convert.ToInt32(Console.ReadLine());
                }

                foreach(int i in dizi){
                    if( (i == sayi2) || (i % sayi2 == 0) ){
                        Console.Write("{0} ",i);
                    }
                }
            }

            void Soru3(){
                int adet;
                Console.Write("Adet: ");
                adet = Convert.ToInt32(Console.ReadLine());          

                string[] dizi = new string[adet];
                Console.WriteLine("{0} adet kelime giriniz.",adet);

                for(int i = 0; i < adet; i++){
                    Console.Write("{0}. kelimeyi giriniz: ",i+1);
                    dizi[i] = Console.ReadLine();
                }

                for(int i = adet-1; i >= 0; i--){
                    Console.Write("{0} ",dizi[i]);
                }        

            }

            void Soru4(){

                string cumle;
                Console.Write("Bir cümle yazın: ");
                cumle = Console.ReadLine();
                int toplam = 0;
                int harf = 0;
                foreach(string i in cumle.Split(" ")){
                    harf+=1;
                    toplam += i.Length;
                }

                Console.WriteLine("Toplam harf sayısı: {0} Toplam kelime Sayısı: {1}",toplam,harf);
            }
            
            //Soru1();
            //Soru2();
            //Soru3();
            //Soru4();

        }
    }
}
