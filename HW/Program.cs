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



