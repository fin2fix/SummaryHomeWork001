/* Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
лучше обойтись исключительно массивами.
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → [] */

string[] GetArrayFraseLenght(int textLenght, string message)
{
  Console.WriteLine(message);
  string mixedText = Console.ReadLine()!;
  char[] separators = new char[] { '"', ' ', ',' };
  string[] mixedSplitArray = mixedText.Split(separators, StringSplitOptions.RemoveEmptyEntries);

  string[] resultArray = new string[mixedSplitArray.Length];
  int count = 0;

  for (int i = 0; i < mixedSplitArray.Length; i++)
  {
    if (mixedSplitArray[i].Length <= textLenght)
    {
      resultArray[count] = mixedSplitArray[i];
      count++;
    }
  }
  Array.Resize(ref resultArray, count);

  return resultArray;
}

void PrintArray(string[] array)
{
  Console.Write("[");
  if (array.Length == 0) Console.Write("");
  else
  {
    for (int i = 0; i < array.Length - 1; i++)
    {
      Console.Write($"'{array[i]}', ");
    }
    Console.Write($"'{array[array.Length - 1]}'");
  }
  Console.Write("]");
}

Console.WriteLine();
int textLenght = 3;
string[] fraseArray = GetArrayFraseLenght(textLenght, "Введите массив фраз разделенных запятыми ','");
Console.WriteLine();
Console.WriteLine($"Итоговый массив с фразами длинной менее или равной {textLenght} символов");
PrintArray(fraseArray);



