using MatrixOperations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversitySystemProgrammingTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            MatrixWorker mo = new MatrixWorker();
            var result = mo.Process();
            for (int i = 0; i < result.GetLength(0); i++)
            {
                for (int j = 0; j < result.GetLength(1); j++)
                {
                    Console.Write($" |{result[i,j]}| ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
