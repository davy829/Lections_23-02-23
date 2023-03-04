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