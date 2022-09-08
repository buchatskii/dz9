// Задача 64: Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 5, 6, 7, 8""
Console.Clear();
// int PrintNum(int start, int fin)
// {
//     Console.Write($"{start} ");
//     if (start == fin) return start;
//         return  PrintNum(start + 1, fin);
// }


// Console.Write("Введите m: ");
// int numM=int.Parse(Console.ReadLine()!);
// Console.Write("Введите n: ");
// int numN=int.Parse(Console.ReadLine()!);

// PrintNum(numM,numN);


// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


// int sum(int start, int fin)
// {
//     if (start == fin) return fin;
//         return  fin + sum(start, fin - 1);
// }

// Console.Write("Введите m: ");
// int numM=int.Parse(Console.ReadLine()!);
// Console.Write("Введите n: ");
// int numN=int.Parse(Console.ReadLine()!);

// Console.WriteLine(sum(numM, numN));


// Задача 68: Напишите программу вычисления функции аккермана с помощью рекурсии
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 29

// int FunAccerman(int m, int n)
// {
//     if(n == 0) return m + 1;
//     if(n > 0 && m == 0) return FunAccerman(1, n - 1);
//     return FunAccerman(FunAccerman(m - 1, n),n - 1);
// }
// Console.Write("Введите m: ");
// int numM=Convert.ToInt32(Console.ReadLine()!);
// Console.Write("Введите n: ");
// int numN=Convert.ToInt32(Console.ReadLine()!);
// Console.WriteLine(FunAccerman(numM,numN));