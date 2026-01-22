Console.WriteLine("Hello, World!");// Run your first program
Console.WriteLine("Hello, World");

// Declare and use variables
string aFriend = "Bill";
Console.WriteLine("Hello " + aFriend);
aFriend = "Maria";
Console.WriteLine($"Hello {aFriend}");

// Work with strings
string firstFriend = "Maria";
string secondFriend = "Sage";
Console.WriteLine($"My friends are {firstFriend} and {secondFriend}");

Console.WriteLine($"The name {firstFriend} has {firstFriend.Length} letters.");
Console.WriteLine($"The name {secondFriend} has {secondFriend.Length} letters.");

// Remove whitespace from strings
string greeting = "          Hello World!         ";
Console.WriteLine($"[{greeting}]");

string trimmedGreeting = greeting.TrimStart();
Console.WriteLine($"[{trimmedGreeting}]");

trimmedGreeting = greeting.TrimEnd();
Console.WriteLine($"[{trimmedGreeting}]");

trimmedGreeting = greeting.Trim();
Console.WriteLine($"[{trimmedGreeting}]");

// Search and replace text in strings
string sayHello = "Hello World!";
Console.WriteLine(sayHello);
sayHello = sayHello.Replace("Hello", "Greetings");
Console.WriteLine(sayHello);

// Console.WriteLine(sayHello.ToUpper());
// Console.WriteLine(sayHello.ToLower());

string songLyrics = "I never said I'd be all right, just thought I could hold myself together.";
Console.WriteLine(songLyrics.Contains("all right"));
Console.WriteLine(songLyrics.Contains("apart"));

Console.WriteLine(songLyrics.StartsWith("I never said"));
Console.WriteLine(songLyrics.EndsWith("together."));
Console.WriteLine(songLyrics.StartsWith("bite the hand"));