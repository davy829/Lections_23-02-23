// find in array
int[] massiv = { 12, 27, 83, 48, 5, 66, 75, 82, 93 };
int count = massiv.Length;
int find = 93;
int index = 0;
while (index < count)
{
  if (massiv[index] == find)
  {
    Console.WriteLine($" find: ind {index}, value {find}");
   
  }
  index++;
}