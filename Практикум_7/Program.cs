using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_1_к
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder strb;
            char buf;
            do
            {
                Console.Write("Введите строку: ");
                strb = new StringBuilder(Console.ReadLine());
                if(strb.Length == 0)
                    Console.WriteLine("В строке должен быть хотя бы один символ");
            } while (strb.Length == 0);
            Console.WriteLine("Исходная строка: " + strb);
            for (int i = 0; i + 2 <= strb.Length; i+=2)
            {
                buf = strb[i];
                strb[i] = strb[i + 1];
                strb[i + 1] = buf;
            }
            Console.WriteLine("Измененная строка: " + strb);
            Console.ReadLine();
        }
    }
}
