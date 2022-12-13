// 71.Показать натуральные числа от N до 1, N задано
static void Foo(int n)
{
    if (n > 0)
    {
        Console.Write("{0} ", n);
        Foo(n - 1);
    }
    Console.WriteLine(n);
}

