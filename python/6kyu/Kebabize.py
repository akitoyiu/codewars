def kebabize(string):
    
    c = list(string)  
    result = ""
    first = True
    
    while len(c) > 0:
        i = c.pop(0)
        if i.isupper():
            i = i.lower()
            if not first:
                result += '-'
        if not i.isdigit(): 
            result += i
            first = False
    
    return result