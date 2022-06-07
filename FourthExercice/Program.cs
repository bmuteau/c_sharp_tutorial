string[] values = new string[3] ;

for(int i = 0; i < 3; i++)
{
    Console.WriteLine($"Veuiller saisir une valeur{i+1}");
    values[i] = Console.ReadLine();
}

for(int i = 0; i < 3; i++)
{
    Console.WriteLine(values[i]);
}
