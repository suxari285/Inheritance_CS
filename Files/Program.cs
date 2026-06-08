//#define WRITE_TO_FILE
#define READ_FROM_FILE

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Diagnostics;

namespace Files
{
    internal class Program
    {
        static void Main(string[] args)
        {
#if WRITE_TO_FILE
            //1) создаем и открываем поток
            StreamWriter sw = new StreamWriter("File.txt");

            //2) Записываем вывод в файл:
            sw.Write("Hello World!");
            sw.WriteLine("Это запись в файл на языке C#");

            //3) закрываем поток
            sw.Close();

            Process.Start("notepad", "File.txt"); 
#endif
            //1)Создаем и открываем поток
            StreamReader sr = new StreamReader("File.txt");
            //2)читаем файл и выводи на консоль
            while(!sr.EndOfStream)
            {
                string buffer = sr.ReadLine();
                Console.WriteLine(buffer);
            }
            //3)Закрывем поток
            sr.Close();
        }
    }
}
