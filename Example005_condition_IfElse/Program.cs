Console.WriteLine("Input name");
string username = Console.ReadLine();

if (username.ToLower() == "masha")
{
    Console.WriteLine("Wow it's Masha");
}
else
{
    Console.Write("Приувет, ");
    Console.WriteLine(username);
}