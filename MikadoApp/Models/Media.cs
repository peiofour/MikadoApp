using System;
namespace MikadoApp.Models
{
    public class Media
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public MediaType Type { get; set; }

    }

    public enum MediaType
    {
        Music, Movie, Book
    }
}
