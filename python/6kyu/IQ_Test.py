import numpy as np

def iq_test(numbers):
    numbers = numbers.split(" ")
    numbers = list(map(int, numbers))
    numbers = np.array(numbers)
    numbers = numbers % 2
    numbers = numbers.tolist()
    
    return numbers.index(1) + 1 if numbers.count(0) > numbers.count(1) else numbers.index(0) + 1