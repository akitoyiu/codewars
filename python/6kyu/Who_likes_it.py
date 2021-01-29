def likes(names):
    nl = len(names)
    i = 0
    result = ""
    if nl == 0: return "no one likes this"
    elif nl == 1: return names[0] + " likes this"
    elif nl == 2: return names[0] + " and " + names[1] + " like this"
    elif nl == 3: return names[0] + ", " + names[1] + " and " + names[2] + " like this"
    else: return names[0] + ", " + names[1] + " and " + str(nl - 2) + " others like this"
    return result