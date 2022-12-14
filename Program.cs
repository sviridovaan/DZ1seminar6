//Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.
Console.Clear();
Console.Write("Введите числа через запятую: ");
string str = Console.ReadLine();
var array = str.ToCharArray();
int sum = 0;
foreach (var symbol in array)
{
    if (symbol == ',')
    sum++;
}

int size = sum+1;
Console.WriteLine("Количество введенных чисел: "+size);

int result = 0;
int[] arr2 = str.Split(',').Select(int.Parse).ToArray();

for (int index=0; index<size; index++)
{
    if (arr2[index]>0)
    result++;
}
Console.WriteLine("Количество положительных чисел: " + result);

