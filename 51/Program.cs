//51 С клавиатуры вводится число N. Затем вводятся N чисел. Определить сколько чисел больше 0 введено с клавиатуры

System.Console.Write("Введите элементы(через пробел): ");
int[] arr = Array.ConvertAll(System.Console.ReadLine().Split(), int.Parse);
int count = 0;
 
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > 0)
    {
        count++;
    }
}
 
System.Console.WriteLine($"Кол-во элементов > 0: {count}");