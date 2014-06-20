using System;

namespace Pluralsight.PostSharpV3
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            try
            {
                var nameReverser = new NameReverser();
                var returnValue = nameReverser.For("Sam");
                Console.WriteLine("Return: {0}", returnValue);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            Console.ReadKey();
        }
    }
}