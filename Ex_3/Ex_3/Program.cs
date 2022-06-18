using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine(Fibbo(10));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            try
            {
                Console.WriteLine(Fibbo(1));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            try
            {
                Console.WriteLine(Fibbo(2));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            try
            {
                Console.WriteLine(Fibbo(30));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            try
            {
                Console.WriteLine(Fibbo(-25));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey(true);
        }
        /// <summary>
        /// Метод через рекурсию
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        static int FibboRec(int n)
        {
            if (n < 0)
            {
                throw new Exception("Число должно быть больше 0");
            }
            if (n == 0 || n == 1)
            {
                return n;
            }
            return FibboRec(n - 1) + FibboRec(n - 2);
        }
        /// <summary>
        /// Метод через цикл без рекурсии
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        static int Fibbo(int n)
        {
            if(n<0)
            {
                throw new Exception("Число должно быть больше 0");
            }
            int number = n;
            if(n==1)
            {
                Console.Write($"Число фиббоначи номер {number} = ");
                return n;
            }
            int frst = 0;
            int scnd = 1;
            int summa=0;
            while (n > 1)
            {
                summa = frst + scnd;
                frst = scnd;
                scnd = summa;
                n = n - 1;
            }
            Console.Write($"Число фиббоначи номер {number} = ");
            return summa;

        }
    }
}
