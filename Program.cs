// See https://aka.ms/new-console-template for more information

//C1: New version
//Console.WriteLine("Hello, World!");

//C2: Older version
using System;

namespace L01_HelloWorld // Note: actual namespace depends on the project name.
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        /// <summary>
        /// phương thức trả về tổng của 2 số nguyên
        /// </summary>
        /// <param name="a">số nguyên 1</param>
        /// <param name="b">số nguyên 2</param>
        /// <returns>Tổng 2 số nguyên </returns>
        static int Tong(int a,int b){
            return a + b;
        }
    }
    class Run
    {
        static void Hello(){
            Console.WriteLine("Run Hello World");
        }
    }
}
