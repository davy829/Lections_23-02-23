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
    string res = string.Empty;
    int len = text.Length;
    for (int i = 0; i < len; i++)
    {
        if (text[i] == oldVal)
        {
            res = res + $"{newVal}";
             }
        else
                res = res + $"{text[i]}";
        
    }
       return res;
  }

string NewText = ChangSim(text, ' ', '|');
Console.Write(NewText);
Console.WriteLine("//");
string NewText2 = ChangSim(NewText, 'с', 'С');
Console.Write(NewText2);