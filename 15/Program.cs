//15. C клавиатуры вводится целое цисло. Вывести третью цифру числа или сообщить, что ее нет
//(Вывести: NO).
int n=Convert.ToInt32(Console.ReadLine());
n=Math.Abs(n);
//Вариант 1 - простой
/*if (n<100) System.Console.WriteLine("No"); ... 
else System.Console.WriteLine(n/100%10);
//4565654656/100%3
*/

//Вариант 2 - 12345678 - 3
if (n>99)
{
    while (n>1000)
    {
        n=n/10;
    } 
    System.Console.WriteLine(n%10);

}
else
{
    System.Console.WriteLine("NO");
}
