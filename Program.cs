// Задача1:Напишитепрограмму,котораяпринимает на вход число 
// и проверяет, кратно ли оно одновременно 7 и 23

// Console.Write("Введитеде число: ");
// int num = int.Parse(Console.ReadLine());
// int a=7;
// int b=23;
// if (num % a == 0 && num % b == 0)
// {
//     Console.WriteLine("Да");
       
// }
// else
// {
//     Console.WriteLine("Нет");
// }


// Задача2: Напишите программу, которая принимает на вход координаты точки(XиY),
// причём X≠0 и Y≠0 и выдаёт номер координатной четверти плоскости, в которой находится эта точка.

// Console.Write("Введите координаты точки X: ");
// int x= int.Parse(Console.ReadLine());
// Console.Write("Введите координаты точки Y: ");
// int y = int.Parse(Console.ReadLine());

// if ( x >0 && y > 0 && x != 0 && y != 0)
// {
//     Console.WriteLine("1");
// }
// else if  ( x < 0 && y > 0 && x != 0 && y != 0)
// {
//     Console.WriteLine("2");
// }
// else if ( x < 0 && y < 0 && x != 0 && y != 0)
// {
//     Console.WriteLine("3");
// }
// else if ( x > 0 && y < 0 && x != 0 && y != 0)
// {
//     Console.WriteLine("4");
// }
// else
// {
//     Console.WriteLine("Недопустимо");
// }


// Задача 3:  Напишите программу, которая принимает на 
// вход целое число из отрезка [10, 99] и 
// показывает наибольшую цифру числа.


int num = new Random().Next(10,100);
//Console.WriteLine(num);
int num1 = num/ 10;
//Console.WriteLine(num1);
int num2 = num % 10;
if (num1 > num2)
{
    Console.WriteLine($"{num} => {num1}");
}
else if (num2 > num1)
{
    Console.WriteLine($"{num} => {num2}");
}
else 
{
    Console.WriteLine($"{num} => Оба равны");
}