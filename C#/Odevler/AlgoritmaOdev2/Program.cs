using System;
using System.Collections;

namespace csharpProgramlama
{

    class Program
    {

        static void KoleksiyonlarSoru1(){
            
            ArrayList asallar = new ArrayList();
            ArrayList asalOlmayanlar = new ArrayList();

            Console.WriteLine("20 adet sayi giriniz.");

            for(int i = 0; i < 8; i++){

                geri:
                try{   

                    Console.Write("{0}. sayi: ",i+1);

                    int sayi = int.Parse(Console.ReadLine());
                    int sayac = 0;

                    if(sayi == 1){
                        asalOlmayanlar.Add(sayi);
                        continue;
                    }

                    else if(sayi <= 0){
                        throw new Exception("Negatif ve numerik olmayan girdi yasak!");
                    }

                    else if(sayi == 2){
                        asallar.Add(sayi);
                        continue;
                    }
                    
                    for(int j = 2; j<sayi; j++){
                        
                        if(sayi % j == 0){
                            asalOlmayanlar.Add(sayi);
                            break;
                        }

                        else{
                            sayac++;
                            if(sayac == (sayi-2) ){
                                asallar.Add(sayi);
                                break;
                            }

                            continue;
                        }

                    }

                }

                catch(Exception){
                    Console.WriteLine("Negatif ve numerik olmayan girdi yasak!");
                    goto geri;
                }
            }

            asallar.Sort();
            asalOlmayanlar.Sort();
            
            asallar.Reverse();
            asalOlmayanlar.Reverse();

            

            Console.WriteLine("\nAsal Olanlar:");
            for(int i = 0; i < asallar.Count; i++ ){
                
                for(int j = i+1; j < asallar.Count; j++){
                    
                    if(asallar[i] == asallar[j]){
                        asallar.RemoveAt(asallar.IndexOf(asallar[j]));
                    }

                }

            }
            
            int asallarToplam = 0;
            
            foreach(int i in asallar){
                asallarToplam += i;
                Console.Write("{0},",i);
            }
            Console.WriteLine("Eleman Sayisi: {0} Ortalaması: {1}",asallar.Count,(asallarToplam/2));




            Console.WriteLine("\n");




            Console.WriteLine("\nAsal Olmayanlar:");
            for(int i = 0; i < asalOlmayanlar.Count; i++ ){
                
                for(int j = i+1; j < asalOlmayanlar.Count; j++){
                    
                    if(asalOlmayanlar[i] == asalOlmayanlar[j]){
                        asalOlmayanlar.RemoveAt(asalOlmayanlar.IndexOf(asalOlmayanlar[j]));
                    }

                }

            }

            int asalOlmayanlarToplam = 0;

            foreach(int i in asalOlmayanlar){
                asalOlmayanlarToplam += i;
                Console.Write("{0},",i);
            }
            Console.WriteLine("Eleman Sayisi: {0} Ortalaması: {1}",asalOlmayanlar.Count,(asalOlmayanlarToplam/2));
            
            

        }

        static void KoleksiyonlarSoru2(){
    
            int[] sayilar = new int[20];

            for(int i = 0; i < sayilar.Length; i++){
                Console.Write("{0}. sayı:",i+1);
                sayilar[i] = int.Parse(Console.ReadLine());
            }

            for(int i = 0; i < sayilar.Length; i++){
                
                for(int j = i+1; j < sayilar.Length; j++){

                    if(sayilar[i]< sayilar[j]){
                        int temp = sayilar[i];
                        sayilar[i] = sayilar[j];
                        sayilar[j] = temp;
                    }

                } 

            }
            int buyukort = 0;
            Console.WriteLine("En Buyuk:");
            for(int i = 0; i<3; i++){
                buyukort += sayilar[i];
                Console.Write("{0},",sayilar[i]);
            }
            buyukort = buyukort/2;
            Console.WriteLine("Ortalama: {0}",buyukort);

            int kucukort = 0;
            Console.WriteLine("En Kucuk:");
            for(int i = sayilar.Length-1; i>sayilar.Length-4; i--){
                kucukort += sayilar[i];
                Console.Write("{0},",sayilar[i]);
            }
            kucukort = kucukort/2;
            Console.WriteLine("Ortalama: {0}",kucukort);

            Console.WriteLine("Ortalama Toplamları: {0}",buyukort+kucukort);



        }


        static void KoleksiyonlarSoru3(){
            string sesliharfler = "AEIİOÖUÜaeıioöuü";

            Console.WriteLine("Bir cümle giriniz:");
            string cumle = Console.ReadLine();

            char[] dizi = new char[100];

            for(int i = 0; i < cumle.Length; i++){

                if(sesliharfler.Contains(cumle[i])){
                    
                    dizi[i] = cumle[i];

                }
                
            }

            for(int j = 0; j < dizi.Length; j++){

                for(int k = j+1; k < dizi.Length; k++){

                    if(dizi[j] < dizi[k]){
                        char temp = dizi[j];
                        dizi[j] = dizi[k];
                        dizi[k] = temp;
                    }
                    

                }

            }

            foreach(char i in dizi){
                Console.WriteLine(i);
            }
        }

        static void Main(string[] args)
        {
            //KoleksiyonlarSoru1();
            //KoleksiyonlarSoru2();
            KoleksiyonlarSoru3();
        }
    }
}
