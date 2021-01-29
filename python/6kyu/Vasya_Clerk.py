def tickets(people):
    changes = {25:0, 50:0}
    
    for i in range(0, len(people)):
        #print("Have changes {}, incoming{}", sum(changes.values()), people[i])
        if people[i] == 25: changes[25] += 25
        else:
            if people[i] == 100:
                if (changes[50] > 0 and changes[25] > 0): 
                    changes[50] -= 50
                    changes[25] -= 25
                elif changes[25] >= 75:
                    changes[25] -= 75
                else: return 'NO'
                
            
            if people[i] == 50:
                if (changes[25] > 0):
                    changes[25] -= 25
                    changes[50] += 50
                else: return 'NO'
                
            
    return 'YES'