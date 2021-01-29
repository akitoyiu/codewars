def find_uniq(arr):
    # your code here
    uarr = set(arr)
    for i in uarr:
        if arr.count(i) == 1: return i