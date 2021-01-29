def solution(roman):
    result = 0
    i = 0
    table = {"M":1000, "CM":900, "CD":400, "D":500, "C":100, "XC":90, "XL":40, "L":50, "X":10, "IX":9, "IV":4, "V":5, "I":1}
    
    while i < len(roman):
        nc = roman[i]
        if i+1 < len(roman):
            if nc == "C" and  ( roman[i+1] == "M" or roman[i+1] == "D"): 
                i += 1
                nc += roman[i]
                
            if nc == "X" and ( roman[i+1] == "C" or roman[i+1] == "L"):
                i += 1
                nc += roman[i]
                
            if nc == "I" and ( roman[i+1] == "X" or roman[i+1] == "V" ):
                i += 1
                nc += roman[i]
        
        
        result += table[nc]
        
        i += 1
        
    return result