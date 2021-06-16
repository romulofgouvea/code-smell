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
            var processo = new Processo();

            // ERRADO
            // Acesso de forma direta. Comportamentos não podem ser localizados em lugaremos diversos. 
            // Comportamento deve ser movido para classe, visto que ela é responsável por mexer nos
            // seus próprios estados.
            processo.DataCancelamento = DateTime.Now;

            // CORRETO
            // Devemos utilizar o comportamento da própria classe, visto que esse comportamento
            // vai manipular apenas estados/propriedades da própria classe. 
            processo.Cancelar();
        }
    }
}