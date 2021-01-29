def revrot(strng, sz):
    words = []
    result = ""
    
    if sz == 0 or sz > len(strng): return ""
    
    i = 0
    while i - 1 + sz < len(strng):
        words.append(strng[i:sz + i])
        i += sz
                     
    for i in words:
        if sumofCube(i) % 2 == 0: result += i[::-1]
        else: result += i[1:] + i[:1]
    
    
    return result
    # your code
    
def sumofCube(strng):
    result = 0
    for i in strng:
        result += int(i) ** 3
        
    return result