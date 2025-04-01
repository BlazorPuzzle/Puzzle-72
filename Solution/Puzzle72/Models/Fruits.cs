namespace Puzzle72.Models;

public record Fruit(int Id, string Name);

public class Fruits
{
	public static readonly Fruit[] List = [
		new Fruit(1, "Apple"),
		new Fruit(2, "Orange"),
		new Fruit(3, "Banana"),
		new Fruit(4, "Mango"),
	];
}
