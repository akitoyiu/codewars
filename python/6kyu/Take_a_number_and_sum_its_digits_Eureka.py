#Take a Number And Sum Its Digits Raised To The Consecutive Powers And ....¡Eureka!!

def sum_dig_pow(a, b): # range(a, b + 1) will be studied by the function
    # your code here    
    result = ([])
    
    if a < 10:
        for i in range(a, min(b+1, 10)):
            result.append(i)
    
    if a <= 89 and b >=89: result.append(89)
        
    for i in range(max(a, 90), b+1):
        si = str(i)
        iT = 0
        for j in range(0, len(si)):
            iT += int(si[j]) ** (j+1)
        if iT == i: result.append(i)
        
    return result