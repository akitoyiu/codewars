#Statistics in Kata 2: AND case - Ball bags

def ball_probability(balls):
    #your code here
    
    fc = balls[0].count(balls[1][0])
    sc = balls[0].count(balls[1][1])
    bc = len(balls[0])
    
    if balls[2]:
        return round(fc/bc * sc/bc, 3)
    else:
        if balls[1][0] == balls[1][1]: sc -= 1
        return round(fc/bc * sc/(bc-1), 3)