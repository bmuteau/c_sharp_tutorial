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
int userNumber = 0;
while(userNumber < 1 || userNumber > 100)
{
    Console.WriteLine("Veuillez saisir un nombre entre 1 et 100: ");
   
    try
    {
        userNumber = int.Parse(Console.ReadLine());
  
    }
    catch 
    {
        userNumber = 0;
    }

}
nbrUsed.Add(userNumber);
Console.WriteLine("Devine le chiffre mystère: ");




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
