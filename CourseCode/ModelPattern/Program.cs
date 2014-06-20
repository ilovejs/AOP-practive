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
                string returnValue = nameReverser.For("Bobby");
                Console.WriteLine("Application Return: {0}", returnValue);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            Console.ReadKey();
        }
    }
}