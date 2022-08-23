int [] array = new int[8];

void FillArray(int[] elements)
{
    int length = elements.Length;
    int index = 0;
    while (index < length)
    {
        elements[index] = new Random().Next(1, 100);
         index++;
    }

}

void PrintArray(int[] el)
{
    int count = el.Length;
    int position = 0;
    while(position < count)
    {
      Console.WriteLine(el[position]);
        position++;
    }
}


FillArray(array);
PrintArray(array);
