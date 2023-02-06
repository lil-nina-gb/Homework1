// Показать последнюю цифру трёхзначного числа

Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
string numberText = Convert.ToString(number);
if (numberText.Length > 2)
{
    Console.WriteLine("третья цифра -> " + numberText[2]); 
}