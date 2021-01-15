using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Aula02_Threads_Join
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
            t.Join();

            Thread.Sleep(2000);
            Console.WriteLine("Thread principal parada por 2 segundos!");

            Console.ReadKey();
        }
    }
}
