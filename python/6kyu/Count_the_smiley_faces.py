def count_smileys(arr):
    eyes = [":", ";"]
    nose = ["-", "~"]
    mouth = [")", "D"]
    
    count = 0
    
    for i in arr:
        sLen = len(i)
        if i[0] in eyes and i[sLen -1] in mouth:
            if sLen == 2: count += 1
            elif sLen == 3:
                if i[1] in nose: count += 1
            
    return count #the number of valid smiley faces in array/list