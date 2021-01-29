def parse(data):
    
    num = 0
    result = ([])
    for i in data:
        if i == 'i': num += 1
        elif i == 'd': num -= 1
        elif i == 's': num = num ** 2
        elif i == 'o': result.append(num)
            
    return result