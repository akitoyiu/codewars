def title_case(title, minor_words=''):
    
    if title == '': return ''
    
    title = title.lower()
    title = title.split(" ")
    minor_words = minor_words.lower()
    minor_words = minor_words.split(" ")
    
    result = ([])
    
    for i in range(0, len(title)):
        if i > 0 and title[i] in minor_words:
            result.append(title[i])
        else:
            ts = list(title[i])
            ts[0] = ts[0].upper()
            result.append(''.join(ts))
    
    return " ".join(result)