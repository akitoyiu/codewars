def validPhoneNumber(phoneNumber):
    number = ['0', '1', '2', '3', '4', '5', '6', '7', '8', '9']
    
    for i in range(0, len(phoneNumber)):
        if i == 0: 
            if phoneNumber[i] != "(": return False
        elif i == 4:
            if phoneNumber[i] != ")": return False
        elif i == 5: 
            if phoneNumber[i] != " ": return False
        elif i == 9:
            if phoneNumber[i] != "-": return False
        else:
            if not phoneNumber[i] in number: 
                return False
    
    return True