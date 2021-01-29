import math

def is_prime(num):
    if num <= 0: return False
    if num == 1: return False
    if num == 2: return True
    
    num = abs(num)
    
    prime = [2]
    np = 2
    testRange = math.floor(math.sqrt(num))
    
    for i in range(2, testRange + 1):
        if num % i == 0: return False
        
    return True