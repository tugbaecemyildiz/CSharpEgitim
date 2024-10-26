using System;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Double Değişkenler

            //double number;

            //number = 4.85;
            //Console.WriteLine(number);

            //Console.WriteLine("***** Fiyat Listesi *****");
            //Console.WriteLine();

            //double applePrice = 25.25;
            //double orangePrice = 29.99;
            //double strawberryPrice = 49.90;
            //double potatoPrice = 15;
            //double tomatoPrice = 20;

            //Console.WriteLine("--- Elma Birim Fiyatı: " + applePrice + " TL");
            //Console.WriteLine("--- Portakal Birim Fiyatı: " + orangePrice + " TL");
            //Console.WriteLine("--- Çilek Birim Fiyatı: " + strawberryPrice + " TL");
            //Console.WriteLine("--- Patates Birim Fiyatı: " + potatoPrice + " TL");
            //Console.WriteLine("--- Domates Birim Fiyatı: " + tomatoPrice + " TL");

            //double appleGram = 1.250;
            //double orangeGram = 2.350;
            //double strawberryGram = 1.500;
            //double potatoGram = 2.480;
            //double tomatoGram = 2.625;

            //double appleTotalPrice = appleGram * applePrice;
            //double orangeTotalPrice = orangeGram * orangePrice;
            //double strawberryTotalPrice = strawberryGram * strawberryPrice;
            //double potatoTotalPrice = potatoGram * potatoPrice;
            //double tomatoTotalPrice = tomatoGram * tomatoPrice;

            //Console.WriteLine("Alınan Ürün: Elma - Birim Fiyat: " + applePrice + " - Gramaj: " + appleGram + " - Toplam Tutar: " + appleTotalPrice);
            //Console.WriteLine("Alınan Ürün: Portakal - Birim Fiyat: " + orangePrice + " - Gramaj: " + orangeGram + " - Toplam Tutar: " + orangeTotalPrice);
            //Console.WriteLine("Alınan Ürün: Çilek - Birim Fiyat: " + strawberryPrice + " - Gramaj: " + strawberryGram + " - Toplam Tutar: " + strawberryTotalPrice);
            //Console.WriteLine("Alınan Ürün: Patates - Birim Fiyat: " + potatoPrice + " - Gramaj: " + potatoGram + " - Toplam Tutar: " + potatoTotalPrice);
            //Console.WriteLine("Alınan Ürün: Domates - Birim Fiyat: " + tomatoPrice + " - Gramaj: " + tomatoGram + " - Toplam Tutar: " + tomatoTotalPrice);


            //double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + tomatoTotalPrice + potatoTotalPrice;

            //Console.WriteLine();
            //Console.WriteLine();

            //Console.WriteLine("Alışveriş Toplam Tutarı: " + shoppingTotalPrice + " TL");

            #endregion

            #region Char Değişkenler
            //ABCDEFGH
            //DEF...
            //TOPLANTI SAAT 20:00'DE
            //"
            //char symbol;
            //symbol = 'a';
            //Console.WriteLine(symbol);
            #endregion

            #region Klavyeden Veri Girişleri String Değişkenler

            //Console.WriteLine("**** CSharp Hava Yolları Yolcu Bilgisi ****");
            //Console.WriteLine();

            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdentityNumber;

            //Console.Write("Yolcu Adı: ");
            //passengerName = Console.ReadLine();

            //Console.Write("Yolcu Soyadı: ");
            //passengerSurname = Console.ReadLine();

            //Console.Write("İlçe Bilgisi: ");
            //passengerDistrict = Console.ReadLine();

            //Console.Write("Şehir Bilgisi: ");
            //passengerCity = Console.ReadLine();

            //Console.Write("Yolcu Yaşı: ");
            //passengerAge = Console.ReadLine();

            //Console.Write("Yolcu TC Kimlik No: ");
            //passengerIdentityNumber = Console.ReadLine();

            //Console.WriteLine();

            //Console.WriteLine("----------------------------------");
            //Console.WriteLine("Yolcu TC Kimlik No: " + passengerIdentityNumber + " - Yolcu Ad Soyad: " + passengerName + " " + passengerSurname + " - " + passengerDistrict + "/" + passengerCity + " - Yaş: " + passengerAge);


            #endregion

            #region Klavyeden Tam Sayı Girişleri ve Dönüşümler

            // ABC120 

            // Ürünlerin fiyatlarını tutacak değişkenleri tanımlıyoruz.
            //int shoesPrice = 1000;
            //int computerPrice = 20000;
            //int chairPrice = 5000;
            //int tvPrice = 12000;

            //// Alınan ürün sayılarını tutacak değişkenleri tanımlıyoruz.
            //int shoesCount, computerCount, chairCount, tvCount;

            //// Kullanıcıdan ayakkabı sayısını alıyoruz.
            //Console.Write("Lütfen aldığınız ayakkabı sayısını giriniz: ");
            //shoesCount = int.Parse(Console.ReadLine());

            //// Kullanıcıdan ürün sayılarını alıyoruz
            //Console.Write("Lütfen aldığınız bilgisayar sayısını giriniz: ");
            // computerCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız sandalye sayısını giriniz: ");
            // chairCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız televizyon sayısını giriniz: ");
            // tvCount = int.Parse(Console.ReadLine());

            //// Ürünlerin toplam fiyatını hesaplıyoruz
            //// (Not: shoesCount ve shoesPrice değişkenleri daha önce tanımlanmış olmalı)
            //int totalPrice = (shoesCount * shoesPrice) + (computerCount * computerPrice) + (chairCount * chairPrice) + (tvCount * tvPrice);

            //// Toplam fiyatı ekrana yazdırıyoruz
            //Console.WriteLine();
            //Console.WriteLine("Toplam ödemeniz gereken tutar: " + totalPrice);

            #endregion

            #region Klavyeden Ondalıklı Sayı İşlemleri

            //// Üç sınav notunu tutacak değişkenleri tanımlıyoruz (double kullanarak ondalıklı sayıları da tutabiliriz)
            //double exam1, exam2, exam3, result;

            //// Kullanıcıdan sınav notlarını alıyoruz ve değişkenlere atıyoruz
            //Console.Write("Lütfen 1. sınav notunu giriniz: ");
            //exam1 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2. sınav notunu giriniz: ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 3. sınav notunu giriniz: ");
            //exam3 = double.Parse(Console.ReadLine());

            //// Girilen notların ortalamasını hesaplıyoruz
            //result = (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine();
            //// Sonucu ekranda gösteriyoruz
            //Console.WriteLine("Sınav Ortalamanız : " + result);

            #endregion

            #region Klavyeden Karakter Girişleri

            char gender; // Cinsiyeti saklamak için bir karakter değişkeni oluşturuyoruz

            Console.Write("Lütfen cinsiyetinizi seçiniz: "); // Ekrana bir mesaj yazdırıyoruz
            gender = char.Parse(Console.ReadLine()); // Kullanıcının girdiği değeri alıp gender değişkenine atıyoruz

            Console.WriteLine("Seçtiğiniz Cinsiyet: " + gender); // Seçilen cinsiyeti ekrana yazdırıyoruz

            #endregion

            Console.Read();
        }
    }
}
