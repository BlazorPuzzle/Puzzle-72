namespace Puzzle72.Models;

public record Language(int Id, string Name);

public class Languages
{
	public static readonly Language[] List = [
		new Language(1, "C#"),
		new Language(2, "JavaScript"),
		new Language(3, "Python"),
		new Language(4, "Haskell"),
	];
}
