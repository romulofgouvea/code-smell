// Condição negativa (!) é uma prática difícil de ser utilizada,
// além de ser considerada um Code Smell

namespace Exemplo4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var processo = new Processo();

            // ERRADO
            // Muitas vezes a condição negativa (!) é um detalhizinho que 
            // não fica tão claro/visivel quando está interpretando um código
            if (!processo.PossuiBloqueioAlteracao())
            {
                // Implementação
            }

            // CERTO
            if (processo.PermiteAlteracao())
            {
                // Implementação
            }
        }
    }
}