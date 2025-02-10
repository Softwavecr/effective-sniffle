static void Modulo(int dividend, int divisor)
{
    int remainder = dividend % divisor;
    int trueModulo = TrueModulo(dividend, divisor);
    bool correct = remainder == trueModulo;     

    Console.WriteLine($" {dividend} MOD {divisor} = {(correct ? remainder : trueModulo)} (R = {remainder}, T = {trueModulo})");
}

static int TrueModulo(int dividend, int divisor) => 
    ((dividend % divisor) + divisor) % divisor;

Modulo(10,3);
Modulo(-10,3);
Modulo(10,-3);
Modulo(-10,-3);
