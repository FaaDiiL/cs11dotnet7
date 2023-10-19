using Packt.Shared;

// Person bob = new Person(); // C# 1.0 or later
// var bob = new Person(); // C# 3.0 or later

Person bob = new();
WriteLine(bob.ToString());
bob.Name = "Bob Smith";
bob.DateOfBirth = new DateTime(1965, 12, 22); // C# 1.0 or later
WriteLine(format: "{0} was born on {1:dddd, d MMMM yyyy }",
    arg0: bob.Name,
    arg1: bob.DateOfBirth);

Person alice = new()
{
  Name  = "Alice Jones",
  DateOfBirth = new(1993,3,7)
};
WriteLine(format: "{0} was born on {1:dd MMM yy}",
    arg0: alice.Name,
    arg1: alice.DateOfBirth);

bob.FavoriteAncientWonder =
    WondersOfTheAncientWorld.StatueOfZeusAtOlympia;
WriteLine(
    format: "{0}'s favorite wonder is {1}. Its integer is {2}.",
    arg0: bob.Name,
    arg1: bob.FavoriteAncientWonder,
    arg2: (int)bob.FavoriteAncientWonder);