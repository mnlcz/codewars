namespace _8kyu;

public static class CountingSheep
{
    public static int CountSheeps(bool[] sheeps) => sheeps.Count(s => s == true);
}
