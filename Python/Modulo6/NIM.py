def computador_escolhe_jogada(n, m):
    if n % (m + 1) > 0:
        pecas = n % (m + 1) 
        print("O computador tirou", pecas ,"peças")
        return pecas
    else:
        pecas = m
        print("O computador tirou", pecas ,"peças")
        return pecas

def usuario_escolhe_jogada(n, m):
    while True:
        pecas = int(input("Quantas peças você vai tirar? "))
        if pecas > m or pecas < 1 or pecas > n:
            print("Oops! Jogada inválida! Tente de novo.")
        else:
            print("Você tirou", pecas ,"peças")
            return pecas

def partida():
    n = int(input("Quantas peças? "))
    m = int(input("Limite de peças por jogada? "))

    if n % (m + 1) == 0:
        print("Você começa!")
        n -= usuario_escolhe_jogada(n, m)
        print("Agora restam", n, "peças no tabuleiro.")
        
        while n > 0:
            n -= computador_escolhe_jogada(n, m)
            print("Agora restam", n, "peças no tabuleiro.")
            if n == 0:
                print("Fim do jogo! O computador ganhou!")
                return "computador"
            n -= usuario_escolhe_jogada(n, m)
            print("Agora restam", n, "peças no tabuleiro.")
            if n == 0:
                print("Fim do jogo! Você ganhou!")
                return "usuario"
    else:
        print("Computador começa!")
        n -= computador_escolhe_jogada(n, m)
        print("Agora restam", n, "peças no tabuleiro.")
        while n > 0:
            n -= usuario_escolhe_jogada(n, m)
            print("Agora restam", n, "peças no tabuleiro.")
            if n == 0:
                print("Fim do jogo! Você ganhou!")
                return "usuario"
            n -= computador_escolhe_jogada(n, m)
            print("Agora restam", n, "peças no tabuleiro.")
            if n == 0:
                print("Fim do jogo! O computador ganhou!")
                return "computador"

def campeonato():
    rodada =  0
    pontos_computador = 0
    pontos_usuario = 0

    for _ in range(3):
        rodada += 1
        print("**** Rodada ", rodada, " ****")
        vencedor = partida()

        if vencedor == "computador":
            pontos_computador += 1
        else:
            pontos_usuario += 1
        print("Placar: Você ", pontos_usuario, " X ", pontos_computador, " Computador")
    print("**** Final do campeonato! ****\nPlacar: Você ", pontos_usuario, " X ", pontos_computador, " Computador")



print("Bem-vindo ao jogo do NIM! Escolha:\n\n1 - para jogar uma partida isolada\n2 - para jogar um campeonato")
escolha = int(input("Digite o número da sua opção: "))
if escolha == 1:
    print("Você escolheu uma partida isolada!")
    partida()
elif escolha == 2:
    print("Você escolheu um campeonato!")
    campeonato()
else:
    print("Opção inválida! Tente novamente.")