import numpy as np
import pandas as pd

def meeting(s):
    s = s.upper().split(";")
    vlist = ([])
    klist = ([])
    
    for i in s:
        st = i.split(":")
        klist.append(st[0])
        vlist.append(st[1])
        
    df1 = pd.DataFrame({'x':klist,'y':vlist})
    
    result = ""

    for index, row in df1.sort_values(by=['y', 'x']).iterrows():
        result += "(" + row['y'] + ", " + row['x'] + ")"
        
    return result