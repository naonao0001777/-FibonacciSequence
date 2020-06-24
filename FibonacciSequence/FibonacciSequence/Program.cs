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
			Console.WriteLine("n番目まで計算をします。nを入力。");
			
			int fib = int.Parse(Console.ReadLine());

			ulong prev = 1; // 前
			ulong forw = 0; // 後
			ulong tmp; //一時保存
			for (int i = 0; i <= fib; i++)
			{
                try
                {
					checked
					{
						Console.WriteLine(prev);
						tmp = prev;
						prev += forw;
						forw = tmp;
					}
				}
                catch(OverflowException e)
                {
					Console.WriteLine(e.Message);
					Console.WriteLine(i+"行目発生");
					break;
                } 
			}
			Console.ReadKey(true);
		}
	}
}
