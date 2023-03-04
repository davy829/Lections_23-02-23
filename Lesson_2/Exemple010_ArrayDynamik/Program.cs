void FullArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] =  new Random().Next(0, 10);
        index++;
    }

}
void PrintArray(int[] myArray)
{
    int length = myArray.Length;
    int position = 0;
    while (position < length)
    {
        Console.Write($"{myArray[position]}, ");
        position++;
    }

}

int IndexOff(int[] collection, int find)
{
    int length = collection.Length;
    int index = 0;
    int position = 0;
   while (index < length)
  {
   if (collection[index]== find)
   {
    position = index;
    break;
   }
    index++;
  }
  return position;
}

int[] massiv = new int[15];

FullArray(massiv);
PrintArray(massiv);
Console.WriteLine();
int pos = IndexOff(massiv,4);
Console.Write($"position : {pos}, value: 4");