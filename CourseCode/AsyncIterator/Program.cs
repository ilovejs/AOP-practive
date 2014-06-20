using System;

namespace Pluralsight.PostSharpV3.Iterator
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var customerRepository = new CustomerRepository();
            var names = customerRepository.GetAllNames();

            foreach (var name in names)
            {
                Console.WriteLine("Processed: {0}", name);
            }
            
            Console.ReadKey();
        }
    }
}