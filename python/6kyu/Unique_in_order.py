def unique_in_order(iterable):
    lastc = " "
    newList = ([])
    for item in iterable:
        if item != lastc:
            lastc = item
            newList.append(item)
            
    return newList