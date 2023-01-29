// Задача: Написать програмуу, которая из имеющегося массива строк 
// сформирует массив из строк, длина которого меньше, либо равна 3 символам.
// Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма.

string[] arrayFirst = new string[7] {"work", ":-)", "monday", "54", "friday", "(", "dog"};
string[] arraySecond = new string[arrayFirst.Length];

void SecondArrayFromFirst(string[] arrayFirst, string[] arraySecond)
{
    int count = 0;
    for(int i = 0; i < arrayFirst.Length; i ++)
    {
        if(arrayFirst[i].Length <= 3)
        {
            arraySecond[count] = arrayFirst[i];
            count++;
        }
    }
    
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
SecondArrayFromFirst(arrayFirst, arraySecond);
PrintArray(arraySecond);

