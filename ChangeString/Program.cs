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
            string read2= Console.ReadLine();

            char let = char.Parse(read2);

            foreach (char i in read1)
            {
                if ( i == let)
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
