def parts_sums(ls):
    
    total = sum(ls)
    result = ([])
    result.append(total)
    for i in ls:
        total -= i
        result.append(total)
    
    return result