def tower_builder(n_floors):
    ele = 1 + (n_floors - 1) * 2
    result = ([])
    for i in range(0, n_floors):
        side = int((ele - (1+(i*2)))/2)
        result.append( ''.join(' '*side) + ''.join('*' * (1+(i*2))) + ''.join(' '*side)  )
    
    return result