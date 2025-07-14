numero = int(input("Insira o número: ") )

resultado=1
temp=1

while temp <= numero:
    resultado *= temp
    temp += 1

print(resultado)