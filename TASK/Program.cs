//Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
//длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма. 
//При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

//Первоначальный массив задан на старте.

string[] array1 = new string[6] {"yes", "no", "MyTask", "Diagram", "5","otl"};
string[] array2 = new string[array1.Length];
int count = 0;
  
    for (int i = 0; i < array1.Length; i++)
    { 
    if (array1[i].Length <= 3)
        {
        array2[count] = array1[i];
        count++; 
        }
    }
System.Console.WriteLine("Полученный массив: "); 
void FinalArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
         Console.Write($"{array[i]} ");
    }
Console.WriteLine();
}
FinalArray(array2);

