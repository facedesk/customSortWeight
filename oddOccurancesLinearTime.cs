using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

public class Program
{
	public static void Main()
	{
		Console.WriteLine("Hello World");
		Console.WriteLine(FindOdd(new int[]{1,2,3,1,2,3,3}));
	}
	public static int FindOdd(int[] integers)
	{
		Dictionary<int,bool> currentOddOccurances = new Dictionary<int,bool>();
		
		Parallel.ForEach(integers, i=>
		{
			if(currentOddOccurances.ContainsKey(i))
			{
				currentOddOccurances.Remove(i);	
			}
			else
			{
				currentOddOccurances.Add(i,true);
			}
		});
		
		if(currentOddOccurances.Count != 1)
		{
			throw new ArgumentException(String.Format("{0} is a series of numbers that does not contain exactly one odd quantity", integers), "integers");
		}		
		return currentOddOccurances.First().Key;
	}
}
