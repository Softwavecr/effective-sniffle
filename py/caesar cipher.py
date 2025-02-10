def caesar_cipher(text, key):
    print(key)    
    print(text)
    
    key = key % 26
    
    result = []

    for char in text:
        code = ord(char)

        if code >= 65 and code <= 90:
            shiftedcode = ((code - 65 + key) % 26) + 65
            result.append(chr(shiftedcode))
        elif code >= 97 and code <= 122:
            shiftedcode = ((code - 97 + key) % 26) + 97
            result.append(chr(shiftedcode))
        else:
            result.append(char)

    return "".join(result)

r1 = caesar_cipher('middle-Outza', -77)
print(r1)
r2 = caesar_cipher(r1, 77)
print(r2)