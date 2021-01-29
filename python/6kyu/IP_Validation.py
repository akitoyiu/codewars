def is_valid_IP(strng):
    strng = strng.split(".")
    if len(strng) != 4: return False
    
    for i in strng:
        if len(i) > 1 and i[0] == "0": return False
        if not i.isdigit(): return False
        if int(i) > 255: return False
    
    return True