def thirt(n):
    n = str(n)
    m13 = ([])
    for i in range(0, len(n)):
        m13.append( (10 ** i) % 13)
    cth = 0
    th = -1
    
    while cth != th:
        rn = n[::-1]
        for i in range(0, len(rn)):
            cth += int(rn[i]) * m13[i]
        n = str(cth)
        if cth != th:
            th = cth
            cth = 0
    
    return th