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
        public static List<Tag> GetAllTags() {
            List<Tag> tags = new List<Tag>();

            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Database"].ConnectionString)) {
                conn.Open();

                string commandString = "select * from Tag";

                using (SqlCommand command = new SqlCommand(commandString, conn))
                using (SqlDataReader reader = command.ExecuteReader()) {
                    while (reader.Read()) {
                        tags.Add(new Tag(Convert.ToInt16(reader["id"]), reader["name"].ToString()));
                    }
                }
            }

            return tags;
        }
        public static List<Tag> TagsFromString(string tagString, char divider) {
            List<Tag> tags = new List<Tag>();

            foreach (string tag in tagString.Trim(divider).Split(divider)) {
                tags.Add(new Tag(0, tag));
            }
            return tags;
        }
        internal static void Insert(string tag) {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Database"].ConnectionString)) {
                conn.Open();

                string commandString = string.Format(
                    "if not exists (select 1 from Tag where name = '{0}')" +
                    "insert into Tag (name)" +
                    "values('{0}');",
                    tag.Replace("'", "''"));

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
