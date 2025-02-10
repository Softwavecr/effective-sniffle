static void Modulo(int divisor, int dividend)
{
    int remainder = divisor % dividend;
    int trueModulo = TrueModulo(divisor,dividend);
    bool correct = remainder == trueModulo;     

    Console.WriteLine($" {divisor} MOD {dividend} = {(correct ? remainder : trueModulo)} (R = {remainder}, T = {trueModulo})");

}

static int TrueModulo(int divisor, int dividend) => 
    ((divisor % dividend) + dividend) % dividend;

Modulo(10,3);
Modulo(-10,3);
Modulo(10,-3);
Modulo(-10,-3);
