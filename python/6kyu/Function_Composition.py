def compose(f,g):
    return lambda *args : f(g(*args)) 
    # Compose the two functions here!