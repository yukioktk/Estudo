def maior_primo(x):
    if x <= 1:
        return None

    def éPrimo(k):
        temp = 2
        while temp * temp <= k:
            if k % temp == 0:
                return False
            temp += 1
        return True
    
    while x > 1:
        if éPrimo(x):
            return x
        x -= 1


    
print(maior_primo(100))