// Códigos duplicados são considerados code smells
// DRY - Don't Repeat Yourself (Não repita a si mesmo)
// Solução: unificar o código duplicado em uma única função

using System;

namespace Exemplo1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // ERRADO
            var processoModoErrado = new Processo
            {
                DataCancelamento = DateTime.Now
            };

            processoModoErrado.DataCancelamento = DateTime.Today;

            // CORRETO
            var processoModoCorreto = new Processo();
            processoModoCorreto.AlteraDataCancelamento();
        }
    }
}