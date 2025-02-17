static void calculate()
{
    IEnumerable<int> squares = Enumerable.Range(1, 25).Select(x => x * x);
    foreach (int x in squares)
        Console.Write(x.ToString() + " ");
    Console.Write("\n");
}

calculate();