def wave(people):
    if people == "": return ([])
    
    result = ([])
    ts = list(people)
    
    for i in range(0, len(people)):
        if ts[i] != ' ':
            ts[i] = ts[i].upper()
            result.append("".join(ts))
            ts[i] = ts[i].lower()
    
    return result