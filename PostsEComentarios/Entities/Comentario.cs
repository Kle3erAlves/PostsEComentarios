using System;
using System.Collections.Generic;
using System.Text;

namespace PostsEComentarios.Entities
{
    class Comentario
    {
        public string Texto { get; set; }
       
        public Comentario()
        {
        }

        public Comentario(string texto)
        {
            Texto = texto;
            
        }
    }    
}
