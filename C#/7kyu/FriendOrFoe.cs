namespace _7kyu;

public static class FriendOrFoe
{
    public static IEnumerable<string> Solution(string[] names)
    {
        return names.Where(n => n.Length == 4);
    }
}
