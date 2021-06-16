using System;

namespace Exemplo4
{
    public class Processo
    {
        public int Id { get; set; }

        public DateTime? DataBloqueio { get; set; }

        // ERRADO
        public bool PossuiBloqueioAlteracao()
        {
            return DataBloqueio != null;
        }
        
        // CERTO
        public bool PermiteAlteracao()
        {
            return DataBloqueio == null;
        }
    }
}