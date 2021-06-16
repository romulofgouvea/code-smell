using System;

namespace Exemplo2
{
    public class Processo
    {
        public int Id { get; set; }

        private int Situacao { get; set; }

        public char ModuloERP { get; set; }

        private DateTime? DataCancelamento { get; set; }

        public void Cancelar()
        {
            // ERRADO
            // O valor 0 nesse caso é considerado um número mágico
            Situacao = 0;

            // CORRETO
            Situacao = (int)Situacoes.Cancelado;

            DataCancelamento = DateTime.Now;
        }

        public void AlterarParaModulo(char modulo)
        {
            ModuloERP = modulo;
        }
    }
}