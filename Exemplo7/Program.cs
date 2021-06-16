// Condições compostas, ou que envolvem limites, podem ser sinais de code smells
// Pode encapsular elas em algum tipo de comportamento/metodo e facilitar isso

using System;

namespace Exemplo7
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var dataVencimento = DateTime.Today;
            var lancamento = new Lancamento(dataVencimento);

            // ERRADO
            // Pode ser que seja necessário repetir essa regra em outros lugares do código.
            // Delegar essa regra para dentro de um comportamento/metodo é um solução
            if (dataVencimento.Day >= 10 && dataVencimento.Day <= DateTime.Today.Month)
            {
                // Implementação
            }

            // CORRETO
            // Vantagem: sempre que tiver uma manutenção, esse comportamento estará sempre
            // em um único local, não está espalhado no código. Então eu consigo fazer uma
            // refatoração/manutenção muito mais rápido 
            if (lancamento.PermiteLancamento())
            {
                // Implementação
            }
        }
    }
    
}