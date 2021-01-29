def spin_words(sentence):
    sList = sentence.split(" ")
    result = ([])
    #print(list(sList[0]).reverse())
    
    for si in sList:
        if len(si) > 4:
            st = list(si)
            st.reverse()
            si = "".join(st)
        result.append(si)
        
    # Your code goes here
    return " ".join(result)