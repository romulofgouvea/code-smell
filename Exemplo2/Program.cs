// Valores mágicos são considerados Code Smells

using System;

namespace Exemplo2
{
    class Program
    {
        static void Main(string[] args)
        {
            var processo = new Processo();

            // ERRADO
            processo.AlterarParaModulo('C');

            // CERTO
            // Agora o código fica mais expressivo, mais legível
            processo.AlterarParaModulo(Modulos.Contabilidade);

            processo.Cancelar();
        }
    }
}