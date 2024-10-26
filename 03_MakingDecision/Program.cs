using System;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If Else

            //Console.Write("Lütfen Şifreyi Giriniz: ");
            //string password;
            //password = Console.ReadLine();
            //if (password == "abcd")
            //{
            //    Console.WriteLine("Şifre Doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Şifre Yanlış");
            //}

            //string capital, country;
            //Console.WriteLine("Başkenti Giriniz: ");
            //capital = Console.ReadLine();

            //Console.WriteLine("Ülkeyi Giriniz: ");
            //country = Console.ReadLine();

            //if (capital=="ankara"&country=="türkiye")
            //{
            //    Console.Write("Veriler Doğrulandı");
            //}
            //else
            //{
            //    Console.Write("Veriler Yanlış");
            //}

            //int number;
            //Console.Write("Sayıyı Giriniz");
            //number = int.Parse(Console.ReadLine());
            //if (number == 5)
            //{
            //    Console.WriteLine("Sayı Doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı Yanlış");
            //}

            //int exam1, exam2, exam3, average;
            //string result=" Hata!";

            //Console.Write("Sınav 1: ");
            //exam1 = int.Parse(Console.ReadLine());
            //Console.Write("Sınav 2: ");
            //exam2 = int.Parse(Console.ReadLine());
            //Console.Write("Sınav 3: ");
            //exam3 = int.Parse(Console.ReadLine());

            //average = (exam1 + exam2 + exam3) / 3;
            //Console.Write("Sınavların  Ortalaması: " + average);

            //if (average > 0 & average <= 49)
            //{
            //    result = " Sonuç rezalet!";
            //}
            //if (average > 50 & average <= 69)
            //{
            //    result = " Sonuç Ortalama";
            //}
            //if (average > 70 & average <= 84)
            //{
            //    result = " Sonuç iyi";
            //}
            //if (average > 84)
            //{
            //    result = " Sonuç Harika!";
            //}
            //Console.WriteLine(result);

            //string city;
            //Console.Write("Lütfen şehir girin: ");
            //city = Console.ReadLine();

            //if (city == "adana" | city == "ankara" | city == "bursa" | city == "istanbul")
            //{
            //    Console.WriteLine("Şehir Mevcut");
            //}
            //else
            //{
            //    Console.WriteLine("Şehir Mevcut Değil");
            //}

            //Console.Write("Lütfen Kullanıcı Adını Girinz: ");
            //string username = Console.ReadLine();
            //if (username != "admin")
            //{
            //    Console.Write("Kabul edilemeyen kullanıcı adı..");
            //}
            //else
            //{
            //    Console.Write("Hoş geldiniz!");
            //}
            #endregion

            #region Mod İşlemleri

            //int number;
            //number = 26;
            //int result = number % 5;
            //Console.WriteLine(result);

            //Console.Write("Lütfen 1. Sayıyı Girin: ");
            //int number1 = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2. Sayıyı Girin: ");
            //int number2 = int.Parse(Console.ReadLine());

            //int result = number1 % number2;

            //Console.Write("1. sayının 2. sayıya bölümünden kalan: " + result);

            //Console.Write("Lütfen sayıyı girin: ");
            //int number = int.Parse(Console.ReadLine());

            //if (number % 2 == 0) 
            //{
            //    Console.Write("Çift Sayı");
            //}
            //else
            //{
            //    Console.Write("Tek Sayı");
            //}

            char team;
            Console.Write("Lütfen Takım Sembolünü Girin: ");
            team = char.Parse(Console.ReadLine());

            //if (team =='g' | team == 'G')
            //{
            //    Console.Write("Galatasaray");
            //}
            //if (team == 'b' | team == 'B')
            //{
            //    Console.Write("Beşiktaş");
            //}
            //if (team == 'f' | team == 'F')
            //{
            //    Console.Write("Fenerbahçe");
            //}


            Console.Read();
            #endregion
        }
    }
}
