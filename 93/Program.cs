/*93. Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, заданы 2 массива:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
и
1 5 8 5
4 9 4 2
7 2 2 6
2 3 4 7
Их произведение будет равно следующему массиву:
1 20 56 10
20 81 8 6
56 8 4 24
10 6 24 49
*/
class Matrix
{
    static void Proizved()
    {
 
        int n = 0;
        int r = 0;
        string n2;
 
        void Iskl()
        {
 
            bool tc1 = false;
            bool tc2 = false;
            while (tc1 != true)             // реализация 
            {
 
                try
                {
                    Console.Write("Введите ранг матрицы: ");
                    int n1 = Convert.ToInt32(Console.ReadLine());
                    tc1 = true;
                    n = n1;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Некоректный ввод данных. Пожалуйста повторите попытку!");
                    tc1 = false;
                }
                catch (Exception)
 
                {
                    Console.WriteLine("Критическая ошибка");
                    Console.ReadKey();
                    return;
                }
 
                while (tc2 != true)
                {
                    try
                    {
                        Console.Write("Введите количество столбцов в матрице: ");
                        int r1 = int.Parse(Console.ReadLine());
                        tc2 = true;
                        r = r1;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Некоректный ввод данных. Пожалуйста повторите попытку!");
                        tc2 = false;
                    }
                    catch (Exception)
 
                    {
                        Console.WriteLine("Критическая ошибка");
                        Console.ReadKey();
                        return;
                    }
                }
            }
        }
        Iskl();
 
        Random rand = new Random();
        int[,] arr1 = new int[n, r];
        int[,] arr2 = new int[n, r];
        char[,] arr3 = new char[n, 1];
        int[,] arr_result = new int[n, r];
        int[,] arr_result2 = new int[n, r];
        int size_str = 0;
 
 
 
        Console.WriteLine();
        string str = "|";
 
        for (int i = 0; i < arr1.GetLength(0); i++)
        {
            Console.SetCursorPosition(0, 4 + i);               //МАССИВ ПЕРВОЙ МАТРИЦЫ
            Console.Write(str.ToString().PadLeft(0));
 
            for (int j = 0; j < arr1.GetLength(1); j++)
            {
                arr1[i, j] = rand.Next(0, 50);
                arr2[i, j] = rand.Next(0, 50);
                Console.Write($" {arr1[i, j],-4} ");
            }
            Console.WriteLine($"{str.ToString().PadLeft(0)} + ");
        }
 
 
 
        for (int i = 0; i < 1; i++)
        {
            // подсчет символов в строке 
            for (int j = 0; j < arr1.GetLength(1); j++)
            {
                string max1 = Convert.ToString(arr1[1, j]);
                size_str += max1.Length + 2;
 
            }
        }
 
 
 
        Console.WriteLine($"size_str = {size_str} ");
        for (int i = 0; i < arr2.GetLength(0); i++)
        {                                                     //МАССИВ ВТОРОЙ МАТРИЦЫ
            Console.SetCursorPosition(3 + (size_str) * 2, 4 + i);
            Console.Write(str.ToString().PadLeft(0));
            for (int j = 0; j < arr2.GetLength(1); j++)
            {
                Console.Write($" {arr2[i, j],-4} ");
            }
            Console.WriteLine($"{str.ToString().PadLeft(0)} = ");
            Console.WriteLine();
        }
        for (int i = 0; i < arr_result.GetLength(0); i++)
        {
            Console.SetCursorPosition(5 + (size_str) * 4, 4 + i);                       //МАССИВ МАТРИЦЫ РЕЗУЛЬТАТ
            Console.Write(str.ToString().PadLeft(0));
            for (int j = 0; j < arr_result.GetLength(1); j++)
            {
                for (int e = 0; e < arr1.GetLength(0); e++)
                {
                    arr_result[i, j] += arr1[i, e] * arr2[e, j];
                }
                Console.Write($" {arr_result[i, j],-4} ");
            }
            Console.WriteLine($"{str.ToString().PadLeft(0)}");
            Console.WriteLine();
        }
 
    }
    static void Main(string[] args)
    {
        Proizved();
    }
}