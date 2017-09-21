using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;

namespace Killer_App {
    public class Tag {

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
        public Tag(int id, string name) {
            _id = id;
            _name = name;
        }

        // METHODS
        
        public static List<Tag> TagsFromString(string tagString, char divider) {
            List<Tag> tags = new List<Tag>();

            foreach (string tag in tagString.Trim(divider).Split(divider)) {
                tags.Add(new Tag(0, tag));
            }
            return tags;
        }
        
        public override string ToString() {
            return _name;
        }
    }
}
