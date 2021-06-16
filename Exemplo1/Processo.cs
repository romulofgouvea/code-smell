using System;

namespace Exemplo1
{
    public class Processo
    {
        public int Id { get; set; }

        // ERRADO
        // public DateTime? DataCancelamento { get; set; }

        // CERTO
        public DateTime? DataCancelamento { get; private set; }

        public void Cancelar()
        {
            DataCancelamento = DateTime.Now;
        }
    }
}