namespace _7kyu;
public static class HourFormatConvert
{
	public static string Solution(int hours, int minutes, string period)
	{
		var m = minutes.ToString().Length == 1 ? $"0{minutes}" : minutes.ToString();
		string s;
		if (period == "am")
		{
			s = hours switch
			{
				12 => "00",
				11 or 10 => $"{hours}",
				_ => $"0{hours}"
			};
		}
		else
		{
			s = hours switch
			{
				12 => "12",
				_ => $"{12 + hours}"
			};
		}
		return s + m;
	}
}
