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
            int soma = 0;
            int linha = 1;
            int coluna = 1;

            int[,] tabela = new int[5, 5] { {1,2,1,1,2,1 }, { 1, 1, 1, 1, 2, 1 }, { 2, 1, 1, 2, 1, 2 }, { 1, 1, 2, 1, 1, 1 }, { 1, 1, 1, 1, 2, 1 }, { 2, 1, 2, 1, 1, 1 } } ;
            

            
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

            Console.WriteLine("Bem vindo ao jogo do Campo Minado!");
            Console.WriteLine("Seu objetivo é acertar 6 espaços sem encontrar uma bomba.");

            while (soma != 6 && tabela[linha, coluna] == 2) 
            {
                Console.WriteLine("Digite a linha que você deseja entre 0 e 5:");
                linha = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Digite a coluna que você deseja entre 0 e 5:");
                coluna = Convert.ToInt32(Console.ReadLine());

                if (tabela[linha,coluna] == 1)
                {
                    Console.WriteLine("Muito bem, você não encontrou uma bomba!");
                    soma++;
                }
            }
            if (tabela[linha, coluna] == 2)
            {
                Console.WriteLine("Você encontrou uma bomba, você PERDEU!!!");
            }
            else
            {
                Console.WriteLine("Você escapou das bombas. Parbéns você GANHOU!!!");
            }
        }
    }
}
