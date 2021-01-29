def alphabet_position(text):
    abc = "abcdefghijklmnopqrstuvwxyz"
    codeMap = {}
    for i in range(0,26):
        codeMap[abc[i]] = str(i + 1)
    
    text = text.lower()
    result = []
    
    for i in range(0, len(text)):
        if text[i] in codeMap:
            result.append(codeMap[text[i]])
    
    return ' '.join(result)