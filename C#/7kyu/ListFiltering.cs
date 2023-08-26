namespace _7kyu;
public static class ListFiltering
{
	public static IEnumerable<int> Solution(List<object> listOfItems)
	{
		return listOfItems.OfType<int>();
	}
}
