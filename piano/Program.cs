using System.Diagnostics;
using System.Runtime.InteropServices;

int b = 1;
while (b == 1)
{
    Console.Clear();
    txt();
    Console.Write("Выберите октаву:");
    ConsoleKeyInfo a = Console.ReadKey();
    Console.Clear();
    int mnog = 1;
    if (a.Key == ConsoleKey.F4)
    {
        int step = 2;
        ockawa(step, mnog);
    }
    else if (a.Key == ConsoleKey.F2)
    {
        int step = 0;
        ockawa(step, mnog);
    }
    else if (a.Key == ConsoleKey.F3)
    {
        int step = 1;
        ockawa(step, mnog);
    }
    else if (a.Key == ConsoleKey.F5)
    {
        int step = 3;
        ockawa(step, mnog);
    }
    else if (a.Key == ConsoleKey.F6)
    {
        int step = 4;
        ockawa(step, mnog);
    }
    else if (a.Key == ConsoleKey.F7)
    {
        int step = 5;
        ockawa(step, mnog);
    }
    else if (a.Key == ConsoleKey.F8)
    {
        int step = 6;
        ockawa(step, mnog);
    }
    if (a.Key == ConsoleKey.Escape)
    {
        Environment.Exit(0);
    }

}
static void A(int mnog)
{
    int a = 65;
    Console.Beep(a * mnog, 100);
}
static void W(int mnog)
{
    int a = 69;
    Console.Beep(a * mnog, 100);
}
static void S(int mnog)
{
    int a = 73;
    Console.Beep(a * mnog, 100);
}
static void E(int mnog)
{
    int a = 77;
    Console.Beep(a * mnog, 100);
}
static void D(int mnog)
{
    int a = 82;
    Console.Beep(a * mnog, 100);
}
static void F(int mnog)
{
    int a = 87;
    Console.Beep(a * mnog, 100);
}
static void T(int mnog)
{
    int a = 92;
    Console.Beep(a * mnog, 100);
}
static void G(int mnog)
{
    int a = 98;
    Console.Beep(a * mnog, 100);
}
static void Y(int mnog)
{
    int a = 103;
    Console.Beep(a * mnog, 100);
}
static void H(int mnog)
{
    int a = 110;
    Console.Beep(a * mnog, 100);
}
static void U(int mnog)
{
    int a = 116;
    Console.Beep(a * mnog, 100);
}
static void J(int mnog)
{
    int a = 123;
    Console.Beep(a * mnog, 100);
}
static void ockawa(int step, int mnog)
{
    if (mnog == 0)
    { mnog = 1; }
    else
    {
        for (int i = 1; i <= step; i++)
        {
            mnog = mnog * 2;
        }
    }
    while (true)
    {
        Console.Clear();
        Console.WriteLine("tab - чтобы вернуться к выбору октав");
        Console.WriteLine("Вводите буквы, для того чтобы играть на пианино");
        ConsoleKeyInfo simvol = Console.ReadKey();
        if ((simvol.Key == ConsoleKey.A))
        {
            A(mnog);
            Console.WriteLine(mnog);
        }
        if ((simvol.Key == ConsoleKey.W))
        {
            W(mnog);
        }
        if ((simvol.Key == ConsoleKey.S))
        {
            S(mnog);
        }
        if ((simvol.Key == ConsoleKey.E))
        {
            E(mnog);
        }
        if ((simvol.Key == ConsoleKey.D))
        {
            D(mnog);
        }
        if ((simvol.Key == ConsoleKey.F))
        {
            F(mnog);
        }
        if ((simvol.Key == ConsoleKey.T))
        {
            T(mnog);
        }
        if ((simvol.Key == ConsoleKey.G))
        {
            G(mnog);
        }
        if ((simvol.Key == ConsoleKey.Y))
        {
            Y(mnog);
        }
        if ((simvol.Key == ConsoleKey.H))
        {
            H(mnog);
        }
        if ((simvol.Key == ConsoleKey.U))
        {
            U(mnog);
        }
        if ((simvol.Key == ConsoleKey.J))
        {
            J(mnog);
        }
        if (simvol.Key == ConsoleKey.Tab)
        {
            break;
        }
        if (simvol.Key == ConsoleKey.Escape)
        {
            Environment.Exit(0);
        }
    }
}
static void txt()
{
    Console.WriteLine("F2 - 2 октава");
    Console.WriteLine("F3 - 3 октава");
    Console.WriteLine("F4 - 4 октава");
    Console.WriteLine("F5 - 5 октава");
    Console.WriteLine("F6 - 6 октава");
    Console.WriteLine("F7 - 7 октава");
    Console.WriteLine("F8 - 8 октава");
}