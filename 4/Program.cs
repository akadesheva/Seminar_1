// Задача 4
//Напишите программу, которая принимает на вход три числа и выдает масимальное из этих чисел.

Console.Write("a: ");
int a = int.Parse(Console.ReadLine());
Console.Write("b: ");
int b = int.Parse(Console.ReadLine());
Console.Write("c: ");
int c = int.Parse(Console.ReadLine());
if (a > b && a > c) {
    Console.WriteLine("max is a");
} 
else 
if (b > a && b > c) {
    Console.WriteLine("max is b");
} 
else {
    Console.WriteLine("max is c");
}
