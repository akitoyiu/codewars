def find_missing_letter(chars):
    abc = "abcdefghijklmnopqrstuvwxyz"
    
    startAlp = abc.index(chars[0].lower())
    isUpper = True if chars[0] != abc[startAlp] else False
    
    for i in range(0, len(chars)):
        if chars[i].lower() != abc[startAlp + i]: 
            return abc[startAlp + i].upper() if isUpper else abc[startAlp + i]
    
    return ""