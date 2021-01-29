def to_weird_case(string):
    string = string.split(" ")
    newString = ([])
    
    for i in string:
        ts = list(i)
        for j in range(0, len(i)):
            if j % 2 == 0: ts[j] = ts[j].upper()
            else: ts[j].lower()
        newString.append(''.join(ts))
        
        
    return " ".join(newString)