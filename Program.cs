// Урок 1. Знакомство с языком программирования С#
// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

// Console.WriteLine("give me a number");
// int num1 = Convert.ToInt32 (Console.ReadLine());

// Console.WriteLine("give me a number");
// int num2 = Convert.ToInt32 (Console.ReadLine());

// if (num1>num2)
// {
//    Console.WriteLine("max = " + num1); 
// }

// else if (num1<num2)
// {
//     Console.WriteLine("max = " + num2);
// }

// else
// {
//     Console.WriteLine("chisla rovni");
// }



// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

// Console.WriteLine("give me a number");
// int num1 = Convert.ToInt32 (Console.ReadLine());

// Console.WriteLine("give me a number");
// int num2 = Convert.ToInt32 (Console.ReadLine());

// Console.WriteLine("give me a number");
// int num3 = Convert.ToInt32 (Console.ReadLine());

// int result = num1;

// if (result > num2)
// {
//     if (result > num3)
//     {
//        Console.WriteLine(result); 
//     }
//     else
//     result = num3;
//     {
//         Console.WriteLine(result); 
//     }
// }

// else 

// result = num2;

// {
//   if (result > num3)
//     {
//        Console.WriteLine(result); 
//     }
//     else
//     result = num3;
//     {
//         Console.WriteLine(result); 
//     }  
// }


// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

// Console.WriteLine("give me a number");
// int num1 = Convert.ToInt32 (Console.ReadLine());

// int remainder = num1%2;

// if (remainder == 0)

// {
//     Console.WriteLine("chetnoe");
// }

// else 
// {
//     Console.WriteLine("Nechetnoe");
// }

// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("give me a number");

int num1 = Convert.ToInt32 (Console.ReadLine());

int numStart = 1;

while (numStart <= num1)
{
    int remainder = numStart%2;

    if (remainder == 0)
    {
        Console.WriteLine(numStart);
        numStart = numStart + 1;
    }
    else
    
    {
        numStart = numStart + 1;
    }
}
