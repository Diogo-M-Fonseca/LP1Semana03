using System;

namespace ChangeString
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Insira uma string:");
            string read1= Console.ReadLine();
            Console.WriteLine("insira um caráter:");
            char read2= Console.ReadLine();

            foreach (char i in read1)
            {
                if ( i == read2)
                {
                    Console.Write("x");
                }
                else
                {
                    Console.Write(i);
                }


            }


        }
    }
}
