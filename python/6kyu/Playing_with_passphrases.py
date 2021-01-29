def play_pass(s, n):
    seq = ['A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 
           'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V',
           'W', 'X', 'Y', 'Z']
    
    s = s.upper()
    result = []
    
    for i in s:
        if i.isdigit(): result.append(str(9-int(i)))
        elif i.isalpha(): 
                idx = seq.index(i) + n
                idx = idx % 26
                result.append(seq[idx])
        else: result.append(i)
    
    for i in range(0, len(result)):
        if i % 2 == 1: result[i] = result[i].lower()
            
    return "".join(result[::-1])