import numpy as np

def most_customers(dannys_pitch):
    
    result = ([])
    dv = dannys_pitch[1]
    dh = dannys_pitch[0]
    if dv > 2 or dh > 2: return [[0,0]]
    
    if dannys_pitch == [0,0]: 
        return [[-1,-1],[-1,0],[-1,1],[0,-1],[0,1],[1,-1],[1,0],[1,1]]
    
    vd = -1 if dv > 0 else 1
    vertical = abs(dannys_pitch[1]) + 2
    
    hd = -1 if dh > 0 else 1
    horizontal = abs(dannys_pitch[0]) + 2
    
    if vertical == horizontal:
        result.append([dh+hd, dv])
        result.append([dh, dv+vd])
        result.append([dh+hd, dv+vd])
    elif vertical > horizontal:
        result.append([dh, dv+vd])
    else:
        result.append([dh+hd, dv])
    
    result.sort()
    
    return result# bestCoordinates #