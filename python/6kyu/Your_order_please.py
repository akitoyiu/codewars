def order(sentence):
    wordList = ([])
    for i in range(0,10):
        wordList.append("")
        
    sentList = sentence.split(" ")
    for i in sentList:
        if "1" in i: wordList[0] = i
        if "2" in i: wordList[1] = i
        if "3" in i: wordList[2] = i
        if "4" in i: wordList[3] = i
        if "5" in i: wordList[4] = i
        if "6" in i: wordList[5] = i
        if "7" in i: wordList[6] = i
        if "8" in i: wordList[7] = i
        if "9" in i: wordList[8] = i
  # code here
    
    result = " ".join(wordList)
    

    return result.strip()