using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Numerics;

namespace arrayListapp;

class Program
{
    static void Main(string[] args)
    {

        //ArrayList ededler = new ArrayList();

        //ededler.Add(1);
        //ededler.Add(2);
        //ededler.Add(3);
        //ededler.Add(4);
        //ededler.Add(5);
        //ededler.Add(6);
        //ededler.Add(7);

        //foreach (int eded in ededler)
        //{
        //    if (eded%2==0||eded%5==0)
        //    {
        //        Console.WriteLine(eded);
        //    }


        //}

        //List<string> adlar = new List<string>();
        //adlar.Add("Samir");
        //adlar.Add("Nijat");
        //adlar.Add("Cavid");
        //adlar.Add("Eli");
        //adlar.Add("Mehdi");
        //adlar.Add("Mahir");

        //foreach (var ad in adlar)
        //{

        //    Console.WriteLine(ad);
        //}


        //Console.WriteLine(adlar.Count);


        //Console.WriteLine("----------------------");

        //adlar.Remove("Samir");
        //adlar.Remove("Nijat");

        //foreach (var ad in adlar)
        //{
        //    Console.WriteLine(ad);
        //}
        //Console.WriteLine(adlar.Count);

        //adlar.Insert(4,"Ersad");//isdediyimiz index e adin daxil edilmesi.

        //foreach (var ad in adlar)
        //{
        //    Console.WriteLine(ad);
        //}
        //Console.WriteLine("----------------------");
        //adlar.Sort();            //elifba sirasi ile yigilma

        //foreach (var ad in adlar)
        //{
        //    Console.WriteLine(ad);
        //}

        //Console.WriteLine("-----------------------");
        //adlar.Reverse();       //elifba sirasinin eksi
        //foreach (var ad in adlar)
        //{
        //    Console.WriteLine(ad);
        //}
        //Console.WriteLine(adlar[2]);

        //foreach (var ad in adlar)
        //{
        //    if (ad.StartsWith('M'))   //M herfi ile baslayan adlarin capi
        //    {
        //        Console.WriteLine(ad);
        //    }
        //}
        //ArrayList ededler = new ArrayList();


        //ededler.Add(1);
        //ededler.Add(2);
        //ededler.Add("samir");
        //ededler.Add(1.5);
        //ededler.Add(9);
        //foreach (var eded in ededler)
        //{
        //    Console.WriteLine(eded);
        //}

        List<string> telebeler = new List<string>();
        bool flag = true;
        do
        {

       
        Console.WriteLine("1.telebe elave et\n" +
            "2.telebeleri cap et\n" +
            "3.telebenin adini yenile\n" +
            "4.telebeni adina uygun sil\n" +
            "5.programdan cix");
        Console.WriteLine("zehmet olmasa secim edin");

        int addim = int.Parse(Console.ReadLine());
            switch (addim)
            {

                case 1:

                    Console.WriteLine("telebin adin daxil edin");
                    string telebeninAdi = Console.ReadLine();
                    telebeler.Add(telebeninAdi);break;

                case 2:


                    foreach (var telebe in telebeler)
                    {
                        Console.WriteLine(telebe);
                    } break;
                case 3:
                    


                    Console.WriteLine("yenilemek isdediyiniz telebenin sirasini daxil edin");
                    int telebesirasi = int.Parse(Console.ReadLine());
                    Console.WriteLine("telebenin yeni adini daxil edin");

                    string telebeninYeniAdi = Console.ReadLine();
                    telebeler[telebesirasi - 1] = telebeninYeniAdi;break;

                case 4:

                    Console.WriteLine("silmek isdediyiniz telebenin adini daxil edin");
                    string telebeAdiremov = Console.ReadLine();
                    telebeler.Remove(telebeAdiremov);break;
                case 5:
                    Console.WriteLine("siz programdan cixdiniz");
                  
                    flag = false;
                    break;

                default:
                    break;
            }

        //    if (addim==1)
                
        //{
        //    Console.WriteLine("telebin adin daxil edin");
        //    string telebeninAdi = Console.ReadLine();
        //    telebeler.Add(telebeninAdi);


        //}

        //else if (addim==2)
                
        //{
        //    foreach (var telebe in telebeler)
        //    {
        //        Console.WriteLine(telebe);
        //    }

        //}

        //else if (addim==3)
        //{
        //    Console.WriteLine("yenilemek isdediyiniz telebenin sirasini daxil edin");
        //    int telebesirasi = int.Parse(Console.ReadLine());
        //    Console.WriteLine("telebenin yeni adini daxil edin");

        //    string telebeninYeniAdi = Console.ReadLine();
        //    telebeler[telebesirasi-1] = telebeninYeniAdi;


        //}
        //    else if (addim==4)
        //    {


        //        Console.WriteLine("silmek isdediyiniz telebenin adini daxil edin");
        //        string telebeAdiremov = Console.ReadLine();
        //        telebeler.Remove(telebeAdiremov);


        //    }
        //    else if (addim==5)
        //    {
        //        Console.WriteLine("siz programdan cixdiniz");
        //        break;

        //    }

        } while (flag);



    }
}



//2. Telebe adlarini ozunde saxlayan list tanimla ve adlar elave ele.
//3. Icinden Nicat ve Samiri sil
//4. Count the Number of Student Names
//5. Insert a Student Name at a Specific Position
//6. Sort the Student Names Alphabetically
//7. Reverse the List of Student Names
//8. Update a Student Name
//9. Display Student Names That Start with a Specific Letter



//1. ArrayList tanimla ve icerisinfe 2 ve ya 5 e bolunenleri cap et.