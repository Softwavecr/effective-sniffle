static void Modulo(int a, int b)
{
    int remainder = a % b;
    int trueModulo = TrueModulo(a,b);
        bool correct = remainder == trueModulo;

        string output = "";

        if (a > -1) output += $" {a} MOD ";
        else output += $"{a} MOD ";
        
        if (b > -1) output += $" {b}, OK? {(correct ? "Y" : "N")}.";        
        else output += $"{b}, OK? {(correct ? "Y" : "N")}.";
        
        if (remainder > -1) output += $" R= {remainder} ,";        
        else output += $" R={remainder} ,";

        if (trueModulo > -1) output += $" T= {trueModulo}";
        else output += $" T={trueModulo}";        

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
