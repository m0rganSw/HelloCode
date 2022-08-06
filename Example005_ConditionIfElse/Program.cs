Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "viktor yeliseyev")
{
    Console.WriteLine("Здорова, братаааааан");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}