y = int(input("digite a largura: "))
x = int(input("digite a altura: "))
linhas = 0
while linhas < x:
    colunas = 0
    while colunas < y - 1:
        print("#", end="")
        colunas += 1
    print("#") 
    linhas += 1