def sqInRect(lng, wdth):
    result = ([])
    
    
    if lng == wdth: return None
    
    if lng > wdth: 
        a = lng
        b = wdth
    else: 
        a = wdth
        b = lng
        
    while a != b:
        result.append(b)
        c = b
        b = a - b
        a = c
        if b > a: a, b = b, a
    
    result.append(a)
    #result.append(b)
    
    # your code
    return result