using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Akademi
{
    internal class program
    {

        static void Main(string[] args)
        {


            // Bir online bankacılık uygulamasından para gönderilirken, öncelikle limit kontrol edilecek. 
            //* Limit 0'dan büyükse para gönderme işlemi gerçekleştirilebilecek.
            //* Gönderilen para miktarı 100 türk lirasından az ise 1 tl ücret işlemi alınacak. 
            //* 100 lira ve 100 lira arasında ise 3 tl ücret işlemi alınacak.
            //* 1000 liradan fazla ise 5 tl ücret işlemi uygulanacak. 
            //Limit ve gönderilmek istenen para miktarı girildiğinde toplam tutarı ekrana yazdıran uygulamayı yaz.


            // bakiye = Lutfen bakiyenizi giriniz.
            // islemucreti = 0
            // if(bakiye <= 0){
            //
            // print Limitiniz yetersiz olduğundan işlem gerçekleştirilemiyor.
            // } 
            //  
            //  gonderilecekPara = Kac para gondermek istiyorsunuz?
            //
            //  if(gonderilecekPara < 100){
            //  islemucreti = 1
            //  gonderilekPara = gonderilekPara + islemucreti
            //  if(gonderilecekpara > bakiye){
            //
            //  print bakiyeniz yetersiz. Tekrar deneyin
            //  return
            //  }
            //      bakiye = bakiye - gonderilecekPara;
            //
            //      print islemUcreti + " tl islem ucreti kesildi. " + "Bakiyenizden " + gonderilecekPara  + " tl para kesildi. " + " Guncel Bakiyeniz: " + bakiye
            // }
            // 
            //  elseif(gonderilecekPara > 100 && gonderilecekPara < 1000)
            //  {
            //
            //  islemUcreti = 3
            //  gonderilekPara = gonderilekPara + islemucreti
            //  if(gonderilecekpara > bakiye)
            //    {
            //
            //  print bakiyeniz yetersiz. Tekrar deneyin
            //  return
            //    }
            //      bakiye = bakiye - gonderilecekPara;
            //      print islemUcreti + " tl islem ucreti kesildi. " + "Bakiyenizden " + gonderilecekPara  + " tl para kesildi. " + " Guncel Bakiyeniz: " + bakiye
            //  }
            //
            // elseif(gonderilecekPara > 1000)
            //  {
            //
            //  islemUcreti = 5
            //  gonderilekPara = gonderilekPara + islemucreti
            //  if(gonderilecekpara > bakiye)
            //    {
            //
            //  print bakiyeniz yetersiz. Tekrar deneyin
            //  return
            //    }
            //      bakiye = bakiye - gonderilecekPara;
            //      print islemUcreti + " tl islem ucreti kesildi. " + "Bakiyenizden " + gonderilecekPara  + " tl para kesildi. " + " Guncel Bakiyeniz: " + bakiye
            //  }
            //
            // else{
            //
            //
            //  print Gecersiz miktar girdiniz. Lutfen tekrar deneyiniz.
            // }

            Console.Write("Lutfen limitinizi giriniz: ");
            int bakiye = Convert.ToInt32(Console.ReadLine());
            int islemUcreti = 0;

            if (bakiye <= 0)
            {
                Console.WriteLine("Limitiniz yetersiz. Lutfen bakiyenizi kontrol edin.");
                return;
                Console.Read();
            }

            Console.Write("Gondermek istediginiz ucreti giriniz: ");
            int gonderilecekPara = Convert.ToInt32(Console.ReadLine());

            if (gonderilecekPara < 100)
            {

                islemUcreti = 1;

                gonderilecekPara = gonderilecekPara + islemUcreti;

                if (gonderilecekPara > bakiye)
                {

                    Console.WriteLine("Bakiyeniz yetersiz. Lutfen bakiyenizi kontrol edin.");
                    return;
                    Console.Read();

                }

                bakiye = bakiye - gonderilecekPara;

                Console.WriteLine(islemUcreti + " tl islem ucreti kesildi. " + "Bakiyenizden " + gonderilecekPara + " tl para kesildi. " + " Guncel Bakiyeniz: " + bakiye);
            }

            else if (gonderilecekPara > 100 && gonderilecekPara < 1000)
            {

                islemUcreti = 3;

                gonderilecekPara = gonderilecekPara + islemUcreti;

                if (gonderilecekPara > bakiye)
                {

                    Console.WriteLine("Bakiyeniz yetersiz. Lutfen bakiyenizi kontrol edin.");
                    return;
                    Console.Read();

                }

                bakiye = bakiye - gonderilecekPara;

                Console.WriteLine(islemUcreti + " tl islem ucreti kesildi. " + "Bakiyenizden " + gonderilecekPara + " tl para kesildi. " + " Guncel Bakiyeniz: " + bakiye);
            }

            else if (gonderilecekPara >= 1000)
            {

                islemUcreti = 5;

                gonderilecekPara = gonderilecekPara + islemUcreti;

                if (gonderilecekPara > bakiye)
                {

                    Console.WriteLine("Bakiyeniz yetersiz. Lutfen bakiyenizi kontrol edin.");
                    return;
                    Console.Read();

                }

                bakiye = bakiye - gonderilecekPara;

                Console.WriteLine(islemUcreti + " tl islem ucreti kesildi. " + "Bakiyenizden " + gonderilecekPara + " tl para kesildi. " + " Guncel Bakiyeniz: " + bakiye);
            }

            else
            {
                Console.WriteLine("Gecersiz miktar girdiniz. Lutfen tekrar deneyiniz.");
                return;
            }



        }

    }
}
