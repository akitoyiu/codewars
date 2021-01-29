def solution(num):
    # TODO convert int to roman string
    result = ""
    while num >= 1000:
        result += "M"
        num -= 1000
    if num >= 900:
        num -= 900
        result += "CM"
    elif num >= 500:
        num -= 500
        result += "D"
    elif num >= 400:
        num -= 400
        result += "CD"
        
    while num >= 100:
        result += "C"
        num -= 100
        
    if num >= 90:
        num -= 90
        result += "XC"
    elif num >= 50:
        num -= 50
        result += "L"
    elif num >= 40:
        num -= 40
        result += "XL"
        
    while num >= 10:
        num -= 10
        result += "X"
        
    if num == 9:
        result += "IX"
        num -= 9
    elif num >= 5:
        result += "V"
        num -= 5
    elif num == 4:
        num -= 4
        result += "IV"
        
    while num > 0:
        num -= 1
        result += "I"
    
    return result