using System.Text;

namespace _8kyu;

public static class FakeBinary
{
    public static string FakeBin(string x)
    {
        var sb = new StringBuilder();
        foreach (var c in x)
            sb.Append(char.GetNumericValue(c) < 5 ? '0' : '1');
        return sb.ToString();
    }
}
