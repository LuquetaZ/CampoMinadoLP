Algoritmo "CampoMinado"

Var
tabela:vetor[1..6,1..6]de inteiro
verifica,i, j, linha, coluna, soma: inteiro

Inicio
// atribui��o de valores para as variaveis e cada posi��o da matriz
soma:= 0
linha:=1
coluna:=1
tabela[1,1]:=1
tabela[1,2]:=2
tabela[1,3]:=1
tabela[1,4]:=1
tabela[1,5]:=2
tabela[1,6]:=1
tabela[2,1]:=1
tabela[2,2]:=1
tabela[2,3]:=1
tabela[2,4]:=1
tabela[2,5]:=2
tabela[2,6]:=1
tabela[3,1]:=2
tabela[3,2]:=1
tabela[3,3]:=1
tabela[3,4]:=2
tabela[3,5]:=1
tabela[3,6]:=2
tabela[4,1]:=1
tabela[4,2]:=1
tabela[4,3]:=2
tabela[4,4]:=1
tabela[4,5]:=1
tabela[4,6]:=1
tabela[5,1]:=1
tabela[5,2]:=1
tabela[5,3]:=1
tabela[5,4]:=1
tabela[5,5]:=2
tabela[5,6]:=1
tabela[6,1]:=2
tabela[6,2]:=1
tabela[6,3]:=2
tabela[6,4]:=1
tabela[6,5]:=1
tabela[6,6]:=1

// apresentar uma tabela 6x6 com todas as posi��es indefinidas
para i de 1 ate 6 passo 1 faca
     para j de 1 ate 6 passo 1 faca
          escreva (" ?")
          escreva (" |")
     fimpara
     escreval ("")
fimpara
escreval("")
escreval("")

// instru��o ao jogador
escreval("Bem vindo ao jogo do Campo Minado!")
escreval("Seu objetivo � acertar 6 espa�os sem encontrar uma bomba.")
escreval("As casas com 1 s�o vazias e as casas com 2 cont�m bombas.")

// repeti��o at� que o jogador consiaga evitar a bomba 6 vezes ou perca (acerte uma bomba)
enquanto (soma<>6) E (tabela[linha,coluna]<>2) faca
   // intera��o com o usu�rio | leitura de linha e coluna
   escreval("Digite a linha que voc� deseja entre 1 e 6:")
   leia(linha)
   escreval("Digite a coluna que voc� deseja entre 1 e 6:")
   leia(coluna)
   // condi��o para caso a posi��o digitada esteja vazia(1)
   // porque caso seja bomba(2) ele ir� sair direto do loop
   se(tabela[linha,coluna]=1)entao
      // mensagem de parabeniza��o
      escreval("Muito bem, voc� n�o encontrou uma bomba!")
      // soma a vari�vel de chances at� o 6 (como dito anteriromente)
      soma:=soma+1
    // Imprimi a matriz 6x6
    para i de 1 ate 6 passo 1 faca
     para j de 1 ate 6 passo 1 faca
       // condi��o para caso o i e j sejam iguais a linha e coluna digitada pelo
       // usu�rio, para que escreva o valor contido na posi��o que o jogador escolheu
       se(i = linha) E (j=coluna) entao
          escreva (tabela[linha,coluna])
          escreva (" |")
       senao
          escreva (" ?")
          escreva (" |")
       fimse
     fimpara
     escreval ("")
    fimpara
   fimse
   
fimenquanto

// ao sair do loop, temos uma condi��o para mandar dois tipos de mensagem de finaliza��o
se (tabela[linha,coluna] = 2)entao
   // caso ap�s sair do loop e a posi��o que o usuario tirou for uma bomba, ent imprimi com a posi��o em que o jogador digitou
   para i de 1 ate 6 passo 1 faca
     para j de 1 ate 6 passo 1 faca
       se(i = linha)E (j=coluna) entao
          escreva (tabela[linha,coluna])
          escreva (" |")
       senao
          escreva (" ?")
          escreva (" |")
       fimse
     fimpara
     escreval ("")
fimpara
   // Mensagem informando que perdeu
   escreva("Voc� encontrou uma bomba, voc� PERDEU!!!")
senao
   // mensagem informando caso o jogador evite a bomba 6 vezes
   escreva("Voc� escapou das bombas. Parb�ns voc� GANHOU!!!")
fimse

Fimalgoritmo