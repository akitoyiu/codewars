def diamond(n):
    # Make some diamonds!
    if n < 1 or n % 2 == 0: return None
    if n == 1: return "*\n"
    side = int((n-1)/2)
    
    result = ""
    
    for i in range(0, n):
        if i < side:
            result += "".join(' '*(side-i)) + "".join('*'*(i*2+1)) + "\n"
        elif i == side:
            result += "".join('*'*n) + "\n"
        else:
            result += "".join(' '*(side-(n-i-1))) + "".join('*'*((n-i-1)*2+1)) + "\n"
    
    return result