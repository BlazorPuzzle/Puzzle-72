namespace Puzzle72.Models;

public record Color(int Id, string Name);

public class Colors
{
	public static readonly Color[] List = [
		new Color(1, "Red"),
		new Color(2, "Green"),
		new Color(3, "Blue"),
		new Color(4, "Yellow"),
	];
}
