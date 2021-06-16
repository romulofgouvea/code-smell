namespace Exemplo6
{
    public class Relatorio
    {
        // ERRADO
        public void GerarRelatorio(bool incluirRodape)
        {
            // Implementação
        }

        public void GerarRelatorioComRodape()
        {
            // Implementação
        }

        // Eu poderia ter um GerarRelatorioSemRodape também,
        // e o que for comum para geração do relatório eu posso
        // abstrair em um outro método para não ter duplicidade de código,
        // e vou manter métodos que tenham nomes mais expressivos 
    }
}