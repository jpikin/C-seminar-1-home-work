// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

// Console.WriteLine("Введите первое число:");
// int numberA = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число:");
// int numberB = Convert.ToInt32(Console.ReadLine());
// if (numberA > numberB)
//     Console.WriteLine("Первое число больше второго");
// else
//     Console.WriteLine("Второе число больше первого");    


// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

// Console.WriteLine("Введите первое число:");
// int numberA = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число:");
// int numberB = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите третье число:");
// int numberС = Convert.ToInt32(Console.ReadLine());
// int maxNum = numberA;

// if (numberB > maxNum)
//     maxNum = numberB;
// if (numberС > maxNum)
//     maxNum = numberС;

// Console.Write("Максимальное из трех введенных чисел: ");
// Console.WriteLine(maxNum);


// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

// Console.WriteLine("Введите число:");
// int number = Convert.ToInt32(Console.ReadLine());

// if (number % 2 == 0)
//     Console.WriteLine("Число четное");
// else
//     Console.WriteLine("Число нечетное");


// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

// Console.WriteLine("Введите число:");
// int number = Convert.ToInt32(Console.ReadLine());
// int evenNum = 2;

// while (evenNum <= number)
//     {
//         Console.Write(evenNum);
//         Console.Write(" ");
//         evenNum += 2;
//     }