using System;

namespace error
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            var arr = new int [3];
            
            for (var i = 0; i < arr.Length; i++)
            {
                try
                {
                    Console.WriteLine(arr[i]);
                    if (i == 2){
                        throw new Exception("Não pode ser 2");
                    }
                    
                }
                catch (System.Exception ex)
                {
                     // TODO
                     Console.WriteLine("Ops Algo deu errado");
                     Console.WriteLine(ex.Message);

                }finally{
                    Console.WriteLine("Finally");
                }
            }
        }
    }
}
