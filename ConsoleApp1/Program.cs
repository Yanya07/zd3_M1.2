using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество простых чисел (K): ");
            int K = int.Parse(Console.ReadLine());
            int[] primes = new int[K];// Переменная для хранения найденных простых чисел
            int count = 0;// Счетчик найденных простых чисел
            int number = 2;// Переменная для проверки чисел на простоту

            while (count < K)// Цикл продолжается, пока не будет найдено K простых чисел
            {
                if (IsPrime(number))
                {
                    primes[count] = number;
                    count++;
                }
                number++;
            }
            Console.WriteLine("Первые {0} простых чисел:", K);// Выводим простые числа по 10 на строке
            for (int i = 0; i < primes.Length; i++)
            {
                Console.Write(primes[i] + "\t");
                if ((i + 1) % 10 == 0)// Переход на новую строку после каждых 10 чисел
                {
                    Console.WriteLine();
                }
            }
            Console.WriteLine("\nНажмите Enter, чтобы закрыть программу.");
            Console.ReadLine();
        }
        static bool IsPrime(int num)// Метод для проверки числа на простоту
        {
            if (num <= 1)
            {
                return false;
            }
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
