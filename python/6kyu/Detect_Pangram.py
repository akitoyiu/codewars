import string

def is_pangram(s):
    checkString = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
    s = list(s.upper())
    
    for i in checkString:
        if not i in s: return False
    
    return True