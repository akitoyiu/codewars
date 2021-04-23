def move_zeros(array):
    result = []
    zero = 0
    
    for i in array:
        if i == 0:
            zero += 1
        else:
            result.append(i)
    j = 0
      
    while j < zero:
        result.append(0)
        j += 1
    
    return result