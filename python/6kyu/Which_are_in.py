def in_array(array1, array2):
    result = []
    
    for i in array1:
        inIt = False
        for j in array2:
            if i in j: inIt = True
        if inIt: result.append(i)
    result = list(set(result))
    result.sort()
    
    return result