namespace Matrix
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                // Limpar a tela
                Console.Clear();

                // Setar a cor do texto
                Console.ForegroundColor = ConsoleColor.Green;

                // Gerador de números aleatórios
                Random random = new Random();

                // Fazer as linhas (i = deslocamento "x")
                // É incrementado por 2 para haver espaço entre as linhas
                for (int i = 0; i < Console.WindowWidth; i+=2)
                {
                    // Gerar a altura da linha (entre 0 e a altura da janela)
                    int random_height = random.Next(0, Console.WindowHeight);

                    /// Para randomizar as cores do texto a cada linha:
                    //ConsoleColor random_color = (ConsoleColor)random.Next(0, 16);
                    //Console.ForegroundColor = random_color;
                    
                    /// Para randomizar as cores do fundo a cada linha:
                    //ConsoleColor bg_random_color = (ConsoleColor)random.Next(0, 16);
                    //Console.BackgroundColor = bg_random_color;

                    // Fazer os caracteres da linha (j = deslocamento "y")
                    for (int j = 0; j < random_height; ++j)
                    {
                        /// Gerar o aleatóriamente o número 0 ou 1
                        //int random_char = random.Next(0, 2);

                        // Gerar um caractere aleatório
                        // É baseado na tabela ASCII
                        // É utilizado do caractere de código 33 até o caractere de código 126
                        char random_char = (char) random.Next(33, 127);

                        // i = deslocamento "x"
                        // j = deslocamento "y"
                        Console.SetCursorPosition(i, j);

                        // Escrever o caractere naquele espaço
                        Console.Write(random_char);

                        // Esperar 10 milisegundos para cada caractere
                        System.Threading.Thread.Sleep(10);
                    }
                }

                // Animaçãozinha de limpar a tela
                // Vai da direita para a esquerda, baixo para cima, setando os caracteres como um espaço vazio
                for (int i = Console.WindowWidth-1; i >= 0; --i)
                {
                    for (int j = Console.WindowHeight-1; j >= 0 ; --j)
                    {
                        Console.SetCursorPosition(i, j);
                        Console.Write(' ');
                    }
                }
            }
        }
    }
}
