using System;

namespace web_api.Models
{
    public class MangaDTO
    {
        public long Id { get; set; }

        public string Nom { get; set; }

        public string Auteur { get; set; }

        public string Editeur { get; set; }

        public string Description { get; set; }

        // public int Volume { get; set; }

        // public int Note { get; set; }

        public string Etat { get; set; }

        public string Type { get; set; }

        public string Themes { get; set; }

        public string Genre { get; set; }
        
    }
}