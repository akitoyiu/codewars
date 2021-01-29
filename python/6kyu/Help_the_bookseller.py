def stock_list(listOfArt, listOfCat):
    tag = {}
    if listOfArt == []: return ''
    
    for i in listOfCat:
        tag[i] = 0
    
    for i in listOfArt:
        ts = i.upper().split(" ")
        head = ts[0][0]
        count = int(ts[1])
        if head in tag:
            tag[head] += count
    
    result = ""
    for k, v in tag.items():
        result += "(" + k + " : " + str(v) + ") - "
        
    return result[:-3]