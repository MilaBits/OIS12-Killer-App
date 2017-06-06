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
        public static List<Artist> GetAllArtists() {
            List<Artist> artists = new List<Artist>();

            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Database"].ConnectionString)) {
                conn.Open();

                string commandString = "select * from Artist";

                using (SqlCommand command = new SqlCommand(commandString, conn))
                using (SqlDataReader reader = command.ExecuteReader()) {
                    while (reader.Read()) {
                        artists.Add(new Artist(Convert.ToInt16(reader["id"]), reader["name"].ToString()));
                    }
                }
            }

            return artists;
        }
        public static List<Artist> ArtistsFromString(string artistString, char divider) {
            List<Artist> artists = new List<Artist>();

            foreach (string artist in artistString.Trim(divider).Split(divider)) {
                artists.Add(new Artist(0, artist));
            }
            return artists;
        }
        internal static void Insert(string artist) {
            using (SqlConnection conn =
                new SqlConnection(ConfigurationManager.ConnectionStrings["Database"].ConnectionString)) {
                conn.Open();

                string commandString = string.Format(
                    "if not exists (select 1 from Artist where name = '{0}')" +
                    "insert into Artist (name)" +
                    "values('{0}');",
                    artist.Replace("'", "''"));

                using (SqlCommand command = new SqlCommand(commandString, conn)) {
                    command.ExecuteNonQuery();
                }
            }
        }
        public override string ToString() {
            return _name;
        }
    }
}
