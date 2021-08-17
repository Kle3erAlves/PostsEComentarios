using System;
using PostsEComentarios.Entities;

namespace PostsEComentarios
{
    class Program
    {
        static void Main(string[] args) // A Classe "Main" geralmente é utilizada para alimentar as classes e gerar a resposta na tela

        {   //Descreveu os comentarios
            Comentario c1 = new Comentario("Tenha uma boa viagem!");//comentario c1
            Comentario c2 = new Comentario("Uau, isso é incrivel!");//comentario c2


            //Descreveu o layout do Post 1
            Posts p1 = new Posts( // Post p1
                DateTime.Parse("21/06/2018 13:05:44"),//Date Time
                "Viajar para Nova Zelandia",//Titulo
                "Vou visitar este país maravilhoso",12);//Conteudo e curtidas
            //Adicionou os comentarios embaixo do post 1
            p1.AddComentario(c1); //Adiciona o comentario c1 no Post 1
            p1.AddComentario(c2); //Adiciona o comentario c2 no Post 1

            //Descreveu os comentarios
            Comentario c3 = new Comentario("Boa noite!"); //comentario c3
            Comentario c4 = new Comentario("Que a força esteja com você."); //comentario c4

            //Descreveu o layout do Post 2
            Posts p2 = new Posts( //Post p2
                DateTime.Parse("28/07/2018 23:14:19"), //date Time
                "Boa noite galera",//Titulo
                "Vejo vocês amanhã", 5);//Conteudo e curtidas
            //Adicionou os comentarios embaixo do post 2
            p2.AddComentario(c3);//Adiciona o comentario c3 no Post 2
            p2.AddComentario(c4);//Adiciona o comentario c4 no Post 2

            Console.WriteLine(p1); //Escreve na tela o post 1 
            Console.WriteLine(p2); //Escreve na tela o post 2




        }
    }
}
