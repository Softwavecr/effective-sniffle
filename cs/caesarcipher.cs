using System;
using System.Text;

static string CaesarCipher(string s, int k)    
{   
    Console.WriteLine(k);        
    Console.WriteLine(s);

    k = TrueMod(k,26);//    Console.WriteLine("k % 26 = "+ k);

    StringBuilder result = new StringBuilder();

    foreach (char c in s)
    {
        int code = (int)c;

        if(code >= 65 && code <= 90)
        {
            int shiftedCode = ((code - 65 + k) % 26) + 65;
            result.Append((char)shiftedCode);
        }
        else if(code >= 97 && code <= 122)
        {
            int shiftedCode = ((code - 97 + k) % 26) + 97;
            result.Append((char)shiftedCode);
        }
        else
            result.Append(c);
    }
    return result.ToString();
}

static int TrueMod(int dividend, int divisor) => ((dividend % divisor) + divisor) % divisor;

Console.WriteLine(CaesarCipher("middle-Outza", 2));
Console.WriteLine(CaesarCipher("okffng-Qwvbc", -2));