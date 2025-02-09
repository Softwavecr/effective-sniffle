static string CaesarCipher(string s, int k)    {

        //var x = -10 % 3;         Console.WriteLine("-10 % 3 = "+x);

        Console.WriteLine(k);
        Console.WriteLine(s);

    k = TrueMod(k,26);

        //k = k % 26;
        Console.WriteLine("1k= "+ k);

        //if(k<0)//c# does reminder, not real modulo, therefore, it needs to be tweaked
            //k = k + 26;

        //Console.WriteLine("2k= "+ k);

        char[] arr;
        arr = s.ToCharArray(0, s.Length);
        //Console.WriteLine("arr: "+new string(arr));
        for(int i=0; i<arr.Count();i++)
        {
            int t = arr[i];
            char c = (char)(t + k);

            //if(t+k<65 || t+k>122 || (t+k>90 && t+k<97)) Console.WriteLine($"! i: {i}, char: {(char)t}, t: {t}, c: {c} - ");

            if(t + k > 26 && ((t>64 && t<91) ||(t>96 && t<123)) )
            {
                //Console.WriteLine("t+k > 26 ");
                //Console.WriteLine(((char)t).ToString()+" "+t.ToString()+" -> "+c);
                arr[i] = c;
            }
            
            if(t + k < 27 &&  ((t>64 && t<91) ||(t>96 && t<123)) )
            {
                //Console.WriteLine("t+k < 27 ");
                ////Console.WriteLine(t.ToString()+" >> "+c);
                //Console.WriteLine(((char)t).ToString()+" "+t.ToString()+" -> "+c);
                arr[i] = c;                
            }            
                
        }        
        string result = new string(arr);
        Console.WriteLine(".");
        return result;
    }

//JavaScript and C# calculate the remainder. The result has the same sign as the dividend 
static int TrueMod(int adivisor, int bdividend) => ((adivisor % bdividend) + bdividend) % bdividend;
//middle-Outza
Console.WriteLine(CaesarCipher("middle-Outvwxyza", -55));
Console.WriteLine(".end.");