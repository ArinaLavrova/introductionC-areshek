//80. Вывести на экран кодировку символов по ASCII(с 32 до 122)
int a = 32;
int b = 122;
for (int i = a; i <= b; i++)
    Console.WriteLine(i.ToString() + "-й символ таблицы ASCII: " + (char)i);