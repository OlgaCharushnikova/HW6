// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


Console.WriteLine("Введите числа: ");
string x = Console.ReadLine();
char[] arr = new char[x.Length];
for (int i = 0; i < x.Length; i++)
{
    arr[i] = x[i];
}
int count = 0;
for (int j = 0; j < x.Length; j++)
{
    if (arr[j] == '0' || arr[j] == '-' || arr[j] == ' ' || arr[j] == ',')
    {
        count = count + 0;
        if (arr[j] == '-' )
        {
           count = count - 1;
        }
    }

    else
    {
        count = count + 1;
        
    }
}
Console.WriteLine(count);
