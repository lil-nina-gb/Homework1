//По двум заданным числам проверять является ли первое квадратом второго

Console.Write("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine());

if (number1 / number2 == number2) 
{
    Console.WriteLine("Первое число является квадратом второго");
}


 else
{
    Console.WriteLine("Первое число не является квадратом второго");
}

