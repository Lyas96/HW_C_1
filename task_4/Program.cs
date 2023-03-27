//Программа на вход принимает число N и выдает все четные от 1 до N
Console.Clear();
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine());
for(int i = 1; i <= n; i++)
if(i % 2 == 0)
{
  Console.Write($"{i}, ");
}