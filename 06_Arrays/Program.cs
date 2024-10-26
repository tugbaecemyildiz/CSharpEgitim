using System;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Temel Dizi Örnekleri

            //string[] colors = new string[4];
            //colors[0] = "Kırmızı";
            //colors[1] = "Sarı";
            //colors[2] = "Beyaz";
            //colors[3] = "Mavi";

            //Console.WriteLine(colors[2]);

            //string[] cities = new string[5];

            //cities[0] = "Madrid";
            //cities[1] = "Budapeşte";
            //cities[2] = "Lyon";
            //cities[3] = "Kahire";
            //cities[4] = "Üsküp";

            //Console.WriteLine(cities[2]);

            //int[] numbers = new int[10];

            //numbers[0] = 25;
            //numbers[1] = 35;
            //numbers[2] = 45;
            //numbers[3] = 55;
            //numbers[7] = 65;

            //Console.WriteLine(numbers[7]);

            //string[] cities = { "Londra", "Paris", "Atina", "Ankara", "Helsinki" };

            //Console.WriteLine(cities[2]);

            #endregion

            #region Dizideki Tüm Elemanları Listeleme

            //string[] colors = { "Sarı", "Kırmızı", "Beyaz", "Mavi", "Yeşil", "Turuncu", "Pembe" };

            //for (int i = 0; i < colors.Length; i++)
            //{
            //    Console.WriteLine(colors[i]);
            //}

            //int[] numbers = { 27, 16, 55, 83, 112, 155, 110, 2476, 3258, 1400 };

            //for (int i = 0; i < numbers.Length; i++)
            //{

            //    if (numbers[i] % 3 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            //char[] symbols = { 'a', 'b', 'c', '*', '/', '-' };
            //for (int i = 0; i < symbols.Length; i++)
            //{
            //    Console.WriteLine(symbols[i]);
            //}

            //int[] my_array = { 32, 75, 56, 14, 52, 430, 215, 850 };

            //int maxnumber = my_array[0];

            //for (int i = 0; i < my_array.Length; i++)
            //{
            //    if (my_array[i] > maxnumber)
            //    {
            //        maxnumber = my_array[i];
            //    }
            //}

            //Console.WriteLine(maxnumber);

            //string[] persons = { "Tuğba", "Ecem", "Yıldız", "Scarlet", "Funda", "Elena" };
            //Console.WriteLine(persons.Length);

            //int[] numbers = { 8, 12, 37, 18, 91, 23, 26 };

            //Array.Sort(numbers);

            //for (int i = 0; i < numbers.Length; i++) { 
            //    Console.WriteLine(numbers[i]);
            //}

            //int[] numbers = { 8, 12, 37, 18, 91, 23, 26 };
            //Array.Reverse(numbers);

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            #endregion

            #region Dizi Metodları

            //string[] customers = { "Tuğba", "Ecem", "Yıldız", "Scarlet", "Funda", "Elena" };
            //int index = Array.IndexOf(customers, "Scarlet"); index numarası

            //Console.WriteLine(index);

            //int[] numbers = { 45, 83, 96, 63, 74, 10, 25, 22, 36 };
            //Console.WriteLine("Dizinin En Büyük Elemanı: " + numbers.Max() 
            //    + "Dizinin en küçük elemanı: " +  numbers.Min());

            #endregion

            #region Kullanıcıdan Değer Alma

            //string[] cities = new string[5];

            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.Write($"Lütfen {i + 1}. Şehri Giriniz: ");
            //    cities[i] = Console.ReadLine();
            //}

            //Console.WriteLine();
            //Console.WriteLine("------------------------");

            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.WriteLine(cities[i]);
            //}

            //int[] numbers = { 14, 41, 57, 75, 55 };
            //int sum = 0;

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    sum += numbers[i];
            //}

            //Console.WriteLine(sum);

            //int[] numbers = { 38, 18, 27, 39, 62, 58, 414, 404, 321, 88 };
            //Console.WriteLine("Çift Sayılar");

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}
            //Console.WriteLine();
            //Console.WriteLine("Tek Sayılar");

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 1)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            #endregion

            Console.Read();
        }
    }
}
