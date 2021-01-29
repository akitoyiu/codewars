def productFib(prod):
    
    # your code
    FN = [0, 1]
    i = 0
    
    while FN[i] * FN[i + 1] < prod:
        #print(FN)
        FN.append(FN[i] + FN[i+1])
        i += 1
    
    return [FN[i], FN[i+1], FN[i] * FN[i+1] == prod]