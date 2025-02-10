function caesarCipher(text, key) {
    console.log(key);     
    console.log(text);    
    
    key = trueMod(key,26);

    let result = "";     
    const charArray = Array.from(text);

    charArray.forEach(char => {
        let code = char.charCodeAt(0);

        if (code >= 65 && code <= 90) {
            let shiftedCode = ((code - 65 + key) % 26) + 65;
            result += String.fromCharCode(shiftedCode);
        } else if (code >= 97 && code <= 122) {
            let shiftedCode = ((code - 97 + key) % 26) + 97;
            result += String.fromCharCode(shiftedCode);
        } else {
            result += char;
        }
    });
    return result;
}

const trueMod = (dividend, divisor) => ((dividend % divisor) + divisor) % divisor;

let r1 = caesarCipher("middle-Outza", -77)
console.log(r1);
let r2 = caesarCipher(r1, 77);
console.log(r2);
