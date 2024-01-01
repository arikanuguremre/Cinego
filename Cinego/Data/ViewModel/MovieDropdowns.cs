using Cinego.Models;

namespace Cinego.Data.ViewModel
{
    public class MovieDropdowns
    {
        public MovieDropdowns()
        {
            Directors = new List<Director> { new Director() };
            Cinemas = new List<Cinema> { new Cinema() };
            Actors = new List<Actor> { new Actor() };
        }

        public List<Director> Directors { get; set; }
        public List<Cinema> Cinemas { get; set; }
        public List<Actor> Actors { get; set; }


    }
}
