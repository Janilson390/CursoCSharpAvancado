using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _1_Introducao_Threads
{
    class Program
    {
        static void FazerAlgo()
        {
            Thread.Sleep(3000);
            Console.WriteLine("Terminei a tarefa!");
        }
        static void Main(string[] args)
        {
            Thread t = new Thread(new ThreadStart(FazerAlgo));

            t.Start();

            Thread.Sleep(4000);
            Console.WriteLine("Thread principal parada por 4 segundos!");

            Console.ReadKey();
        }
    }
}
