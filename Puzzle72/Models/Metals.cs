namespace Puzzle72.Models;

public record Metal(int Id, string Name);

public class Metals
{
	public static readonly Metal[] List = [
		new Metal(1, "Tin"),
		new Metal(2, "Steel"),
		new Metal(3, "Aluminum"),
		new Metal(4, "Iron"),
	];
}
