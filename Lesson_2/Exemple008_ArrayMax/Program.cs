int Max(int arg1, int arg2, int arg3)
{
    int resault = arg1;
    if (arg2 > resault) resault = arg2;
    if (arg3 > resault) resault = arg3;
    return resault;
}
int[] massiv = { 12, 27, 83, 48, 5, 66, 75, 82, 93 };
int max = Max(Max(massiv[0],massiv[1],massiv[2]),
              Max(massiv[3],massiv[4],massiv[5]),
              Max(massiv[6],massiv[7],massiv[8]));

Console.WriteLine(max);
