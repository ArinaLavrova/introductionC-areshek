// See https://aka.ms/new-console-template for more information
int n=Convert.ToInt32(Console.ReadLine());
int k=0;//Счетчик
bool flag=false;//флаг
for(int i=0;i<n;i++)
{
    int a=Convert.ToInt32(Console.ReadLine());
    if (a<5) k++;
    if (a==10) flag=true;
}
System.Console.WriteLine(k);
if (flag) System.Console.WriteLine("YES"); else System.Console.WriteLine("NO");