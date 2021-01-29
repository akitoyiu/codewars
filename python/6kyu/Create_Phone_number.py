def create_phone_number(n):
    sn = list(map(str, n))
    return "(" + "".join(sn[0:3]) + ") " + "".join(sn[3:6]) + "-" + "".join(sn[6:10])