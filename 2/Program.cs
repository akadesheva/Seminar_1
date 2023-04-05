//Задача 2
//Напишите программу, которая навход принимает два числа и выдает, какое число большее, а какое меньшее.

Console.Write("a: ");
int a = int.Parse(Console.ReadLine());
Console.Write("b: ");
int b = int.Parse(Console.ReadLine());
if (a > b){
    Console.WriteLine("max is a, min is b");
}else {
    Console.WriteLine("max is b, min is a");
}

