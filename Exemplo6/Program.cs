// Métodos com parâmetros lógicos: provavelmente 
// esses métodos fazem mais de uma coisa

using System;

namespace Exemplo6
{
    class Program
    {
        static void Main(string[] args)
        {
            var relatorio = new Relatorio();

            // ERRADO
            // O parâmetro True fica muito no ar. Tenho que olhar dentro da classe 
            // para entender que o parâmetro True significa incluir rodape
            // Muitas vezes parâmetros lógicos significa que você vai ter condições
            // dentro do método, e pode indicar que o método pode estar fazendo mais de uma coisa
            relatorio.GerarRelatorio(true);

            // CERTO
            // Desse jeito fica mais expressivo e o custo de implementação é muito baixo
            relatorio.GerarRelatorioComRodape();
        }
    }
}