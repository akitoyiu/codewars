def high(x):
    abc = "abcdefghijklmnopqrstuvwxyz"
    score = {}
    for i in range( 0 , len(abc)):
        score[abc[i]] = i + 1
    
    result = ""
    hscore = 0
    
    x = x.split(" ")
    
    for i in x:
        curr = 0
        for char in i:
            curr = curr + score[char]
        if curr > hscore:
            hscore = curr
            result = i
    
    return result