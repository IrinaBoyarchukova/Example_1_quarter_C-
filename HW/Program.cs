// Написать программу, которая из имеющего массива строк формрует массив из строк, 
// длина которых меньше либо равно 3 символа. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма. 

string[] NewString (string[] array)
{
    string[] changedArray = new string [array.Length];
    int j = 0;
    for (int i=0; i<array.Length; i++)
    {
            if (array[i].Length <= 3)
            {
                changedArray[i] = array[i];
                j++;
            }
    }
    return changedArray;
}

string[] FillArray (int count)
{
    string[] newArray = new string[count];
    for (int i=0; i<count; i++)
    {
        Console.WriteLine ("Заполните массив элемент массива: ");
        newArray[i] = Console.ReadLine();
    }
    return newArray;
}

void PrintArray (string[] array)
{
    for (int i=0; i<array.Length; i++)
    {
        Console.Write ($" {array[i]} ");
    }
}


Console.WriteLine ("Введите количество элементов в массиве");
int a = int.Parse(Console.ReadLine());

string[] newArray = FillArray(a);
string[] changedArray = NewString(newArray);

PrintArray(changedArray);