using System;
using System.Collections.Generic;
using System.Text;

namespace PostsEComentarios.Entities
{
    class Posts
    {
        //declarando variaveis e listas, estas variaveis serão preenchidas com a classe "Main"
        public DateTime Momento  { get; set; }
        public string Titulo { get; set; }
        public string Conteudo { get; set; }
        public int Curtidas { get; set; }
        public List<Comentario> Comentarios { get; set; } = new List<Comentario>();

        //Construtor padrão com nenhum paramentro
        public Posts()
        {
        }
       //Construtor com os paramentos necessarios exceto listas
        public Posts(DateTime momento, string titulo, string conteudo, int curtidas)
        {
            Momento = momento;
            Titulo = titulo;
            Conteudo = conteudo;
            Curtidas = curtidas;                     

        }
        //Metodo adicionar comentario da classe Comentario para o parametro comentario
        public void AddComentario(Comentario comentario)
        {
            Comentarios.Add(comentario);//passando o parâmetro comentario para a classe comentarios
        }

        public void RemoveComentario(Comentario comentario)
        {
            Comentarios.Remove(comentario);
        }

        //Metodo StringBuilder, ele pega as informações da classe "Posts" acima
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Titulo);
            sb.Append(Curtidas);
            sb.Append(" Curtidas - ");
            sb.AppendLine(Momento.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine(Conteudo);
            sb.AppendLine("Comentarios: ");

            foreach (Comentario c in Comentarios)
            {
                sb.AppendLine(c.Texto);
            }

            return sb.ToString();
        }
    }
}
