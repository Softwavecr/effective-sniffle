using System;
using System.Text;

static string CaesarCipher(string text, int key)    
{   
    Console.WriteLine(key);
    Console.WriteLine(text);

    key = TrueMod(key,26);//    Console.WriteLine("k % 26 = "+ k);

    StringBuilder result = new StringBuilder();

    foreach (char chor in text)
    {
        int code = (int)chor;

        if(code >= 65 && code <= 90)
        {
            int shiftedCode = ((code - 65 + key) % 26) + 65;
            result.Append((char)shiftedCode);
        }
        else if(code >= 97 && code <= 122)
        {
            int shiftedCode = ((code - 97 + key) % 26) + 97;
            result.Append((char)shiftedCode);
        }
        else
            result.Append(chor);
    }
    return result.ToString();
}

static int TrueMod(int dividend, int divisor) => ((dividend % divisor) + divisor) % divisor;

Console.WriteLine(CaesarCipher("middle-Outza", 2));
Console.WriteLine(CaesarCipher("okffng-Qwvbc", -2));