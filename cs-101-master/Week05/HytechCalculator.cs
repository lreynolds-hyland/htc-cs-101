using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Enter num1");
		int num1 = Convert.ToInt32(Console.ReadLine());
		
		Console.WriteLine("Enter num2");
		int num2 = Convert.ToInt32(Console.ReadLine());
		
		Console.WriteLine("What Math Function to perform?");
		string operation = Console.ReadLine();
		
		if(operation == "+")
		{
			int sum = AddNumbers(num1, num2);
			Console.WriteLine(sum);
		}
		else if(operation == "-")
		{
			int difference = SubtractNumbers(num1, num2);
			Console.WriteLine(difference);
		}
		else if(operation == "*")
		{
			int product = MultiplyNumbers(num1, num2);
			Console.WriteLine(product);
		}
		else if(operation == "/")
		{
			int div = DivideNumbers(num1, num2);
			Console.WriteLine(div);
		}
	}
	
        
	/*
	public static void AddNumbers(int integer1, int integer2)
	{		
		Console.WriteLine(integer1 + integer2);
	}
	*/
	public static int AddNumbers(int integer1, int integer2)
	{		
		return integer1 + integer2;
	}
	
	public static int SubtractNumbers(int integer1, int integer2)
	{		
		return integer1 - integer2;
	}
	
	public static int MultiplyNumbers(int integer1, int integer2)
	{		
		return integer1 * integer2;
	}
	
	public static int DivideNumbers(int integer1, int integer2)
	{		
		return integer1 / integer2;
	}
}