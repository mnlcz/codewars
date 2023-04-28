namespace _6kyu;

internal static class DetectPangram
{
    public static bool IsPangram(string str)
    {
        var strLower = str.ToLower();
        const string abc = "abcdefghijklmnopqrstuvwxyz";
        var reps = new Dictionary<char, int>();
        foreach (var l in abc) reps[l] = 0;
        foreach (var c in strLower)
        {
            if (!reps.ContainsKey(c)) continue;
            reps[c]++;
        }
        return reps.Values.All(x => x > 0);
    }
}
