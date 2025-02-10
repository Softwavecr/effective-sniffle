static void Modulo(int a, int b)
{
     int[] numbers = { a, b };

    int remainder = a % b;
    int trueModulo = TrueModulo(a,b);
    bool correct = remainder == trueModulo;

    int largest = Math.Max(a, b);

        int maxWidth = 0;
        foreach (int number in numbers)
        {
            maxWidth = Math.Max(maxWidth, Math.Abs(number).ToString().Length);
        }

    //string a = a.ToString();
    //string apadded = a.ToString().PadLeft(maxWidth + (a < 0 ? 1 : 0), " "); // +1 for the minus sign if negative
    
    //string bpadded = b.ToString().PadLeft(maxWidth + (b < 0 ? 1 : 0), " "); // +1 for the minus sign if negative

    string paddedNumbera = string.Format("{0," + (maxWidth + (a < 0 ? 1 : 0)) + "}", a);
    Console.WriteLine(paddedNumbera);
    string paddedNumberb = string.Format("{0," + (maxWidth + (b < 0 ? 1 : 0)) + "}", b);
    Console.WriteLine(paddedNumberb);

    string ok = "Y";
    string no = "N";

    //if(a>-1) Console.Write(" ");

    string output = $".{paddedNumbera} MOD {paddedNumberb}, Remainder= {remainder}, TrueModulo= {trueModulo}. {(correct ? ok : no)}";

    Console.WriteLine(output);
}

static int TrueModulo(int adivisor, int bdividend) => ((adivisor % bdividend) + bdividend) % bdividend;

// Console.WriteLine(10 % 3);   // Output: 1
// Console.WriteLine(-10 % 3);  // Output: -1
// Console.WriteLine(10 % -3);  // Output: 1
// Console.WriteLine(-10 % -3); // Output: -1

// Console.WriteLine(TrueMod(10,3));   // Output: 1
// Console.WriteLine(TrueMod(-10,3));  // Output: 2
// Console.WriteLine(TrueMod(10,-3));  // Output: -2
// Console.WriteLine(TrueMod(-10,-3)); // Output: -1

Modulo(10,3);
Modulo(-10,3);
Modulo(10,-3);
Modulo(-10,-3);
