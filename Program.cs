using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практика_6___задача_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {

                FileStream F = new FileStream("zd.txt", FileMode.Create, FileAccess.ReadWrite);
                byte[] x = new byte[10];
                int p;
                Console.WriteLine("Введите 10 чисел меньше 255");
                for (byte i = 0; i < 10;)
                {
                    p = int.Parse(Console.ReadLine());
                    if(p >= 255 || p < 0)
                        Console.WriteLine("Меньше 255 и больше 0!");
                    else
                    {                       
                        x[i] = (byte)p;
                        i++;
                    }
                }
                Console.WriteLine();
                F.Write(x, 0, 10);
                F.Seek(0, SeekOrigin.Begin);
                Console.WriteLine("Вывод только четных из них");
                int a;
                for (int i = 0; i < 10; i++)
                {
                    a = F.ReadByte();
                    if (a % 2 == 0)
                    {
                        Console.Write(a + "\t");
                    }
                }
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Ошибка работы с файлом: " + e.Message);
            }


        }
    }
}   
