def clean_string(s):
    # your code here
    result = []
    for i in s:
        if i == "#":
            if len(result) > 0: result.pop()
        else:
            result.append(i)
    return "".join(result)