using System.Collections.Generic;

namespace bb_mvc.Models
{
    class Store
    {
        public List<Video> Videos { get; set; }

        public Store()
        {
            Videos = new List<Video>(){
                new Video("Jurassic Park", "PG", 123),
                new Video("Jurassic Park 2", "PG", 143),
                new Video("Jurassic Park 3", "PG", 113),
                new Video("Harry Potter and the Sorcerers Stone", "PG", 132)
            };

        }
    }
}