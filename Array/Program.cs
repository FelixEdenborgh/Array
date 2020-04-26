using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] myArray = {"Bmw", "Volvo", "Ford", "Audi", "Tesla"};
            

            Console.WriteLine(myArray[1]);

            int arrayLength = myArray.Length;

            for (int i = 0; i < arrayLength; i++)
            {
                Console.WriteLine(myArray[i]);
            }

            foreach (string car in myArray)
            {
                Console.WriteLine(car);
            }
        }
    }
}
