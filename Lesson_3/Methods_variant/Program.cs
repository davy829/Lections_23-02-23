// вид 1
void Method1()
{
    Console.WriteLine("Autor...");
}
// Method1(); вызов метода , аргументов нет - ничего не возвращает !!!

// вид 2
void Method2(string msg)
{
    Console.WriteLine($" {msg}  @Autor...");
}
// Method2("New text:");  вызов метода , аргументы есть - ничего не возвращает !!!

// вид 2.1
void Method21(string msg, int count)
{
    int i = 1;
    while (i < count)
    {
        Console.WriteLine($" {i} - {msg} - {count - i} @Autor...");
        i++;
    }
}
//Method21(msg: "New text:", count: 5); // вызов метода , аргументы есть именованые - ничего не возвращает !!!


// ВИД 3

int Method3()
{
    return DateTime.Now.Year;
}

//int res = Method3(); // вызов здесь ! аргументов нет но вернет через ретерн год, дату, рандом ...
//Console.WriteLine(res);

// вид 4

string Method4(int count, string text)
{
    int i = 0;
    string res = string.Empty;
    while (i < count)
    {
     res = res + text;
     i++;
    }
    return res;
}
 
string resault = Method4(text:"z",count:5); // ловим в ресаулт работу метода , передаем ему аргументы
 Console.Write(resault);