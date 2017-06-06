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
        public static List<Genre> GetAllGenres() {
            List<Genre> genres = new List<Genre>();

            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Database"].ConnectionString)) {
                conn.Open();

                string commandString = "select * from Genre";

                using (SqlCommand command = new SqlCommand(commandString, conn))
                using (SqlDataReader reader = command.ExecuteReader()) {
                    while (reader.Read()) {
                        genres.Add(new Genre(Convert.ToInt16(reader["id"]), reader["name"].ToString()));
                    }
                }
            }

            return genres;
        }
        public static List<Genre> GenresFromString(string genreString, char divider) {
            List<Genre> genres = new List<Genre>();

            foreach (string artist in genreString.Trim(divider).Split(divider)) {
                genres.Add(new Genre(0, artist));
            }
            return genres;
        }
        internal static void Insert(string genre) {
            using (SqlConnection conn =
                new SqlConnection(ConfigurationManager.ConnectionStrings["Database"].ConnectionString)) {
                conn.Open();
                string commandString = string.Format(
                    "if not exists (select 1 from Genre where name = '{0}')" +
                    "insert into Genre (name)" +
                    "values('{0}');",
                    genre.Replace("'", "''"));

                using (SqlCommand command = new SqlCommand(commandString, conn)) {
                    command.ExecuteNonQuery();
                }
            }
        }
        public override string ToString()
        {
            return _name;
        }
    }
}
