namespace Puzzle72.Models;

public record Vegetable(int Id, string Name);

public class Vegetables
{
	public static readonly Vegetable[] List = [
		new Vegetable(1, "Celery"),
		new Vegetable(2, "Cabbage"),
		new Vegetable(3, "Onion"),
		new Vegetable(4, "Carrot"),
	];
}
