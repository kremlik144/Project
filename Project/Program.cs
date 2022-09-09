void PrintArray(string [] arr)
{
    int count = arr.Length;
    int position = 0;
    while(position < count)
    {
        if(position == 0) Console.Write($"[{arr[position]}, ");
        if(position > 0 && position < arr.Length -1) Console.Write($"{arr[position]}, ");
        if(position == arr.Length -1) Console.Write($"{arr[position]}]");
        
        position++;
    }
}


void ScanArray(string [] OldArray)
{
    int NewArraySize = 0;
    for(int i = 0; i < OldArray.Length; i++)
    {
        if(OldArray[i].Length <= 3) NewArraySize++;
    }
    
    string [] FinalArray = new string[NewArraySize];
    int count = 0;

    for(int i = 0; i < OldArray.Length; i++)
    {
        if(OldArray[i].Length <= 3) 
        {
            FinalArray[count] = OldArray[i];
            count++;
        }
    }

    if(NewArraySize == 0) Console.Write("В заданном массиве нет элементов, длина которых <= 3! ");
    else
    {
        Console.Write("Финальный массив: ");
        PrintArray(FinalArray);
    }
    
}



Console.Write("Введите произвольные элементы массива через запятую: ");
string array = Console.ReadLine();
string [] InitialArray = array.Split(", ");
Console.Write("Заданный пользователем массив: ");
PrintArray(InitialArray);
Console.WriteLine();
ScanArray(InitialArray);