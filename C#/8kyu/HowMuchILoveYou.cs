namespace _8kyu;

public static class HowMuchILoveYou
{
    public static string Solution(int petals)
    {
        var output = "";
        var idx = 0;
        var values = new[]
        {
            "I love you",
            "a little",
            "a lot",
            "passionately",
            "madly",
            "not at all"
        };

        while (petals != 0)
        {
            output = values[idx];
            idx = idx == 5 ? 0 : idx + 1;
            petals--;
        }
        
        return output;
    }

}
