Console.Write("введите имя_ ");
//просим ввести имя
string username = Console.ReadLine();
// сохраняем имя в юзернэйм
if (username.ToLower() == "andrey")  // имя в любом регистре благодаря tolower
{
Console.WriteLine("Здраствуйте " + username ); //выводим если Andrey
}
else
{
Console.WriteLine("Idi na xyi: " + username );  //шлем на хуй если другое имя
}