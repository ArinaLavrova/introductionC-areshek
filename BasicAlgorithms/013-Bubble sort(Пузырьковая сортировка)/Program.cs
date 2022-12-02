// Пузырьковая сортировка
int[] RandomIntArray(int N,int min, int max)
{
    int [] a=new int[N];
    //Заполнили массив
    Random random=new Random();
    for(int i=0;i<a.Length;i++)
        a[i]=random.Next(0,200);
    return a;
}

void PrintArray(int[] a,int tab=5)
{
    string formatString="{0,"+tab+"}";
    for(int i=0;i<a.Length;i++)
        System.Console.Write(formatString, a[i]);
}


void Swap(ref int a,ref int b)
{
    int t=a;
    a=b;
    b=t;
}

void Reverse(int[] a)
{
    for(int i=0;i<a.Length/2;i++)
        Swap(ref a[i],ref a[a.Length-1-i]);
}


void BubbleSort(int[] a,out int count)
{
    count=0;
    int flag=0;
    for(int i=0;i<a.Length;i++)
    {
        for(int j=0;j<a.Length-1;j++)
            if (a[j]>a[j+1])
            {
                Swap(ref a[j],ref a[j+1]);
                flag=1;
            }
                count++;

    }
    if (flag==0) return;
}

int[] a=RandomIntArray(10,0,10);
PrintArray(a);
int count=0;
BubbleSort(a,out count);
System.Console.WriteLine();
PrintArray(a);
System.Console.WriteLine();
System.Console.WriteLine(count);