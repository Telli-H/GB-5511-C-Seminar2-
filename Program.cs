// int number = new Random().Next(10,100); // [10-99] [10-100)
// Console.WriteLine($"Random number 10-99: {number}");

// int firstDigit = number / 10;
// int secondDigit = number % 10;

// Console.WriteLine($"I Digit: {firstDigit}, II Digit: {secondDigit}");

// int max = firstDigit;
// if (secondDigit > max)
// {
//     max = secondDigit;
// }
// Console.WriteLine($"Maximum in {number}: {max}");

//int number = new Random().Next(100,1000); // [100-999] [100-1000)
// Console.WriteLine($"Random number 100-999: {number}");

// int firstDigit = number / 100;
// int tirdDigit = number % 10;

// int result = firstDigit *10 + tirdDigit;

// Console.WriteLine($"{number} -> {result}");



// Напишите программу, которая принимает 
// на вход число и проверяет,
// кратно ли оно одновременно 
// 7 и 23. Если число не кратно 7 и 23,
// то программа выводит остаток от деления.
 
// 14 -> нет
// 46 -> нет 
// 161 -> да

Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());
// "&&" - "И", апельсины И яблоки (обязательно выполнить оба усл-я)
// "||" - "ИЛИ" (хотя бы одно условие - истина)
if (number % 7 == 0 && number % 23 == 0)
{
    Console.WriteLine($"yes {number} devisible by 7 и 23");
}
else
{
    Console.WriteLine("dosen't devisible ");
    Console.WriteLine($"remainder of division {number} on 7 = {number % 7}");
    Console.WriteLine($"remainder of division {number} on 23 = {number % 23}");
}