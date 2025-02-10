

function caesarCipher(s, k) {

    console.log(k); 
    console.log(s);    
    
    k = trueMod(k,26);
    console.log('k % 26 = ',k);

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

const trueMod = (dividend, divisor) => ((dividend % divisor) + divisor) % divisor;

console.log(caesarCipher("middle-Outza", -2));

