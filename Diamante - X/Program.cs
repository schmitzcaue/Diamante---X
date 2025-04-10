namespace Diamante___X
{
    internal class Program
    {
        //Desenvolver um programa em que, dado um número ímpar como entrada,
       // exibirá um diamante desenhado com a letra 'X'.

        //● O programa deve solicitar ao usuário um número inteiro.
        //● O número deve ser ímpar.Caso contrário, o programa deve informar que
        //a entrada é inválida e solicitar um novo número.
        //● O número de linhas e colunas deve ser igual ao número ímpar
        //fornecido.
        //● A linha central do diamante deve conter o número máximo de Xs.
        static void Main(string[] args)
        {
           
            ExibirCabecalho();
            int tamanhoDoDiamante = Convert.ToInt32(Console.ReadLine());

            int quantidadeDeLinhas = (tamanhoDoDiamante - 1) /2;
            int quantidadeDeEspacos = quantidadeDeLinhas;
            int quantidadeDeX = 1;

            #region parte de cima
            for (int i = 0; i < quantidadeDeLinhas; i++)
            {
                for (int espaco = 0; espaco < quantidadeDeEspacos; espaco++)
                    Console.Write(" ");

                for (int x = 0; x < quantidadeDeX; x++)
                    Console.Write("X");

                quantidadeDeX += 2;
                quantidadeDeEspacos--;

                Console.WriteLine();
            }
            #endregion

            #region parte do meio do diamante
            for (int i = 0;i < tamanhoDoDiamante;i++)
                Console.Write("X");

            Console.WriteLine();
            #endregion

            #region parte de baixo do diamante

            for (int i = 0; i < quantidadeDeLinhas; i++)
            {
                quantidadeDeX -= 2;
                quantidadeDeEspacos++;
                for (int espacos = 0; espacos < quantidadeDeEspacos; espacos++)
                    Console.Write(" ");

                for (int x = 0; x < quantidadeDeX; x++)
                    Console.Write("X");

                Console.WriteLine();
            }
            Console.ReadLine();
            #endregion


            ExibirMensagemErro(tamanhoDoDiamante);

                    Console.WriteLine("\n Pressione ENTER para continuar ...");
                    Console.ReadLine();
            
        }

        static void ExibirCabecalho()
        {
            Console.Clear();
            Console.WriteLine("----------DIAMANTE com X----------");
            Console.WriteLine(" Digite um número inteiro para desenhar o diamante: ");
            Console.WriteLine("----------------------------------");
            //Console.ReadLine();
        }

        static void ExibirMensagemErro(int numeroUsuario)
        {
             if (numeroUsuario< 3 || numeroUsuario % 2 == 0)
                {
                    Console.WriteLine("Numero inválido! Digite um número ímpar ");
                }
}
    }
}
