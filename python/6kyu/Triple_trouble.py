def triple_double(num1, num2):
    
    sn1 = list(str(num1))
    sn2 = list(str(num2))
    
    sn1.sort()
    sn2.sort()
    
    ti = ""
    counter = 0
    li = "";
    for i in sn1:
        if i == li: 
            counter += 1
            if counter == 3:
                ti = i
                break
        else:
            li = i
            counter = 1
    li = "-"
    for i in sn2:
        if i == ti:
            if i == li: counter += 1
            else:
                li = i
                counter = 1
                
    return 1 if ti != "" and counter == 2 else 0