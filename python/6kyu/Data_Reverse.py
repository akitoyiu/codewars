def data_reverse(data):
    result = ([])
    for i in range(len(data)-8, -1, -8):
        for j in range(0, 8):
            result.append(data[i + j])
            
    return result