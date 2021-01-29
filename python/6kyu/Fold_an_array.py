import math
def fold_array(array, runs):
    a = array[:]
    for i in range(0, runs):
        floc = math.floor(len(a)/2)
        for j in range(0, floc):
            a[j] = a[j] + a[len(a) - j - 1]
        a = a[0:floc+ (1 if len(a)%2 != 0 else 0) ]
    
    return a