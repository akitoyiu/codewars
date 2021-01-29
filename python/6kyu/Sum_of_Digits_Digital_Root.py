import math

def digital_root(n):
    # ...
    result = n
    while n > 9:
        result = 0
        digits = int(math.log10(n))
        for i in range(digits, -1, -1):
            dt = math.floor(n/10**i)
            result += dt
            n -= dt * 10 ** i
            #print(result)
        n = result
    
    return result