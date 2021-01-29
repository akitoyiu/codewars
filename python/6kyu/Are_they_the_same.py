def comp(array1, array2):
    
    if array1 == None or array2 == None or len(array1) != len(array2): return False
    if not array1:
        if not array1 and not array2: return True
        else: return False
    else:
        array1 = list(map(abs, array1))
        array2 = list(map(abs, array2))
        array1.sort()
        array2.sort()
    
    for i in range(0, len(array1)):
        if array1[i] * array1[i] != array2[i]: return False
        
    return True