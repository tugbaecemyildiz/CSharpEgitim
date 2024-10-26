﻿using System;

namespace _07_ForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach Döngüsü

            //string[] cities = { "İstanbul", "Ankara", "Antalya", "Turku", "Helsinki", "Moskova" };

            //foreach (string x in cities)
            //{
            //    Console.WriteLine(x);
            //}

            //int[] numbers = { 75, 21, 95, 14, 86, 21, 93, 45, 41, 27, 63, 51 };

            //foreach (int i in numbers)
            //{
            //    Console.WriteLine(i);
            //}

            //int[] numbers = { 75, 21, 95, 14, 86, 21, 93, 45, 41, 27, 63, 51 };

            //foreach (int number in numbers)
            //{
            //    if (number % 2 == 0)
            //    {
            //        Console.WriteLine(number);
            //    }
            //}

            //int[] numbers = { 75, 21, 95, 14, 86, 21, 93, 45, 41, 27, 63, 51 };

            //int total = 0;

            //foreach (int i in numbers)
            //{
            //    total += i;
            //}

            //Console.WriteLine(total);

            //List<int> numbers = new List<int>() { 9, 8, 7, 6, 5, 4 };

            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //string word = "Hello";

            //foreach (char c in word)
            //{
            //    Console.WriteLine(c);
            //}

            #endregion

            #region Örnek Sınav Sistemi Uygulaması

            //Console.WriteLine("**** C# Eğitim Kampı Sınav Uygulaması ****");
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();

            //// Sınıftaki öğrenci sayısını kullanıcıdan alma
            //Console.WriteLine("-------------------------------");
            //Console.Write("Sınıfınızda Kaç Öğrenci var: ");
            //int studentCount = int.Parse(Console.ReadLine());
            //Console.WriteLine("-------------------------------");

            //// Öğrenci isimlerini ve not ortalamalarını saklayan diziler
            //string[] studentNames = new string[studentCount];
            //double[] studentExamAvg = new double[studentCount];

            //for (int i = 0; i < studentCount; i++)
            //{
            //    Console.Write($"{i + 1}. öğrencinin ismini giriniz: ");
            //    studentNames[i] = Console.ReadLine();

            //    double totalExamResult = 0;

            //    // Her öğrenci için 3 adet sınav notu girişi alıyoruz
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write($"{studentNames[i]} adlı öğrencinin {j + 1}. sınav notunu giriniz: ");
            //        double value = double.Parse(Console.ReadLine());
            //        totalExamResult += value;
            //    }
            //    Console.WriteLine();

            //    studentExamAvg[i] = totalExamResult / 3;
            //}

            //// Öğrencilerin sınav ortalaması
            //for (int i = 0; i < studentCount; i++)
            //{
            //    Console.WriteLine("-------------------------------");

            //    Console.WriteLine($"{studentNames[i]} adlı öğrencinin ortalaması: {studentExamAvg[i]}");

            //    // Öğrencilerin geçip kalma durumu
            //    if (studentExamAvg[i] >= 50)
            //    {
            //        Console.WriteLine($"{studentNames[i]} adlı öğrenci dersi geçti.");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{studentNames[i]} adlı öğrenci dersten kaldı.");
            //    }
            //    Console.WriteLine("-------------------------------");
            //    Console.WriteLine();
            //}
            #endregion

            Console.Read();
        }
    }
}
