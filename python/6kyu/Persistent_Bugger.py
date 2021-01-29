import math

def persistence(n):
    k = 0
    count = 0
    while n > 9:
        d = math.floor(math.log10(n))
        nt = 1
        count += 1
        for i in range(d, -1, -1):
            k = math.floor(n / (10 ** i))
            nt *= k
            n -= k * (10 ** i)
        if nt > 9: n = nt
    
    return count