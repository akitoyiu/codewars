def solution(s):
    result = ([])
    if s == "": return ""
    j = 0
    for i in range(1, len(s)):
        if s[i].isupper():
            result.append(s[j:i])
            j = i
            
        if i+1 == len(s):
            result.append(s[j:i+1])
    
    return " ".join(result)