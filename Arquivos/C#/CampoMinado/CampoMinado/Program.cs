using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampoMinado
{
    class Program
    {
        static void Main(string[] args)
        {
            // declaração das variáveis e definição de valores
            int soma = 0;
            int linha = 0;
            int coluna = 0;
            int i, j;

            // criação de uma array bidimensional
            int[,] tabela = new int[6, 6] { {1,2,1,1,2,1 }, { 1, 1, 1, 1, 2, 1 }, { 2, 1, 1, 2, 1, 2 }, { 1, 1, 2, 1, 1, 1 }, { 1, 1, 1, 1, 2, 1 }, { 2, 1, 2, 1, 1, 1 } } ;
            
            // informando valor de cada posição
            tabela[0, 0] = 1;
            tabela[0, 1] = 2;
            tabela[0, 2] = 1;
            tabela[0, 3] = 1;
            tabela[0, 4] = 2;
            tabela[0, 5] = 1;

            tabela[1, 0] = 1;
            tabela[1, 1] = 1;
            tabela[1, 2] = 1;
            tabela[1, 3] = 1;
            tabela[1, 4] = 2;
            tabela[1, 5] = 1;

            tabela[2, 0] = 2;
            tabela[2, 1] = 1;
            tabela[2, 2] = 1;
            tabela[2, 3] = 2;
            tabela[2, 4] = 1;
            tabela[2, 5] = 2;

            tabela[3, 0] = 1;
            tabela[3, 1] = 1;
            tabela[3, 2] = 2; 
            tabela[3, 3] = 1;
            tabela[3, 4] = 1;
            tabela[3, 5] = 1;

            tabela[4, 0] = 1; 
            tabela[4, 1] = 1;
            tabela[4, 2] = 1;
            tabela[4, 3] = 1;
            tabela[4, 4] = 2;
            tabela[4, 5] = 1;

            tabela[5, 0] = 2;
            tabela[5, 1] = 1; 
            tabela[5, 2] = 2;
            tabela[5, 3] = 1;
            tabela[5, 4] = 1; 
            tabela[5, 5] = 1;



            // apresentar uma tabela 6x6 com todas as posições indefinidas
            for (i = 0; i < 6; i++)
            {
                for (j = 0; j < 6; j++)
                {
                    Console.Write(" ?");
                    Console.Write(" |");
                }
                Console.WriteLine("");
            }
            Console.WriteLine("");

            // instrução ao jogador
            Console.WriteLine("Bem vindo ao jogo do Campo Minado!");
            Console.WriteLine("Seu objetivo é acertar 6 espaços sem encontrar uma bomba.");
            Console.WriteLine("As casas com 1 são vazias e as casas com 2 contém bombas.");

            // repetição até que o jogador consiaga evitar a bomba 6 vezes ou perca (acerte uma bomba)
            while (soma != 6 && tabela[linha, coluna] != 2) 
            {
                // interação com o usuário (leitura da linha e coluna)
                Console.WriteLine("Digite a linha que você deseja entre 0 e 5:");
                linha = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Digite a coluna que você deseja entre 0 e 5:");
                coluna = Convert.ToInt32(Console.ReadLine());

                // condição para caso a posição digitada esteja vazia(1) porque caso seja bomba(2) ele irá sair direto do loop
                if (tabela[linha,coluna] == 1)
                {
                    // mensagem de parabenização
                    Console.WriteLine("Muito bem, você não encontrou uma bomba!");
                    // soma a variável de chances até o 6 (como dito anteriromente)
                    soma++;

                    // Imprimi a matriz 6x6
                    for (i = 0; i < 6; i++)
                    {
                        for (j=0; j < 6; j++)
                        {
                            // condição para caso o i e j sejam iguais a linha e coluna digitada pelo usuário, para que escreva o valor contido na posição que o jogador escolheu
                            if (i == linha && j==coluna)
                            {
                                Console.Write(" "+ tabela[linha,coluna]);
                                Console.Write(" |");
                            }
                            else
                            {
                                Console.Write(" ?");
                                Console.Write(" |");
                            }
                        }
                        Console.WriteLine("");
                    }
                    Console.WriteLine("");
                }
            }

            // ao sair do loop, temos uma condição para mandar dois tipos de mensagem de finalização
            if (tabela[linha, coluna] == 2)
            {
                // caso após sair do loop e a posição que o usuario tirou for uma bomba, ent imprimi com a posição em que o jogador digitou
                for (i = 0; i < 6; i++)
                {
                    for (j = 0; j < 6; j++)
                    
                    {
                        if (i == linha && j == coluna)
                        {
                            Console.Write(" " + tabela[linha, coluna]);
                            Console.Write(" |");
                        }
                        else
                        {
                            Console.Write(" ?");
                            Console.Write(" |");
                        }
                    }
                    Console.WriteLine("");
                }
                // Mensagem informando que perdeu
                Console.WriteLine("");
                Console.WriteLine("Você encontrou uma bomba, você PERDEU!!!");
            }
            else
            {
                // mensagem informando caso o jogador evite a bomba 6 vezes
                Console.WriteLine("Você escapou das bombas. Parbéns você GANHOU!!!");
            }
            Console.ReadKey();
        }
    }
}
