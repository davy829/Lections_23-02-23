int Max(int arg1, int arg2, int arg3)
{
    int resault = arg1;
    if (arg2 > resault) resault = arg2;
    if (arg3 > resault) resault = arg3;
    return resault;
}
int a1 = 15;
int a2 = 18;
int a3 = 22;
int b1 = 32;
int b2 = 58;
int b3 = 62;
int c1 = 85;
int c2 = 78;
int c3 = 452;
int max = Max(Max(a1,a2,a3),Max(b1,b2,b3),Max(c1,c2,c3));
Console.WriteLine(max);