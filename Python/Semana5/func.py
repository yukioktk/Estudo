def soma(x, y):
    return x + y

print (soma(10, 20))
print (soma(-20, 100))
print(soma(20 * 32, soma(3, 4)))


def multiplica(x, y, z):
    return x * y * z

print(multiplica(20, 30, 100))
print(multiplica(soma(20, 40), soma(65, 3), multiplica(2, 3, 4)))


def evitadog():
    return "oi"

print(evitadog())


def conta():
    x = 10 + 20
    return "O valor calculado é:", x

print(conta())
