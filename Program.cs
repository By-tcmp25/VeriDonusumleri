using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriDönüşümleri
{
    class Program
    {
        static void Main(string[] args)
        {
            // ----------------------------------------------------------------------- VERİ DÖNÜŞÜMLERİ ------------------------------------------------------------------------------------


            // Veri dönüşümlerinde veri tiplerini str,int,double vs. gibi veri tiplerini başka veri tiplerine nasıl dönüştüğünü öğrenecegiz.
            
            string sayi = "150";        // burda string olarak yazıyı sayi değişkeninin içine kaydettik biz bununla matematiksel işlem yapamayız 
                                       //sadece string le yapabildiğimiz işlemleri yaptırabiliriz.
            int c  = int.Parse(sayi); //Pekiya matematiksel işlem yaptırmak istediğimizde ne yapacağız strin olan değeri inte çevircez aynı kodda da gördüğünüz gibi
                                     // int.Parse komutunu kullandık ve "sayi" değişkenini bizim için int'e dönüştürdü


            int A = Convert.ToInt32(sayi);  // burda da int.Parseyle aynı işlemi yaptı ama "sayi" değişkeninin içinde tutmadı onu bizim yazdığımız "A" değişkeninin  
                                           // içine kaydetti.
                                          // artık bunlarla matematiksel işlem yapabiliriz örneğin:
            int B = 45;

                Console.WriteLine(A*B); // burda dönüştürdüğümüz A değerini ve atamış int olarak atamış olduğumuz "B" değerini çarpmış olduk 150 yle 45 i çarparak 6750 sonucunu almış olduk
               


            double C = 7.813;             // Burda C değişkeninin içine doble atadık peki bunu nasıl int değerine dönüştürürüz.
            int D = Convert.ToInt32(C);  // int değerine dönüştürmek için Convert.ToInt32() kodunu kullandık C değişkenini int' e çevirip D değişkenine kaydettik.
                Console.WriteLine(D);   //  burda D değişkenini ekrana yazdırıyoruz bize verceği değer 8 olcak yanındaki küsüratı yuvarlayarak 8 değerini vercektir.
                


                Console.ReadLine();    // burda ekranda kalması için kullandık.




            //---------------------------------------------------------------------VERi DÖNÜŞÜMLERİ --------------------------------------------------------------------------------------





        }
    }
}
