import numpy as np

def find_outlier(integers):
    intMod = np.array(integers) % 2
    
    odd = np.where(intMod == 1)
    even = np.where(intMod == 0)
    
    #print(integers[odd[0][0]])
    
    if np.count_nonzero(intMod == 1) < np.count_nonzero(intMod == 0):
        result = integers[odd[0][0]]
    else:
        result = integers[even[0][0]]
    
    return result