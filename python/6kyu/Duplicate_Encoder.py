def duplicate_encode(word):
    word = word.lower()
    result = []
    
    for var in word:
        if word.count(var) > 1: 
            result.append(")")
        else: 
            result.append("(")
        
    return ''.join(result)