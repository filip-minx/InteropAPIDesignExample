using System;

namespace CSAPI
{
    class Program
    {
        static void Main(string[] args)
        {
            var entity = new Entity();

            entity.Value = 123;

            Console.WriteLine(entity.Value);

            entity.Dispose();
           
            Console.ReadKey();
        }
    }
}
