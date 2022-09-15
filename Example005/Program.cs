Console.WriteLine("Введите имя на латинице: ");
string userName = Console.ReadLine();
if (userName.ToLower() == "masha")
{
    Console.WriteLine("Ура! Это же Маша!");
}
else
{
    Console.Write("Привет ");
    Console.Write(userName);
}