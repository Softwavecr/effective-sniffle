

def caesar_cipher(s,k):

    print(k)
    print(s)
    
    k = k % 26
    print('k % 26 = ',k)
    
    result = []

    for char in s:
        code = ord(char)

        if code >= 65 and code <= 90:
            shiftedcode = ((code - 65 + k) % 26) + 65
            result.append(chr(shiftedcode))
        elif code >= 97 and code <= 122:
            shiftedcode = ((code - 97 + k) % 26) + 97
            result.append(chr(shiftedcode))
        else:
            result.append(char)

    return "".join(result)

print(caesar_cipher('middle-Outza', -2))