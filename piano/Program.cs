int b = 1;
while (b == 1)
{
    Console.Clear();
    txt();
    Console.Write("Выберите октаву:");
    ConsoleKeyInfo a = Console.ReadKey();
    Console.Clear();
    if (a.Key == ConsoleKey.F2)
    {
        two();
    }
    if (a.Key == ConsoleKey.F3)
    {
        tree();
    }
    if (a.Key == ConsoleKey.Escape)
    {
        Environment.Exit(0);
    }

}
static void c2()
{
    Console.Beep(65, 100);
}
static void c21()
{
    Console.Beep(69, 100);
}
static void d2()
{
    Console.Beep(73, 100);
}
static void eb2()
{
    Console.Beep(77, 100);
}
static void e2()
{
    Console.Beep(82, 100);
}
static void f2()
{
    Console.Beep(87, 100);
}
static void f21()
{
    Console.Beep(92, 100);
}
static void g2()
{
    Console.Beep(98, 100);
}
static void g21()
{
    Console.Beep(103, 100);
}
static void a2()
{
    Console.Beep(110, 100);
}
static void bb2()
{
    Console.Beep(116, 100);
}
static void b2()
{
    Console.Beep(130, 100);
}
static void c3()
{
    Console.Beep(138, 100);
}
static void c31()
{
    Console.Beep(146, 100);
}
static void d3()
{
    Console.Beep(73, 100);
}
static void eb3()
{
    Console.Beep(155, 100);
}
static void e3()
{
    Console.Beep(164, 100);
}
static void f3()
{
    Console.Beep(174, 100);
}
static void f31()
{
    Console.Beep(185, 100);
}
static void g3()
{
    Console.Beep(196, 100);
}
static void g31()
{
    Console.Beep(207, 100);
}
static void a3()
{
    Console.Beep(220, 100);
}
static void bb3()
{
    Console.Beep(233, 100);
}
static void b3()
{
    Console.Beep(246, 100);
}
static void two()
{
    while (true)
    {
        Console.Clear();
        Console.WriteLine("Нажимайте на буквы, для того чтобы играть на пианино.");
        Console.WriteLine();
        ConsoleKeyInfo simvol = Console.ReadKey();
        int[] oct2 = { 65, 69, 73, 77, 82, 87, 92, 98, 103, 110, 116, 123 };
        if ((simvol.Key == ConsoleKey.A))
        {
            c2();
        }
        if ((simvol.Key == ConsoleKey.W))
        {
            c21();
        }
        if ((simvol.Key == ConsoleKey.S))
        {
            d2();
        }
        if ((simvol.Key == ConsoleKey.E))
        {
            eb2();
        }
        if ((simvol.Key == ConsoleKey.D))
        {
            e2();
        }
        if ((simvol.Key == ConsoleKey.F))
        {
            f2();
        }
        if ((simvol.Key == ConsoleKey.D))
        {
            f21();
        }
        if ((simvol.Key == ConsoleKey.G))
        {
            g2();
        }
        if ((simvol.Key == ConsoleKey.J))
        {
            g21();
        }
        if ((simvol.Key == ConsoleKey.L))
        {
            a2();
        }
        if ((simvol.Key == ConsoleKey.X))
        {
            bb2();
        }
        if ((simvol.Key == ConsoleKey.C))
        {
            b2();
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
static void tree()
{
    int ocenka = 5;
    while (ocenka == 5)
    {
        Console.Clear();
        Console.WriteLine("Вводите буквы, для того чтобы играть на пианино");
        ConsoleKeyInfo simvol = Console.ReadKey();
        int[] oct3 = { 130, 138, 146, 155, 164, 174, 185, 196, 207, 220, 233, 246 };
        if ((simvol.Key == ConsoleKey.A))
        {
            c3();
        }
        if ((simvol.Key == ConsoleKey.W))
        {
            c31();
        }
        if ((simvol.Key == ConsoleKey.S))
        {
            d3();
        }
        if ((simvol.Key == ConsoleKey.E))
        {
            eb3();
        }
        if ((simvol.Key == ConsoleKey.D))
        {
            e3();
        }
        if ((simvol.Key == ConsoleKey.F))
        {
            f3();
        }
        if ((simvol.Key == ConsoleKey.T))
        {
            f31();
        }
        if ((simvol.Key == ConsoleKey.G))
        {
            g3();
        }
        if ((simvol.Key == ConsoleKey.Y))
        {
            g31();
        }
        if ((simvol.Key == ConsoleKey.H))
        {
            a3();
        }
        if ((simvol.Key == ConsoleKey.U))
        {
            bb3();
        }
        if ((simvol.Key == ConsoleKey.J))
        {
            b3();
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
}