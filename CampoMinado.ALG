Algoritmo "CampoMinado"

Var
tabela:vetor[1..6,1..6]de inteiro
linha, coluna, soma: inteiro

Inicio
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

escreval("Bem vindo ao jogo do Campo Minado!")
escreval("Seu objetivo é acertar 6 espaços sem encontrar uma bomba")
enquanto (soma<>6) E (tabela[linha,coluna]<>2) faca
   escreval("Digite a linha que você deseja entre 1 e 6:")
   leia(linha)
   escreval("Digite a coluna que você deseja entre 1 e 6:")
   leia(coluna)
   se(tabela[linha,coluna]=1)entao
      escreval("Muito bem, você não encontrou uma bomba!")
      soma:=soma+1
   fimse
fimenquanto
se (tabela[linha,coluna] = 2)entao
   escreva("Você encontrou uma bomba, você PERDEU!!!")
senao
   escreva("Você escapou das bombas. Parbéns você GANHOU!!!")
fimse

Fimalgoritmo