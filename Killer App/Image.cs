using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;

namespace Killer_App {
    public class Image : MediaFile {

        // FIELDS
        private int _height;
        private int _width;
        private List<Tag> _tags;

        // PROPERTIES
        public int Height {
            get { return _height; }
            set { _height = value; }
        }
        public int Width {
            get { return _width; }
            set { _width = value; }
        }
        public List<Tag> Tags {
            get { return _tags; }
        }
        public string AspectRatio {
            get {
                int gdc = GCD(_width, _height);
                return string.Format("{0}:{1}", _width / gdc, _height / gdc);
            }
        }

        // CONSTRUCTORS
        public Image() {
            _height = 0;
            _width = 0;
            _tags = new List<Tag>();
        }
        public Image(int id, string title, string path, int height, int width, List<Tag> tags) : base(id, title, path) {
            _height = height;
            _width = width;
            _tags = tags;
        }
        //public Image(int id, string title, string path, int height, int width, string[] tags) : base(id, title, path) {
        //    _height = height;
        //    _width = width;
        //    foreach (string tag in tags) {
        //        _tags.Add(new Tag(0, tag));
        //    }
        //}

        // METHODS
        private static int GCD(int a, int b) {
            while (a != 0 && b != 0) {
                if (a > b) a %= b;
                else b %= a;
            }
            return a == 0 ? b : a;
        }
        public static string CalculateAspectRatio(int width, int height) {
            int gdc = GCD(width, height);
            return string.Format("{0}:{1}", width / gdc, height / gdc);
        }
        public string TagsAsString() {
            string TagsString = string.Empty;
            foreach (Tag Tag in _tags) {
                TagsString += "," + Tag.Name;
            }
            return TagsString.TrimStart(',');
        }
        internal static void Insert(Image image) {

            // Make sure the related genres, artists and tags exist
            foreach (Tag imageTag in image.Tags) {
                Tag.Insert(imageTag.Name);
            }

            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Database"].ConnectionString)) {
                conn.Open();

                if (Image.isStored(image, conn)) {
                    return;
                }

                //Insert image
                string commandString = string.Format(
                    "insert into Image (title, path, height, width)" +
                    "values('{0}', '{1}', {2}, '{3}');",
                    image.Title.Replace("'", "''"),
                    image.Path.Replace("'", "''"),
                    image.Height,
                    image.Width);
                using (SqlCommand command = new SqlCommand(commandString, conn)) {
                    command.ExecuteNonQuery();
                }

                //Insert image's Tags
                string tagsCommand = string.Empty;
                foreach (Tag imageTag in image.Tags.Distinct()) {
                    tagsCommand += string.Format(
                        "insert into Tag_Image (image_id, tag_id)" +
                        "values((select id from Image where path = '{0}')," +
                        "(select id from Tag where name = '{1}')); ",
                        image.Path.Replace("'", "''"),
                        imageTag.Name.Replace("'", "''"));
                }
                using (SqlCommand command = new SqlCommand(tagsCommand, conn)) {
                    if (!string.IsNullOrWhiteSpace(tagsCommand)) {
                        command.ExecuteNonQuery();
                    }
                }
            }
        }
        internal static void Insert(List<Image> images) {
            foreach (Image image in images) {
                // Make sure the related genres, artists and tags exist
                foreach (Tag imageTag in image.Tags) {
                    Tag.Insert(imageTag.Name);
                }

                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Database"].ConnectionString)) {
                    conn.Open();

                    if (Image.isStored(image, conn)) {
                        return;
                    }

                    //Insert image
                    string commandString = string.Format(
                        "insert into Image (title, path, height, width)" +
                        "values('{0}', '{1}', {2}, {3});",
                        image.Title.Replace("'", "''"),
                        image.Path.Replace("'", "''"),
                        image.Height,
                        image.Width);
                    using (SqlCommand command = new SqlCommand(commandString, conn)) {
                        command.ExecuteNonQuery();
                    }

                    //Insert image's Tags
                    string tagsCommand = string.Empty;
                    foreach (Tag imageTag in image.Tags.Distinct()) {
                        tagsCommand += string.Format(
                            "insert into Tag_Image (image_id, tag_id)" +
                            "values((select id from Image where path = '{0}')," +
                            "(select id from Tag where name = '{1}')); ",
                            image.Path.Replace("'", "''"),
                            imageTag.Name.Replace("'", "''"));
                    }
                    using (SqlCommand command = new SqlCommand(tagsCommand, conn)) {
                        command.ExecuteNonQuery();
                    }
                }
            }
        }
        internal static void Update(Image image) {
            // Make sure the related genres, artists and tags exist
            foreach (Tag imageTag in image.Tags) {
                Tag.Insert(imageTag.Name);
            }

            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Database"].ConnectionString)) {
                conn.Open();

                if (Image.isStored(image, conn)) {
                    return;
                }

                //Insert image
                string commandString = string.Format(
                    "update Image set title = '{0}', path = '{1}', height = {2}, width = {3} where path = '{1}'",
                    image.Title.Replace("'", "''"),
                    image.Path.Replace("'", "''"),
                    image.Height,
                    image.Width);
                using (SqlCommand command = new SqlCommand(commandString, conn)) {
                    command.ExecuteNonQuery();
                }

                //Insert image's Tags
                string tagsCommand = string.Empty;
                foreach (Tag imageTag in image.Tags.Distinct()) {
                    tagsCommand += string.Format(
                        "insert into Tag_Image (image_id, tag_id)" +
                        "values((select id from Image where path = '{0}')," +
                        "(select id from Tag where name = '{1}')); ",
                        image.Path.Replace("'", "''"),
                        imageTag.Name.Replace("'", "''"));
                }
                using (SqlCommand command = new SqlCommand(tagsCommand, conn)) {
                    command.ExecuteNonQuery();
                }

            }
        }
        public static bool isStored(Image image, SqlConnection conn) {
            bool exists;
            string imageCheck = string.Format("select Image.path from Image where path = '{0}'", image.Path.Replace("'", "''"));
            using (SqlCommand command = new SqlCommand(imageCheck, conn)) {
                command.ExecuteNonQuery();
                using (SqlDataReader reader = command.ExecuteReader()) {
                    exists = false;
                    while (reader.Read()) {
                        exists = !string.IsNullOrWhiteSpace(reader["path"].ToString());
                    }
                    if (exists) {
                        return exists;
                    }
                }
            }
            return exists;
        }
        public static List<Tag> GetTags(int id) {
            List<Tag> Tags = new List<Tag>();

            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Database"].ConnectionString)) {
                conn.Open();

                string commandString = string.Format("select * from Tag where tag.id in (select Tag_Image.Tag_id from Tag_Image where Tag_Image.Image_id = {0})", id);

                using (SqlCommand command = new SqlCommand(commandString, conn))
                using (SqlDataReader reader = command.ExecuteReader()) {
                    while (reader.Read()) {
                        Tags.Add(new Tag(Convert.ToInt16(reader["id"]), reader["name"].ToString()));
                    }
                }
            }
            return Tags;
        }
        public static void DeleteFromDB(Image image) {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Database"].ConnectionString)) {
                conn.Open();

                string commandString = string.Format("DECLARE @id int;" +
                                                     "SET @id = (select id from Image where Image.path = '{0}' and Image.title = '{1}');" +
                                                     "delete Tag_Image where Tag_Image.image_id = @id;" +
                                                     "delete Image where Image.id = @id", image.Path.Replace("'", "''"), image.Title.Replace("'", "''"));

                using (SqlCommand command = new SqlCommand(commandString, conn)) {
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
