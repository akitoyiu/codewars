def group_check(s):
    inv = []
    
    for i in s:
        if i == '{': inv.append(1)
        if i == '[': inv.append(2)
        if i == '(': inv.append(3)
            
        if i == '}':
            if len(inv) == 0 or inv.pop() != 1: return False
            
        if i == ']':
            if len(inv) == 0 or inv.pop() != 2: return False
            
        if i == ')':
            if len(inv) == 0 or inv.pop() != 3: return False
    
    
    return False if len(inv) > 0 else True