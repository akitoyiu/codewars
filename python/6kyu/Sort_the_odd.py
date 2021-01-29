def sort_array(source_array):
    oddList = ([])
    for i in source_array:
        if i % 2 == 1: oddList.append(i)
            
    oddList.sort()
    next = 0
    for i in range(0, len(source_array)):
        if source_array[i] % 2 == 1: 
            source_array[i] = oddList[next]
            next += 1
    
    return source_array