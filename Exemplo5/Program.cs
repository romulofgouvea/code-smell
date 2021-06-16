// O uso de if/else ou switch/case muitas vezes pode ser um code smell
// Solução: utilizar polimorfismmo

using System;

namespace Exemplo5
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
            var livro = new Livro("Livro1", Livro.LivroTipo.Fisico);

            //ERRADO
            if (livro.tipo == Livro.LivroTipo.Fisico)
            {
                Console.WriteLine("Seu livro será enviado para sua casa");
            }
            else
            {
                Console.WriteLine("Seu livro será enviado para seu e-mail");
            }

            //ERRADO
            switch (livro.Tipo)
            {
                case Livro.LivroTipo.Fisico:
                    Console.WriteLine("Seu livro será enviado para sua casa");
                    break;
                case Livro.LivroTipo.Digital:
                    Console.WriteLine("Seu livro será enviado para seu e-mail");
                    break;
            }

            // Os 2 códigos acima são code smells porque estão tratando tipos 
            // de uma entidade que pode ter 2 comportamentos diferentes

            // CORRETO
            // Olha agora como o código ficou bem simplificado
            Livro livroCorreto = new LivroDigital("Livro1");
            livroCorreto.Comprar();
        }
    }
}