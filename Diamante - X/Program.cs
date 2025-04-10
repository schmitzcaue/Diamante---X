using System.Reflection.Metadata.Ecma335;
//Desenvolver um programa em que, dado um número ímpar como entrada,
// exibirá um diamante desenhado com a letra 'X'.

//● O programa deve solicitar ao usuário um número inteiro.
//● O número deve ser ímpar.Caso contrário, o programa deve informar que
//a entrada é inválida e solicitar um novo número.
//● O número de linhas e colunas deve ser igual ao número ímpar
//fornecido.
//● A linha central do diamante deve conter o número máximo de Xs.

namespace DiamanteX.ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
                ExibirCabecalho();

                int tamanhoDiamante = Convert.ToInt32(Console.ReadLine());

                ExibirMensagemDeErro(tamanhoDiamante);

                Console.WriteLine("Digite ENTER para continuar....");

                int quantidadeLinhas = (tamanhoDiamante - 1) / 2;
                int quantidadeEspaco = quantidadeLinhas;
                int quantidadeX = 1;

                //aqui
                ExibirMetodo(quantidadeLinhas, quantidadeEspaco, quantidadeX, tamanhoDiamante);

                Console.ReadLine();

                
                
            
        }
          

        static void ExibirCabecalho()
        {
            Console.Clear();
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Faça seu diamante!");
            Console.WriteLine("---------------------------------------------");
            Console.Write("Digite um número inteiro para montar seu diamante: ");
        }

        static void ExibirMensagemDeErro(int tamanhoDiamante)
        {

            if (tamanhoDiamante < 3 || tamanhoDiamante % 2 == 0)
            {
                Console.WriteLine("Digite outro número, ímpar maior que 1");

            }
        }

        static void ExibirMetodo(int quantidadeLinhas, int quantidadeEspaco, int quantidadeX, int tamanhoDiamante)
        {
            // parte de cima
            for (int i = 0; i < quantidadeLinhas; i++)
            {
                for (int espaco = 0; espaco < quantidadeEspaco; espaco++)
                    Console.Write(" ");

                for (int x = 0; x < quantidadeX; x++)
                    Console.Write("X");

                quantidadeX += 2;
                quantidadeEspaco--;

                Console.WriteLine();
            }

            #region parte do meio
            for (int i = 0; i < tamanhoDiamante; i++)
                Console.Write("X");

            Console.WriteLine();
            #endregion


            #region parte de baixo
            for (int i = 0; i < quantidadeLinhas; i++)
            {
                quantidadeX -= 2;
                quantidadeEspaco++;

                for (int espacos = 0; espacos < quantidadeEspaco; espacos++)
                    Console.Write(" ");

                for (int x = 0; x < quantidadeX; x++)
                    Console.Write("X");
                
                Console.WriteLine();
            }
        }
        #endregion
       
        
    }
}