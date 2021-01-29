#Format a string of names like 'Bart, Lisa & Maggie'.

def namelist(namelist):
    result = ""
    for i in range(0, len(namelist)):
        result = result + namelist[i]['name']
        if i < len(namelist)-2: result += ", "
        elif i < len(namelist)-1: result += " & "
            
    return result