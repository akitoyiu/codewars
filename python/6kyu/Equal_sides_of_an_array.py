def find_even_index(arr):
    sumList = ([0])
    tempSum = 0
    for i in reversed(arr):
        tempSum += i
        sumList.append(tempSum)
    
    sumList = sumList[::-1]
    tempSum = 0
    for i in range(0, len(arr)):
        #print("tempsum {}, sumList{}", tempSum, sumList[i+1])
        if tempSum == sumList[i+1]: return i
        tempSum += arr[i]
        
    return -1