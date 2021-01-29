import numpy as np

def queue_time(customers, n):
    q = []
    if customers == q: return 0
    
    for i in range(0, n):
        q.append(0)
    q = np.array(q)
    
    for i in customers:
        idx = np.argmin(q)
        q[idx] += i
        
    return max(q)