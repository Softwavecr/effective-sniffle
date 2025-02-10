
function caesarCipher(s, k) {

    console.log(k); 
    console.log(s);    
    
    k = trueMod(k,26);    //k = k % 26
    console.log('k % 26 = ',k);
    //if (k < 0) //js does reminder, not real modulo, therefore, it needs to be tweaked
    //k = k + 26;
    //console.log("2k= "+k);

    let result = ""

    for (let i=0; i<s.length ;i++)
        {
            let char = s[i];
            let code = s.charCodeAt(i);
            
            if(code >= 65 && code <= 90)
            {
                let shiftedCode = ((code - 65 + k) % 26) + 65;
                result += String.fromCharCode(shiftedCode);
            } else if (code >= 97 && code <= 122) { 
                let shiftedCode = ((code - 97 + k) % 26) + 97;
                result += String.fromCharCode(shiftedCode);
            } else { 
                result += char;
            }                          
        }
    return result;
}

//JavaScript and C# calculate the remainder. The result has the same sign as the dividend 
//function trueMod2(adivisor,bdividend) { return ((adivisor % bdividend) + bdividend) % bdividend;}
//function trueMod(dividend, divisor) { return ((dividend % divisor) + divisor) % divisor;}
const trueMod = (dividend, divisor) => ((dividend % divisor) + divisor) % divisor;

//function trueMod(a,b){  return ((a % b) + b) % b;}
//console.log(caesarCipher("middle-Outza", 2));
console.log(caesarCipher("middle-Outza", -2));

