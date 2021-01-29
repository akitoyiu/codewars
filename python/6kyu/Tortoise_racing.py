import math
def race(v1, v2, g):
    if v1 >= v2: return None
    
    diff = v2 - v1
    diff = diff / 3600
    diff = g / diff
    
    hour = math.floor(diff / 3600)
    minutes = math.floor(diff/60) % 60
    seconds = math.floor(diff % 60)
    
    return [hour, minutes, seconds]