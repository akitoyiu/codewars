def count(string):
    # The function code should be here
    result = {}
    for i in string:
        if i in result:
            result[i] += 1
        else:
            result[i] = 1
    
    return result