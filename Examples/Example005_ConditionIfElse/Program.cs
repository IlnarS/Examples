Console.WriteLine("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "ильнар")
{
    Console.WriteLine("Ура, это же Ильнар!!!");
}
else 
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}