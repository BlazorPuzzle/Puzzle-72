namespace Puzzle72.Models;

public record Pet(int Id, string Name);

public class Pets
{
	public static readonly Pet[] List = [
		new Pet(1, "Cat"),
		new Pet(2, "Dog"),
		new Pet(3, "Hamster"),
		new Pet(4, "Dinosaur"),
	];
}