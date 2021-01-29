#Find the missing term in an Arithmetic Progression

def find_missing(sequence):
    
    nd = sequence[1] - sequence[0] 
    sd = 0
    
    
    for i in range(2, len(sequence)):
        cd = sequence[i] - sequence[i-1]
        if cd != nd and sd == 0: sd = cd
        elif cd != nd and sd == cd: nd, sd = sd, nd
            
    for i in range(1, len(sequence)):
        cd = sequence[i] - sequence[i-1]
        if cd == sd:
            return sequence[i-1] + nd
    
    return None