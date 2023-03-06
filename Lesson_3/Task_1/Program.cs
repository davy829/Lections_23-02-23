//=====Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить чёрточками,
// маленькие буквы “к” заменить большими “К”,
// а большие “С” маленькими “с”.
// Ясна ли задача?
using System;

string text = "— Я думаю, — сказал князь, улыбаясь, — что,"
+ "ежели бы вас послали вместо нашего милого Винценгероде,"
 + "вы бы взяли приступом согласие прусского короля."
+ "Вы так красноречивы. Вы дадите мне чаю?";


string  ChangSim(string text, char oldVal, char newVal)
{
    string res = string.Empty;  //пременная для результата = пусая
    int len = text.Length;      // длинна текста сколько раз будем бегать
    for (int i = 0; i < len; i++)  // цикл фор
    {
        if (text[i] == oldVal)  // если символ по порядку равен заданному значению
        {
            res = res + $"{newVal}"; // меняем на новое
             }
        else
                res = res + $"{text[i]}"; // или оставим старое
        
    }
       return res; //вернем результат
  }

string NewText = ChangSim(text, ' ', '|');
Console.Write(NewText);
Console.WriteLine("//");
string NewText2 = ChangSim(NewText, 'с', 'С');
Console.Write(NewText2);