using System;

namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            var meuArray = new int[5] {1,2,3,4,5};

            Console.WriteLine(meuArray[0]);
            Console.WriteLine(meuArray[1]);
            Console.WriteLine(meuArray[2]);
            Console.WriteLine(meuArray[3]);
            Console.WriteLine(meuArray[4]);

            //int[] meuArray2 = meuArray.Clone();

            for (var i = 0; i < meuArray.Length; i++)
            {
                Console.WriteLine(meuArray[i]);
                Console.WriteLine("For");
            
            } 

            foreach (var n in meuArray)
            {
                Console.WriteLine(n);
                Console.WriteLine("ForEach");

            }
        }
    }
}
