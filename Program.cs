Console.Write("Enter your name: ");
string name = Console.ReadLine();
string greeting = $"Hello, {name}";
Console.WriteLine(greeting);

Console.WriteLine("Enter your age: ");
string ageAsString = Console.ReadLine();
Console.WriteLine("Converting...");
int age = Convert.ToInt32(ageAsString);
Console.WriteLine($"Successfully converted! {age}");