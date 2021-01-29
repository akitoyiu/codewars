#Delete occurrences of an element if it occurs more than n times

def delete_nth(order,max_e):
    inbook = {}
    newOrder = ([])
    for i in order:
        if i in inbook: 
            if inbook[i] < max_e:
                inbook[i] = inbook[i] + 1
                newOrder.append(i)
        else:
            inbook[i] = 1
            newOrder.append(i)
            
    return newOrder