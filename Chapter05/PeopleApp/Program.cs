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

bob.BucketList =
    WondersOfTheAncientWorld.HangingGardensOfBabylon
    | WondersOfTheAncientWorld.MausoleumAtHalicarnassus;
// bob.BucketList = (WondersOfTheAncientWorld)18;
WriteLine($"{bob.Name}'s bucket list is {bob.BucketList}");

bob.Children.Add(new Person { Name = "Alfred" }); // C# 3.0 and later
bob.Children.Add(new() { Name = "Zoe" }); // C# 9.0 and later
WriteLine($"{bob.Name} has {bob.Children.Count} children:");
foreach (var t in bob.Children)
{
    WriteLine($"> {t.Name}");
}

BankAccount.InterestRate = 0.012M; // store a shared value
BankAccount jonesAccount = new();
jonesAccount.AccountName = "Mrs. Jones";
jonesAccount.Balance = 2400;
WriteLine(format: "{0} earned {1:C} interest.",
    arg0: jonesAccount.AccountName,
    arg1: jonesAccount.Balance * BankAccount.InterestRate);
BankAccount gerrierAccount = new();
gerrierAccount.AccountName = "Ms. Gerrier";
gerrierAccount.Balance = 98;
WriteLine(format: "{0} earned {1:C} interest.",
    arg0: gerrierAccount.AccountName,
    arg1: gerrierAccount.Balance * BankAccount.InterestRate);
WriteLine($"{bob.Name} is a {Person.Species}");

WriteLine($"{bob.Name} was born on {bob.HomePlanet}");

Person blankPerson = new();
WriteLine(format:
    "{0} of {1} was created at {2:hh:mm:ss} on a {2:dddd}.",
    arg0: blankPerson.Name,
    arg1: blankPerson.HomePlanet,
    arg2: blankPerson.Instantiated);
    
Person gunny = new("Gunny",  "Mars");
WriteLine(format:
    "{0} of {1} was created at {2:hh:mm:ss} on a {2:dddd}.",
    arg0: gunny.Name,
    arg1: gunny.HomePlanet,
    arg2: gunny.Instantiated);