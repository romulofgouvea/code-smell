using System;

namespace Exemplo7
{
    public class Lancamento
    {
        public DateTime DateVencimento { get; set; }

        public Lancamento(DateTime dataVencimento)
        {
            DataVencimento = dataVencimento;
        }

        public bool PermiteLancamento()
        {
            return DataVencimento.Day >= 10 && DataVencimento.Day <= DateTime.Today.Month;
        }
    }
}