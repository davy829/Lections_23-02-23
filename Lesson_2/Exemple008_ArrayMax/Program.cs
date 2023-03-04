
int Max(int arg1, int arg2, int arg3)
{
    int resault = arg1;
    if (arg2 > resault) resault = arg2;
    if (arg3 > resault) resault = arg3;
    return resault;
}
int[] MyArray = { 12, 27, 83, 48, 5, 66, 75, 82, 93 };
int max = Max(Max(MyArray[0],MyArray[1],MyArray[2]),
              Max(MyArray[3],MyArray[4],MyArray[5]),
              Max(MyArray[6],MyArray[7],MyArray[8]));
Console.WriteLine(max);
