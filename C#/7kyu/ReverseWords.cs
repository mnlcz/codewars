namespace _7kyu;
public static class ReverseWords
{
	public static string Solution(string str)
	{
		return string.Join(' ', str.Split(' ').Select(s => new string(s.Reverse().ToArray())));
	}
}
