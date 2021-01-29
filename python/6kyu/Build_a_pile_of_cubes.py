def find_nb(m):
    n = 1;
    total = 1;
    while total < m:
        n += 1
        total = total + (n**3)
        
    if total == m: return n
    else: return -1