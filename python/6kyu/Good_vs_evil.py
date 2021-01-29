def goodVsEvil(good, evil):
    goodWorth = [1, 2, 3, 3, 4, 10]
    evilWorth = [1, 2, 2, 2, 3, 5, 10]
    
    good = good.split(" ")
    good = list(map(int, good))
    evil = evil.split(" ")
    evil = list(map(int, evil))
    
    gs = 0
    es = 0
    for i in range(0, len(good)):
        gs += good[i] * goodWorth[i]
        
    for i in range(0, len(evil)):
        es += evil[i] * evilWorth[i]
    
    
    if es == gs: return "Battle Result: No victor on this battle field"
    elif gs > es: return "Battle Result: Good triumphs over Evil"
    else: return "Battle Result: Evil eradicates all trace of Good"