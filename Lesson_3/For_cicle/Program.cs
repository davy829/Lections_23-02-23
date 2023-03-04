string Method4(int count, string text)
{
    string res = string.Empty;
    for (int i = 0; i < count; i++)
    {
    res = res + text;
    }
return res;
}
 
string resault = Method4(text: "z", count: 5); // ловим в ресаулт работу метода , передаем ему аргументы
Console.Write(resault);
