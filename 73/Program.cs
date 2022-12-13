// Найти сумму элементов от M до N,N и M заданы-1
int Sum(int m,int n)
{
    if(m==n) return m;
    else
     return Sum(m+1,n)+m;
}

System.Console.WriteLine(Sum(2,4));
System.Console.WriteLine((2+4)*3/2);