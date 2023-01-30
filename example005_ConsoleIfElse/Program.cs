Console.WriteLine("Enter username");
string username = Console.ReadLine();

if(username.ToLower() == "masha")
{
    Console.Write(username);
    Console.WriteLine(" Приходи ко мне и полетели");
}
else
{
    Console.Write("Hello, ");
    Console.WriteLine(username);
}