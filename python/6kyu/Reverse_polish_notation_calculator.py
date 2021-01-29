def calc(expr):
    # TODO: Your awesome code here
    if expr == "": return 0
    
    sn = expr.split(" ")
    if len(sn) == 1: return float(sn[0])

    buffer = ([])
    
    result = 0
    for i in sn:
        if i.isdigit() or isfloat(i):
            buffer.append(float(i))
        else:
            b = float(buffer.pop())
            if result == 0: a = float(buffer.pop())
            else: a = result
            if i == "+": result = a + b
            elif i == "-": result = a - b
            elif i == "*": result = a * b
            elif i == "/": result = a / b
        
    return result


def isfloat(value):
    try:
        float(value)
        return True
    except ValueError:
        return False