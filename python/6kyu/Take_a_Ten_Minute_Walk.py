def is_valid_walk(walk):
    h = 0
    v = 0
    
    if len(walk) != 10: return False
    
    for i in walk:
        if i == 'n': v += 1
        elif i == 's': v -= 1
        elif i == 'w': h -= 1
        elif i == 'e': h += 1
            
    return True if h == 0 and v == 0 else False