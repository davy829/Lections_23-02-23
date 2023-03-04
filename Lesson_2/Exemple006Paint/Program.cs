Console.Clear();  // чистим консоль
int xa = 45, ya = 5,
    xb = 5, yb = 40,
    xc = 90, yc = 40; // определяем три точки в виде треугольника
Console.SetCursorPosition(xa, ya);
Console.WriteLine("+");
Console.SetCursorPosition(xb, yb);
Console.WriteLine("+");
Console.SetCursorPosition(xc, yc); // выводим треугольник
Console.WriteLine("+");   // из плюсов
int x = xa, y = xb;  
int count = 0;
while (count < 100000) //выполним 10000 раз
{
int num = new Random().Next(0, 3);  //произвольное число от 0 до 2 (3 не дает)
if (num == 0)
{
    x = (x + xa) / 2; //точка икс равна х+45 делить на два
    y = (y + ya) / 2; //точка игр равна у+5 делить на два
}
if (num == 1)
{
    x = (x + xb) / 2; //точка икс равна х+5 делить на два
    y = (y + yb) / 2; //точка икс равна у+40 делить на два
}
if (num == 2)
{
    x = (x + xc) / 2; //точка икс равна х+90 делить на два
    y = (y + yc) / 2; //точка икс равна у+40 делить на два
}
Console.SetCursorPosition(x,y); //рисуем все это 
Console.WriteLine("+");
count++;
}