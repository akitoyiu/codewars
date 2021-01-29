def expanded_form(num):
    num = str(num)
    result = ""
    for i in range(0, len(num)):
        if num[i] != "0":
            if i > 0: result += " + "
            result = result + str(int(num[i]) * 10 ** (len(num) - i-1))
            
    
    return result