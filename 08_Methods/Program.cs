﻿using System;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Void Metotlar

            //void CustomerList()
            //{
            //    Console.WriteLine("1. Ecem Yıldız");
            //    Console.WriteLine("2. Salih Değirmenci");
            //    Console.WriteLine("3. Aleyna Karacaöz");
            //    Console.WriteLine("4. Dünya Balçık");
            //}

            //CustomerList();
            //CustomerList();
            //CustomerList();
            //CustomerList();

            //void Sum()
            //{
            //    int x = 1, y = 2;
            //    int z = x + y;
            //    Console.WriteLine(z);
            //}

            //Sum();

            #endregion

            #region Geriye Değer Döndürmeyen String Parametreli Metotlar

            //void WriteMethod(string customerName)
            //{
            //    Console.WriteLine(customerName);
            //}

            //WriteMethod("Ecem Yıldız");

            //void CustomerCard(string name, string surname)
            //{
            //    Console.WriteLine("Müşteri: " + name + " " + surname);
            //}

            //CustomerCard("Funda", "Yıldız");
            //CustomerCard("Melisa", "Çelik");

            #endregion

            #region Geriye Değer Döndürmeyen Int Parametreli Metotlar

            //void Sum(int number1, int number2, int number3)
            //{

            //    int result = number1 + number2 + number3;
            //    Console.WriteLine(result);

            //}

            //Sum(2, 6, 9);
            #endregion

            #region Geriye Değer Döndüren Metotlar

            //string CustomerName()
            //{
            //    return "Ecem";
            //}

            //CustomerName();

            //string StudentCard()
            //{

            //    string name = "Tuğba";
            //    string surname = "Yıldız";

            //    return name + " " + surname;
            //}

            //Console.WriteLine(StudentCard());

            #endregion

            #region Geriye Değer Döndüren String Parametreli Metotlar

            //string CountryCard(string countryName, string capital, string flagColor)
            //{

            //    string cardInfo = "Ülke: " + countryName + " - Başkent: "
            //        + capital + " - Bayrak Rengi: " + flagColor;

            //    return cardInfo;
            //}

            //string x, y, z;

            //Console.Write("Ülke Adını Giriniz: ");
            //x = Console.ReadLine();

            //Console.Write("Başkenti Giriniz: ");
            //y = Console.ReadLine();

            //Console.Write("Bayrak Rengini Giriniz: ");
            //z = Console.ReadLine();

            //Console.WriteLine(CountryCard(x, y, z));
            //Console.WriteLine(CountryCard("Türkiye", "Ankara", "Kırmızı - Beyaz"));

            #endregion

            #region Geriye Değer Döndüren Int Parametreli Metotlar

            //int Sum(int number1, int number2)
            //{
            //    int result = number1 + number2;
            //    return result;
            //}

            //Console.WriteLine(Sum(14, 24));
            //Console.WriteLine(Sum(25, 35));
            //Console.WriteLine(Sum(36, 46));
            //Console.WriteLine(Sum(47, 57));

            #endregion

            #region Örnek Uygulama

            //string Examresult(string student, int exam1, int exam2, int exam3)
            //{
            //    int result = (exam1 + exam2 + exam3) / 3;

            //    if (result >= 50)
            //    {
            //        return student + " isimli öğrenci sınavı geçti. " + "Ortalama: " + result;
            //    }
            //    else
            //    {
            //        return student + " isimli öğrenci sınavı geçemedi. Ortalama: " + result;
            //    }
            //}

            //Console.WriteLine(Examresult("Ecem", 91, 85, 96));
            //Console.WriteLine(Examresult("Elif", 28, 75, 45));

            #endregion

            Console.Read();
        }
    }
}
