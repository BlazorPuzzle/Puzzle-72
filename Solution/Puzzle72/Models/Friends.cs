namespace Puzzle72.Models;

public record Friend(int Id, string Name, string Email);

public class Friends
{
	public static readonly Friend[] List = [
		new Friend(1, "Carl Franklin", "carl@appvnext.com"),
		new Friend(2, "Jeff Fritz", "jeffreytfritz@gmail.com"),
		new Friend(3, "Dan Roth", "daniel.roth@microsoft.com"),
		new Friend(4, "Steve Sanderson", "steve.sanderson@microsoft.com"),
		];
}
