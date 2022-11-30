// Задача: Написать программу, которая из имеющегося массива строк 
// формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

void PrintArray(string[] a)
{
    for (int i = 0; i < a.Length; i++)
    {
        Console.Write($"{a[i]} ");
    }
    Console.WriteLine();
}


string[] EditorText(string[] text, int sizeWord)
{
    int count = 0;
    string[] newText = new string[text.Length];
    for (int i = 0; i < newText.Length; i++)
    {
        
        if (text[i].Length <= sizeWord) 
        {
            newText[count] = text[i];
            count++;
        }
    }
    return newText;
}



Console.WriteLine("Введите  ваш текст: ");
string text = Console.ReadLine();

Console.WriteLine("Введите  максимальную длину строки: ");
int lengthString = Convert.ToInt32(Console.ReadLine());

string[] textArray = text.Split(" ");


Console.WriteLine("Ваш текст: ");
PrintArray(textArray);
string[] editText = EditorText(textArray, lengthString);
Console.WriteLine("После редакции: ");
PrintArray(editText);
