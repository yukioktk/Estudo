y = int(input("digite a largura: "))
x = int(input("digite a altura: "))
altura = 0
while altura < x:
    largura = 0
    while largura < y - 1:
        if altura == 0 or altura == x - 1 or largura == 0:
            print("#", end="")
        else:
            print(" ", end="")
        largura += 1
    print("#") 
    altura += 1