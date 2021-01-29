def dashatize(n):
    if n != '' and n != None: 
        n = abs(n)
    else:
        return 'None'
    sn = str(n)
    
    result = ""
    for i in range(0,len(sn)):
        if int(sn[i]) % 2 == 1:
            if i > 0 and result[-1] != "-": result += "-"
            result += sn[i]
            if i < (len(sn) - 1): result += "-"
        else:
            result += sn[i]
    return result