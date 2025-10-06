primos = [2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97]
primos[0:12] # pega uma parte da lista, do índice 0 ao 11 (12-1)
primos[:12]
primos[12:25]           #se for pra pegar do começo nem precisa colocar o 0, mesma coisa pro final
primos[12:]



# clonar uma lista
def clone(lista):
    clone = []
    for objeto in lista1:
        clone.append(objeto)
    return clone

lista2 = lista1[:] # mais facil assim