// 86. Подсчитать сколько раз определенный символ (например 'a') встречается в строке.
using System.Text;
string s = "А";
Console.Write("Вводим строку: ");
s=Console.ReadLine();
StringBuilder t = new StringBuilder(s);
for (int i = 0; i < t.Length; i++) // По каждому символу
{
    char c = t[i];  // Записываем отдельно каждый символ для сравнение
    int k = 1; // Счётчик
    for (int j = i+1; j < t.Length; j++) // Ищем совпадения
    {
        if (c==t[j]) // Если символ повторяется
        {
            k++; 
            t.Remove(j, 1); // Удаляем символ
            j--; 
        }
    }
    Console.WriteLine($" {c} - {k} раз");
}
t = new StringBuilder(s);
if (t.Length >= 8)
    for (int i = 0; i < t.Length - 7; i++) // Ищем слово "проблема"
        if ((t[i] == 'п') & (t[i + 1] == 'р')& (t[i+2] == 'о') & (t[i+3] == 'б') & (t[i+4] == 'л') & (t[i+5] == 'е') & (t[i+6] == 'м') & (t[i+7] == 'а'))
        {
            t.Remove(i, 8); 
            i--;
        }
Console.WriteLine(t);