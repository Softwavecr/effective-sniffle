def caesar_cipher(s,k):
    #x = -10 % 3    print('-10 % 3 = ',x)

    print(k)
    print(s)
    
    k = k % 26
    print('1k= ',k)

# Python does true Modulo, hence no need for adjustment
#    if k < 0: 
#       k2 = k + 26

    print('2k= ',k)
    
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


#middle-Outza
print(caesar_cipher('middle-Outvwxyza', -56))