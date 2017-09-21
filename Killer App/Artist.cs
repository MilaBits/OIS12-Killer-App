using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;

namespace Killer_App {
    public class Artist {

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
        public Artist(int id, string name) {
            _id = id;
            _name = name;
        }

        // METHODS
        
        public static List<Artist> ArtistsFromString(string artistString, char divider) {
            List<Artist> artists = new List<Artist>();

            foreach (string artist in artistString.Trim(divider).Split(divider)) {
                artists.Add(new Artist(0, artist));
            }
            return artists;
        }
        
        public override string ToString() {
            return _name;
        }
    }
}
