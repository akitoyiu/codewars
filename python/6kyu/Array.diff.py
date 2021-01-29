def array_diff(a, b):
    b = set(b)
    result = []
    
    for i in a:
        if i not in b: result.append(i)
        
    return result