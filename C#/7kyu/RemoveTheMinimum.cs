namespace _7kyu;

public static class RemoveTheMinimum
{
    public static List<int> RemoveSmallest(List<int> numbers)
    {
        if (numbers.Count == 0)
            return new();

        var min = numbers.Min();
        var removed = false;
        var newList = new List<int>();
        foreach (var n in numbers)
        {
            if (!removed && n == min)
                removed = true;
            else
                newList.Add(n);
        }
        return newList;
    }
}
