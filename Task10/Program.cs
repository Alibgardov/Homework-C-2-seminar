Console.Clear();
int Prompt (string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}
int number = Prompt("Введите трёхзначное число > ");
if (number < 100 || number >= 1000)
{
    Console.WriteLine("Вы ввели не трёхзначное число, пожалуйста повторите снова");
    return;
}
Console.WriteLine($"Второй цифрой числа {number} является {number / 10 % 10} ");
