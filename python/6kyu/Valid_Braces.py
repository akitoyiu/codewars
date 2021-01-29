def validBraces(s):
    
    openbrace = []
    result = True
    
    for i in range(0,len(s)):
        #print(s, '\n')
        #print(openbrace, ", Len: ", str(len(openbrace)))
        if s[i] == '(' or s[i] == '[' or s[i] == '{':
            openbrace.append(s[i])
        
        if s[i] == ')' or s[i] == ']' or s[i] == '}':
            
            if len(openbrace) > 0:
                if s[i] == ')' and openbrace[-1] != '(': result = False 
                if s[i] == ']' and openbrace[-1] != '[': result = False 
                if s[i] == '}' and openbrace[-1] != '{': result = False 
            
                openbrace = openbrace[:-1]
            else: result = False
        
    if len(openbrace) > 0: result = False
    
    return result