using System;

public class Program
{

	public static void Main()
	{
		
		Console.WriteLine("How many sides?");
		int dice = Int32.Parse(Console.ReadLine());
		Console.WriteLine(Roller(dice));		
		Console.ReadLine();					
	
	}
	
	static int Roller(int sides)
		{			
			Random rand = new Random();
			int roll = rand.Next(sides);
			return roll+1;
		}
	
}
