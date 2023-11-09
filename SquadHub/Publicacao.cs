using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace SquadHub
{
    public class Publicacao
    {
        public Usuario Autor { get; set; }

        public Image Imagem { get; set; }

        public string Legenda { get; set; }

        public List<Usuario> Likes { get; set; } = new List<Usuario>();

        public List<Usuario> Dislikes { get; set; } = new List<Usuario>();

        public List<Comentario> Comentarios { get; set; } = new List<Comentario>();
    }
}
