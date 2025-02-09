static string caesarCipher(string s, int kk)    {
        Console.WriteLine(kk);
        Console.WriteLine(s);

        var k = kk % 26;
        Console.WriteLine(k);

        if(k<0)
            k = k + 26;

        Console.WriteLine(k);

        char[] arr;
        arr = s.ToCharArray(0, s.Length);
        //Console.WriteLine("arr: "+new string(arr));
        for(int i=0; i<arr.Count();i++)
        {
            int t = arr[i];
            char c = (char)(t + k);

            if(t+k<65 || t+k>122 || (t+k>90 && t+k<97)) Console.Write($"! i: {i}, char: {(char)t}, t: {t}, c: {c} - ");

            if(t + k > 26 && ((t>64 && t<91) ||(t>96 && t<123)) )
            {
                Console.WriteLine("t+k > 26 ");
                //Console.WriteLine(((char)t).ToString()+" "+t.ToString()+" -> "+c);
                arr[i] = c;
            }
            
            if(t + k < 27 &&  ((t>64 && t<91) ||(t>96 && t<123)) )
            {
                Console.WriteLine("t+k < 27 ");
                ////Console.WriteLine(t.ToString()+" >> "+c);
                //Console.WriteLine(((char)t).ToString()+" "+t.ToString()+" -> "+c);
                arr[i] = c;                
            }            
                
        }        
        string result = new string(arr);
        Console.WriteLine("");
        return result;
    }
//middle-Outza
Console.WriteLine(caesarCipher("middle-Outvwxyza", -56));