const int mystereNumber = 42;

Console.WriteLine("Bienvenue dans le jeu du nombre mystère !");
Console.WriteLine("Veuillez saisir votre prénom: ");
string name = Console.ReadLine();

bool win = false;

List<int> nbrUsed = new List<int>();
string indication = "";

while(win == false)
{
Console.Clear();
Console.WriteLine(indication);
Console.Write("Nombre déjà joués: ");
foreach(int nbr in nbrUsed)
{
    Console.Write(nbr + " ");
}
Console.WriteLine();
Console.WriteLine("Devine le chiffre mystère: ");

int userNumber = int.Parse(Console.ReadLine());
nbrUsed.Add(userNumber);

if (mystereNumber == userNumber)
{
    win = true; 
    Console.WriteLine("Bravo, vous avez gagné!");
}
else
{
    if (mystereNumber > userNumber)
    {
        indication ="Le chiffre mystère est plus grand que " + userNumber;
    }
    else
    {
        indication = "Le chiffre mystère est plus petit que " + userNumber;
    }
}
}
