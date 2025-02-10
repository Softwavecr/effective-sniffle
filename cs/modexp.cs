static void Modulo(int divisor, int dividend)
{
    int remainder = divisor % dividend;
    int trueModulo = TrueModulo(divisor,dividend);
    bool correct = remainder == trueModulo;

    string output = "";

    if (divisor > -1) output += $" {divisor} MOD ";
    else output += $"{divisor} MOD ";
        
    if (dividend > -1) output += $" {dividend}, OK? {(correct ? "Y" : "N")}.";        
    else output += $"{dividend}, OK? {(correct ? "Y" : "N")}.";
        
    if (remainder > -1) output += $" R= {remainder} ,";        
    else output += $" R={remainder} ,";

    if (trueModulo > -1) output += $" T= {trueModulo}";
    else output += $" T={trueModulo}";        

    Console.WriteLine(output);
}

static void Modulo1(int divisor, int dividend)
{
    int remainder = divisor % dividend;
    int trueModulo = TrueModulo(divisor,dividend);
    bool correct = remainder == trueModulo;     

    Console.WriteLine($" {divisor} MOD {dividend}, OK? {(correct ? 'Y' : 'N')}. R= {remainder}, T= {trueModulo}.");

}

static int TrueModulo(int divisor, int dividend) => 
    ((divisor % dividend) + dividend) % dividend;

Modulo(10,3);Modulo1(10,3);
Modulo(-10,3);Modulo1(-10,3);
Modulo(10,-3);Modulo1(10,-3);
Modulo(-10,-3);Modulo1(-10,-3);
