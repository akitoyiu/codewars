def duplicate_count(text):
    text = text.upper()
    ts = set(text)
    k = 0
    for ti in ts:
        if text.count(ti) > 1: k += 1
            
    return k