namespace Exemplo5
{
    // ERRADO
    // public class Livro
    // {
    //     public string Titulo { get; set; }

    //     public LivroTipo Tipo { get; set; }

    //     public Livro(string titulo, LivroTipo tipo)
    //     {
    //         Titulo = titulo;
    //         Tipo = tipo;
    //     }

    //     public enum LivroTipo
    //     {
    //         Fisico = 1,
    //         Digital = 2
    //     }
    // }

    // CORRETO
    public abstract class Livro
    {
        public string Titulo { get; set; }

        public Livro(string titulo)
        {
            Titulo = titulo;
        }

        public abstract void Comprar();
    }
}