import math

def encrypt(text, n):
    if text == "" or text == None: return text

    st = list(text)

    for t in range(0, n):        
        left = []
        right = []    
        for i in range(0, len(st)):
            if i % 2 == 0:
                right.append(st.pop(0))
            else:
                left.append(st.pop(0))
            
        st = left + right
        
    return "".join(st)


def decrypt(encrypted_text, n):
    if encrypted_text == "" or encrypted_text == None: return encrypted_text
    st = list(encrypted_text)
    sl = math.floor(len(st) / 2)
    
    for t in range(0, n):
        left = st[0:sl]
        right = st[sl:]        
        st = []
        while len(left) > 0 or len(right) > 0:
            if len(right)> 0: st.append(right.pop(0))
            if len(left)> 0: st.append(left.pop(0))
    return "".join(st)



