import math

def nbr_of_laps(x, y):
    
    sx = math.ceil(max(math.sqrt(x), math.sqrt(y)))
    
    if x == y: return (1, 1)
    
    for i in range(2, sx):
        while x % i == 0 and y % i == 0:
            x = x / i
            y = y / i
    
    return (y, x)