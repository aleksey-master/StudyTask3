//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

//int number = new Random().Next(10, 10000);
//System.Console.WriteLine($"Введите число = {Length}");
//int number3 = numberA % 10;
//int number2 = numberA / 10 % 10;
//int number1 = numberA / 100 % 10;


//int[] array = new int(Length);
//for (int i = 0; i < array.Length; i++)
//{
  //  array[i] = Prompt($"Введите {i} элемент");
//}
//return array;
//int[] inputarray(int Length)
//  while (number > 0)
//{
//  int a = number % 10;
//if (max < a)
//  max = a;
//number = number / 10;
//i++;
//}
//if (array[i] > 2)
//{
  //  System.Console.WriteLine("Третья цифра = " + array[2]);
//}
//else
//{
  //  System.Console.WriteLine("Третьей цифры нет");
//}


Console.Write("Введи число: ");
int number = Convert.ToInt32(Console.ReadLine());
string numberText = Convert.ToString(number);
if (numberText.Length > 2)
{
    Console.WriteLine("третья цифра -> " + numberText[2]);
}
else
{
    Console.WriteLine("-> третьей цифры нет");
}




