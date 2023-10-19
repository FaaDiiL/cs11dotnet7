namespace Packt.Shared; // file-scoped namespace
public class Person: Object
{
    public string? Name;
    public DateTime DateOfBirth;
    public WondersOfTheAncientWorld FavoriteAncientWonder;
    public WondersOfTheAncientWorld BucketList;
    public List<Person> Children = new();
    // constants
    public const string Species = "Homo Sapiens";
}
