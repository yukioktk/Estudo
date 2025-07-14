import math

# primeiro ponto
x1 = int(input("Insira o X do primeiro ponto: "))
y1 = int(input("Insira o Y do primeiro ponto: "))
# segundo ponto
x2 = int(input("Insira o X do segundo ponto: "))
y2 = int(input("Insira o Y do segundo ponto: "))


calculo = math.sqrt((x1 - x2)**2 + (y1 - y2)**2)

if calculo >= 10:
  print("longe")
else:
  print("perto")