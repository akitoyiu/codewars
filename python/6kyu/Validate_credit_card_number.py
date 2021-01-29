def validate(n):
    sn = list(str(n))
    swt = True
    
    for i in range(len(sn)-2, -1, -1):
        if swt == True:
            tn = int(sn[i]) * 2
            if tn > 9: tn = 1 + (tn%10)
            sn[i] = str(tn)
            swt = False
        else:
            swt = True
    
    result = 0
    for i in sn:
        result += int(i)
    
    return True if result % 10 == 0 else False