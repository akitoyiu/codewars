def find_it(seq):
    seqSet = set(seq)
    
    for var in seqSet:
        if seq.count(var) % 2 == 1: return var