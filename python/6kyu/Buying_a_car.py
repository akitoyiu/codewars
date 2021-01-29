import math

def nbMonths(startPriceOld, startPriceNew, savingperMonth, percentLossByMonth):
    # your code
    
    i = 0
    net = startPriceOld - startPriceNew
    
    while net < 0:
        
        rate = 1- (percentLossByMonth + (0.5 * math.floor((i+1)/2) ))/100
        startPriceOld = startPriceOld * rate
        startPriceNew = startPriceNew * rate
        net = (startPriceOld + savingperMonth * (i+1)) - startPriceNew
        #print("month{}, rate {}, net{}", i, rate, net)
        i += 1
        
    return [i, round(net, 0)]