def camel_case(string):
    if string == "": return ""
    string = string.lower().split(" ")
    
    result = ([])
    for i in string:
        result.append(i[:1].upper() + i[1:])
        
    return "".join(result)