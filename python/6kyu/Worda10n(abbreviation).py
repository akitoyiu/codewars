def abbreviate(s):
    pos = 0
    result = ""
    for i in range(0, len(s)):
        if s[i].isalpha() == False:
            result += abbr(s[pos:i])
            result += s[i]
            pos = i + 1
    
    result += abbr(s[pos:len(s)])
    
    return result
    
def abbr(s):
    if len(s) < 4:
        return s
    else:
        return s[0] + str(len(s)-2) + s[-1]