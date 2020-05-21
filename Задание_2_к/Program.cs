using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_2_к
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder strb;
            do
            {
                Console.Write("Введите осмысленный текст: ");
                strb = new StringBuilder(Console.ReadLine());
                if (strb.Length == 0)
                    Console.WriteLine("В строке должен быть хотя бы один символ");
            } while (strb.Length == 0);
            Console.WriteLine("Исходная строка: " + strb);
            for (int i = 0; i < strb.Length;)
                if (char.IsPunctuation(strb[i])) strb.Remove(i, 1);
                else i++;
            string str = strb.ToString();
            str = str.Trim();
            string[] s = str.Split(' ');
            bool prov;
            int n;
            do
            {
                Console.Write("Введите количество букв: ");
                prov = int.TryParse(Console.ReadLine(), out n);
                if (n <= 0)
                    prov = false;
                if (!prov)
                    Console.WriteLine("Некорректный ввод");
            } while (!prov);
            Console.Write("Слова, которые содержат не более чем  {0} букв: ", n);
            for (int i = 0; i < s.Count(); i++)
                if (s[i].Count() <= n)
                    Console.Write(s[i] + " ");
            Console.ReadLine();
        }
    }
}
