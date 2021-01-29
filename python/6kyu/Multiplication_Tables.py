def multiplication_table(row,col):
    result = ([])
    for r in range(1, row+1):
        tmp = ([])
        for c in range(1, col+1):
            tmp.append(c*r)
        result.append(tmp)
        
    return result


def multiplication_table(size):
    result = ([])
    
    for j in range(1, size + 1):
        tmp = ([])
        for i in range(1, size+1):
            tmp.append(j*i)
        result.append(tmp)
    
    
    return result