using System;

namespace ConvertAlgoDecToBi;

public class Program
{
	static void Main(string[]args)
	{
		Console.Write("Enter a number: ");
		int number = Convert.ToInt32(Console.ReadLine());
		string binary = Convert.ToString(number, 2);
		Console.WriteLine($"The Binary format for {number} is {binary}");

        Console.ReadLine();
    }
}