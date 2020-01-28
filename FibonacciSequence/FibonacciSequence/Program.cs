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
            // int.Parse()は文字列型をint型にするもので、
            // Convert.ToInt16()はデータをint型にするもの
            // Convert.ToInt16()の方が便利ではある。
            int fib = int.Parse(Console.ReadLine());
			long prev = 1; // 前
			long back = 0; // 後
			long tmp = 0; //一時保存
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
