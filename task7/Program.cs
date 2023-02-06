//Показать вторую цифру трёхзначного числа 

Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
string numberText = Convert.ToString(number);
if (numberText.Length > 1)
Console.WriteLine("Вторая цифра ->"+numberText[1]);

