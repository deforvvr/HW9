int programm;
Boolean begin = true;

int[] arrayInt = { };

while (begin)
{
    Console.Write("Введите номер задачи >>> ");

    programm = int.Parse(Console.ReadLine());

    switch (programm)
    {
        case 64:
            Task64();
            break;

        case 66:
            Task66();
            break;

        case 68:
            Task68();
            break;

        default:
            begin = false;
            break;
    }
}


void Task64()
{
    int m, n;
    Console.Write("Введите M >>> ");
    m = int.Parse(Console.ReadLine());

    Console.Write("Введите N: ");
    n = int.Parse(Console.ReadLine());

    void Range(int start, int end)
    {
        if (end > start)
        {
            Range(start, end - 1);
            Console.Write(", ");
        }
        Console.Write(end);
    }

    Range(m, n);
    Console.WriteLine();
}


void Task66()
{
    int m, n;
    Console.Write("Введите M >>> ");
    m = int.Parse(Console.ReadLine());

    Console.Write("Введите N >>> ");
    n = int.Parse(Console.ReadLine());

    int SumRange(int start, int end)
    {
        int sum = 0;

        if (start < end) sum = start + end + SumRange(start + 1, end - 1);

        else if (start == end) sum = end;

        return sum;
    }

    Console.WriteLine(SumRange(m, n));
}


void Task68()
{
    int m, n;
    Console.Write("Введите M >>> ");
    m = int.Parse(Console.ReadLine());

    Console.Write("Введите N >>> ");
    n = int.Parse(Console.ReadLine());

    int Akkerman(int m, int n)
    {
        if (m > 0 && n == 0) return Akkerman(m - 1, 1);

        if (m > 0 && n > 0) return Akkerman(m - 1, Akkerman(m, n - 1));

        return n + 1;
    }
    Console.WriteLine(Akkerman(m, n));
}