// See https://aka.ms/new-console-template for more information
Console.WriteLine("Comment t'appelles tu ?");
string name = Console.ReadLine();

Console.WriteLine("Quel est ton âge ?");
int age = int.Parse(Console.ReadLine());

// Console.WriteLine($"Bonjour {name}, tu as {age} ans.");
Console.WriteLine("Bonjour " + name + ", tu as " + age + " ans.");

if (age >= 18)
{
    Console.WriteLine("Tu es majeur.");
}
else
{
    Console.WriteLine("Tu es mineur.");
}

