def solution(s):
    if len(s) % 2 == 1:
        s = s + "_"
        
    res = []
    
    #print(s[0:2])
    
    while len(s) > 0:
        res.append(s[0:2])
        s = s[2:]
        
    return res