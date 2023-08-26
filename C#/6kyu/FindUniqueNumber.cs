namespace _6kyu;
public static class FindUniqueNumber
{
	public static int Solution(IEnumerable<int> numbers)
	{
		var reps = new Dictionary<int, int>();
		foreach (var number in numbers) 
		{
			if (reps.ContainsKey(number))
				reps[number]++;
			else
				reps[number] = 1;
		}
		return reps.First(x => x.Value == 1).Key;
	}
}
