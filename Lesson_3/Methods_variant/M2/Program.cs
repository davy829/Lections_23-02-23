// вид 2
void Method2(string msg)
{
    Console.WriteLine($" {msg}  @Autor...");
}
Method2("New text:"); // вызов метода , аргументы есть - ничего не возвращает !!!

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
Method21(msg: "New text:", count: 5); // вызов метода , аргументы есть именованые - ничего не возвращает !!!
