/*
#region мой код
Console.WriteLine("Hello, World!"); 
#endregion


System.Console.WriteLine("asfuvhd"+"fgy"+2+"vdfed");//метод
System.Console.WriteLine("astuvhd");
Console.WriteLine("2+2");
*/



/*
int a=0,b=0,c=0;//целый
float f=20.4f;//32 бит
double d=3.14;//вещественный. 64 бит
string s="asfuvhd";
char c0='a';
bool flag=true;
int переменная 1=0;

int @_45f;
*/
//1. С клавиатуры вводится целое числою Вывести квадрат числа (блок-схема)

int a;
a=10;
System.Console.Write("Введите число:");
String? s=Console.ReadLine();
a=Convert.ToInt32(s);
int b=a*a;
System.Console.WriteLine(Convert.ToString(a)+"^2="+b.ToString());
System.Console.WriteLine("{0}^2={1}",a,b);
System.Console.WriteLine($"{a}^2={b}");