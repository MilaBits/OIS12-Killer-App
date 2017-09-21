using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;

namespace Killer_App {
    public class Genre {

        // FIELDS
        private int _id;
        private string _name;

        // PROPERTIES
        public int Id {
            get { return _id; }
        }
        public string Name {
            get { return _name; }
        }
        // CONSTRUCTORS
        public Genre(int id, string name) {
            _id = id;
            _name = name;
        }

        // METHODS
        
        public static List<Genre> GenresFromString(string genreString, char divider) {
            List<Genre> genres = new List<Genre>();

            foreach (string artist in genreString.Trim(divider).Split(divider)) {
                genres.Add(new Genre(0, artist));
            }
            return genres;
        }
        
        public override string ToString()
        {
            return _name;
        }
    }
}
