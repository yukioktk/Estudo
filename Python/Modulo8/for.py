contador = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10]

for x in contador:
	print("Números: ", x)
	

for i in range(20): # range é usado para fazer uma contagem de 20 números a partir do zero
    print(i)

for i in range(10, 20): # o segundo parâmetro indica o final da contagem
    print(i)

for i in range(10, 50, 5): # o terceiro parâmetro indica o passo da contagem, de 5 em 5
    print(i)               # obs. so o passo for negativo, ele vai contar de trás para frente



valores = []
for i in range(1, 10):
    if i % 2 == 0:
        valores.append(i)
        i


valores = []
for i in range(2, 10, 2):
    valores.append(i)
    i



