using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciSequence
{
	class Program
	{
		static void Main(string[] args)
		{
            int fib = int.Parse(Console.ReadLine());
			long prev = 1;
			long back = 0;
			long tmp = 0;
			for (long i = 0; i <= fib; i++)
			{
				Console.WriteLine(prev);
				tmp = prev;
				prev += back;
				back = tmp;
                
			}
			Console.ReadKey(true);
		}
	}
}
