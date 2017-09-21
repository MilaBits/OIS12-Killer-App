using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace Killer_App {
    class Database {
        public static void InsertMediaFile(MediaFile mediaFile) {
            if (mediaFile is Song) {
                // Make sure the related genres, artists and tags exist
                foreach (Genre songGenre in ((Song)mediaFile).Genres) {
                    InsertGenre(songGenre.Name);
                }
                foreach (Artist songArtist in ((Song)mediaFile).Artists) {
                    InsertArtist(songArtist.Name);
                }
                foreach (Tag songTag in ((Song)mediaFile).Tags) {
                    InsertTag(songTag.Name);
                }

                using (SqlConnection conn =
                    new SqlConnection(ConfigurationManager.ConnectionStrings["Database"].ConnectionString)) {
                    conn.Open();

                    //InsertGenre song
                    string commandString = String.Format(
                        "insert into Song (title, path, length, album, year)" +
                        "values('{0}', '{1}', {2}, '{3}', {4});",
                        ((Song)mediaFile).Title.Replace("'", "''"),
                        ((Song)mediaFile).Path.Replace("'", "''"),
                        ((Song)mediaFile).Length,
                        ((Song)mediaFile).Album.Replace("'", "''"),
                        ((Song)mediaFile).Year);
                    using (SqlCommand command = new SqlCommand(commandString, conn)) {
                        if (!String.IsNullOrWhiteSpace(commandString))
                            try {
                                command.ExecuteNonQuery();
                            } catch (SqlException e) {
                                if (e.Message.Contains("29425")) {
                                    MessageBox.Show(e.Message, "Error!");
                                }
                            }
                    }

                    //InsertGenre song's Genres
                    string genresCommand = String.Empty;
                    foreach (Genre songGenre in ((Song)mediaFile).Genres.Distinct()) {
                        genresCommand += String.Format(
                            "insert into Genre_Song (song_id, genre_id)" +
                            "values((select id from Song where title = '{0}')," +
                            "(select id from Genre where name = '{1}')); ",
                            ((Song)mediaFile).Title.Replace("'", "''"),
                            songGenre.Name.Replace("'", "''"));

                        using (SqlCommand command = new SqlCommand(genresCommand, conn)) {
                            if (!String.IsNullOrWhiteSpace(genresCommand))
                                command.ExecuteNonQuery();
                        }
                    }

                    //InsertGenre song's Artists
                    string artistsCommand = String.Empty;
                    foreach (Artist songArtist in ((Song)mediaFile).Artists.Distinct()) {
                        artistsCommand += String.Format(
                            "insert into Artist_Song (song_id, artist_id)" +
                            "values((select id from Song where title = '{0}')," +
                            "(select id from Artist where name = '{1}')); ",
                            ((Song)mediaFile).Title.Replace("'", "''"),
                            songArtist.Name.Replace("'", "''"));
                    }
                    using (SqlCommand command = new SqlCommand(artistsCommand, conn)) {
                        if (!String.IsNullOrWhiteSpace(artistsCommand))
                            command.ExecuteNonQuery();
                    }

                    //InsertGenre song's Tags
                    string tagsCommand = String.Empty;
                    foreach (Tag songTag in ((Song)mediaFile).Tags.Distinct()) {
                        tagsCommand += String.Format(
                            "insert into Tag_Song (song_id, tag_id)" +
                            "values((select id from Song where title = '{0}')," +
                            "(select id from Tag where name = '{1}')); ",
                            ((Song)mediaFile).Title.Replace("'", "''"),
                            songTag.Name.Replace("'", "''"));
                    }
                    using (SqlCommand command = new SqlCommand(tagsCommand, conn)) {
                        if (!String.IsNullOrWhiteSpace(tagsCommand))
                            command.ExecuteNonQuery();
                    }
                }
            } else {
                // Make sure the related genres, artists and tags exist
                foreach (Tag imageTag in ((Image)mediaFile).Tags) {
                    InsertTag(imageTag.Name);
                }

                using (SqlConnection conn =
                    new SqlConnection(ConfigurationManager.ConnectionStrings["Database"].ConnectionString)) {
                    conn.Open();

                    //InsertGenre image
                    string commandString = String.Format(
                        "insert into Image (title, path, height, width)" +
                        "values('{0}', '{1}', {2}, '{3}');",
                        ((Image)mediaFile).Title.Replace("'", "''"),
                        ((Image)mediaFile).Path.Replace("'", "''"),
                        ((Image)mediaFile).Height,
                        ((Image)mediaFile).Width);
                    using (SqlCommand command = new SqlCommand(commandString, conn)) {
                        command.ExecuteNonQuery();
                    }

                    //InsertGenre image's Tags
                    string tagsCommand = String.Empty;
                    foreach (Tag imageTag in ((Image)mediaFile).Tags.Distinct()) {
                        tagsCommand += String.Format(
                            "insert into Tag_Image (image_id, tag_id)" +
                            "values((select id from Image where path = '{0}')," +
                            "(select id from Tag where name = '{1}')); ",
                            ((Image)mediaFile).Path.Replace("'", "''"),
                            imageTag.Name.Replace("'", "''"));
                    }
                    using (SqlCommand command = new SqlCommand(tagsCommand, conn)) {
                        if (!String.IsNullOrWhiteSpace(tagsCommand)) {
                            command.ExecuteNonQuery();
                        }
                    }
                }
            }
        }
        public static void InsertMediaFiles(List<MediaFile> mediaFiles) {
            foreach (var mediaFile in mediaFiles) {
                if (mediaFile is Song) {
                    // Make sure the related genres, artists and tags exist
                    foreach (Genre songGenre in ((Song)mediaFile).Genres) {
                        InsertGenre(songGenre.Name);
                    }
                    foreach (Artist songArtist in ((Song)mediaFile).Artists) {
                        InsertArtist(songArtist.Name);
                    }
                    foreach (Tag songTag in ((Song)mediaFile).Tags) {
                        InsertTag(songTag.Name);
                    }

                    using (SqlConnection conn =
                        new SqlConnection(ConfigurationManager.ConnectionStrings["Database"].ConnectionString)) {
                        conn.Open();

                        //InsertGenre song
                        string commandString = String.Format(
                            "insert into Song (title, path, length, album, year)" +
                            "values('{0}', '{1}', {2}, '{3}', {4});",
                            ((Song)mediaFile).Title.Replace("'", "''"),
                            ((Song)mediaFile).Path.Replace("'", "''"),
                            ((Song)mediaFile).Length,
                            ((Song)mediaFile).Album.Replace("'", "''"),
                            ((Song)mediaFile).Year);
                        using (SqlCommand command = new SqlCommand(commandString, conn)) {
                            if (!String.IsNullOrWhiteSpace(commandString))
                                command.ExecuteNonQuery();
                        }

                        //InsertGenre song's Genres
                        string genresCommand = String.Empty;
                        foreach (Genre songGenre in ((Song)mediaFile).Genres.Distinct()) {
                            genresCommand += String.Format(
                                "insert into Genre_Song (song_id, genre_id)" +
                                "values((select id from Song where title = '{0}')," +
                                "(select id from Genre where name = '{1}')); ",
                                ((Song)mediaFile).Title.Replace("'", "''"),
                                songGenre.Name.Replace("'", "''"));

                            using (SqlCommand command = new SqlCommand(genresCommand, conn)) {
                                if (!String.IsNullOrWhiteSpace(genresCommand))
                                    command.ExecuteNonQuery();
                            }
                        }

                        //InsertGenre song's Artists
                        string artistsCommand = String.Empty;
                        foreach (Artist songArtist in ((Song)mediaFile).Artists.Distinct()) {
                            artistsCommand += String.Format(
                                "insert into Artist_Song (song_id, artist_id)" +
                                "values((select id from Song where title = '{0}')," +
                                "(select id from Artist where name = '{1}')); ",
                                ((Song)mediaFile).Title.Replace("'", "''"),
                                songArtist.Name.Replace("'", "''"));
                        }
                        using (SqlCommand command = new SqlCommand(artistsCommand, conn)) {
                            if (!String.IsNullOrWhiteSpace(artistsCommand))
                                command.ExecuteNonQuery();
                        }

                        //InsertGenre song's Tags
                        string tagsCommand = String.Empty;
                        foreach (Tag songTag in ((Song)mediaFile).Tags.Distinct()) {
                            tagsCommand += String.Format(
                                "insert into Tag_Song (song_id, tag_id)" +
                                "values((select id from Song where title = '{0}')," +
                                "(select id from Tag where name = '{1}')); ",
                                ((Song)mediaFile).Title.Replace("'", "''"),
                                songTag.Name.Replace("'", "''"));
                        }
                        using (SqlCommand command = new SqlCommand(tagsCommand, conn)) {
                            if (!String.IsNullOrWhiteSpace(tagsCommand))
                                command.ExecuteNonQuery();
                        }
                    }
                } else {
                    // Make sure the related genres, artists and tags exist
                    foreach (Tag imageTag in ((Image)mediaFile).Tags) {
                        InsertTag(imageTag.Name);
                    }

                    using (SqlConnection conn =
                        new SqlConnection(ConfigurationManager.ConnectionStrings["Database"].ConnectionString)) {
                        conn.Open();

                        //InsertGenre image
                        string commandString = String.Format(
                            "insert into Image (title, path, height, width)" +
                            "values('{0}', '{1}', {2}, '{3}');",
                            ((Image)mediaFile).Title.Replace("'", "''"),
                            ((Image)mediaFile).Path.Replace("'", "''"),
                            ((Image)mediaFile).Height,
                            ((Image)mediaFile).Width);
                        using (SqlCommand command = new SqlCommand(commandString, conn)) {
                            command.ExecuteNonQuery();
                        }

                        //InsertGenre image's Tags
                        string tagsCommand = String.Empty;
                        foreach (Tag imageTag in ((Image)mediaFile).Tags.Distinct()) {
                            tagsCommand += String.Format(
                                "insert into Tag_Image (image_id, tag_id)" +
                                "values((select id from Image where path = '{0}')," +
                                "(select id from Tag where name = '{1}')); ",
                                ((Image)mediaFile).Path.Replace("'", "''"),
                                imageTag.Name.Replace("'", "''"));
                        }
                        using (SqlCommand command = new SqlCommand(tagsCommand, conn)) {
                            if (!String.IsNullOrWhiteSpace(tagsCommand)) {
                                command.ExecuteNonQuery();
                            }
                        }
                    }
                }
            }
        }
        public static void UpdateMediaFile(MediaFile mediaFile) {
            if (mediaFile is Song) {
                // Make sure the related genres, artists and tags exist
                foreach (Genre songGenre in ((Song)mediaFile).Genres) {
                    InsertGenre(songGenre.Name);
                }
                foreach (Artist songArtist in ((Song)mediaFile).Artists) {
                    InsertArtist(songArtist.Name);
                }
                foreach (Tag songTag in ((Song)mediaFile).Tags) {
                    InsertTag(songTag.Name);
                }

                using (SqlConnection conn =
                    new SqlConnection(ConfigurationManager.ConnectionStrings["Database"].ConnectionString)) {
                    conn.Open();

                    //InsertGenre song
                    string commandString = String.Format(
                        "update Song set title = '{0}', path = '{1}', length = {2}, album = '{4}', year {5} where path = '{1}'",
                        ((Song)mediaFile).Title.Replace("'", "''"),
                        ((Song)mediaFile).Path.Replace("'", "''"),
                        ((Song)mediaFile).Length,
                        ((Song)mediaFile).Album.Replace("'", "''"),
                        ((Song)mediaFile).Year);
                    using (SqlCommand command = new SqlCommand(commandString, conn)) {
                        if (!String.IsNullOrWhiteSpace(commandString))
                            command.ExecuteNonQuery();
                    }

                    //InsertGenre song's Genres
                    string genresCommand = String.Empty;
                    foreach (Genre songGenre in ((Song)mediaFile).Genres.Distinct()) {
                        genresCommand += String.Format(
                            "insert into Genre_Song (song_id, genre_id)" +
                            "values((select id from Song where title = '{0}')," +
                            "(select id from Genre where name = '{1}')); ",
                            ((Song)mediaFile).Title.Replace("'", "''"),
                            songGenre.Name.Replace("'", "''"));

                        using (SqlCommand command = new SqlCommand(genresCommand, conn)) {
                            if (!String.IsNullOrWhiteSpace(genresCommand))
                                command.ExecuteNonQuery();
                        }
                    }

                    //InsertGenre song's Artists
                    string artistsCommand = String.Empty;
                    foreach (Artist songArtist in ((Song)mediaFile).Artists.Distinct()) {
                        artistsCommand += String.Format(
                            "insert into Artist_Song (song_id, artist_id)" +
                            "values((select id from Song where title = '{0}')," +
                            "(select id from Artist where name = '{1}')); ",
                            ((Song)mediaFile).Title.Replace("'", "''"),
                            songArtist.Name.Replace("'", "''"));
                    }
                    using (SqlCommand command = new SqlCommand(artistsCommand, conn)) {
                        if (!String.IsNullOrWhiteSpace(artistsCommand))
                            command.ExecuteNonQuery();
                    }

                    //InsertGenre song's Tags
                    string tagsCommand = String.Empty;
                    foreach (Tag songTag in ((Song)mediaFile).Tags.Distinct()) {
                        tagsCommand += String.Format(
                            "insert into Tag_Song (song_id, tag_id)" +
                            "values((select id from Song where title = '{0}')," +
                            "(select id from Tag where name = '{1}')); ",
                            ((Song)mediaFile).Title.Replace("'", "''"),
                            songTag.Name.Replace("'", "''"));
                    }
                    using (SqlCommand command = new SqlCommand(tagsCommand, conn)) {
                        if (!String.IsNullOrWhiteSpace(tagsCommand))
                            command.ExecuteNonQuery();
                    }
                }
            } else {
                // Make sure the related genres, artists and tags exist
                foreach (Tag imageTag in ((Image)mediaFile).Tags) {
                    InsertTag(imageTag.Name);
                }

                using (SqlConnection conn =
                    new SqlConnection(ConfigurationManager.ConnectionStrings["Database"].ConnectionString)) {
                    conn.Open();

                    //InsertGenre image
                    string commandString = String.Format(
                        "update Image set title = '{0}', path = '{1}', height = {2}, width = {3} where path = '{1}'",
                        ((Image)mediaFile).Title.Replace("'", "''"),
                        ((Image)mediaFile).Path.Replace("'", "''"),
                        ((Image)mediaFile).Height,
                        ((Image)mediaFile).Width);
                    using (SqlCommand command = new SqlCommand(commandString, conn)) {
                        command.ExecuteNonQuery();
                    }

                    //InsertGenre image's Tags
                    string tagsCommand = String.Empty;
                    foreach (Tag imageTag in ((Image)mediaFile).Tags.Distinct()) {
                        tagsCommand += String.Format(
                            "insert into Tag_Image (image_id, tag_id)" +
                            "values((select id from Image where path = '{0}')," +
                            "(select id from Tag where name = '{1}')); ",
                            ((Image)mediaFile).Path.Replace("'", "''"),
                            imageTag.Name.Replace("'", "''"));
                    }
                    using (SqlCommand command = new SqlCommand(tagsCommand, conn)) {
                        command.ExecuteNonQuery();
                    }
                }
            }
        }
        public static void DeleteMediaFile(MediaFile mediaFile) {
            if (mediaFile is Song) {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Database"].ConnectionString)) {
                    conn.Open();

                    string commandString = String.Format("delete Song where Song.id = (select id from Song where Song.path = '{0}' and Song.title = '{1}');", mediaFile.Path.Replace("'", "''"), mediaFile.Title.Replace("'", "''"));

                    using (SqlCommand command = new SqlCommand(commandString, conn)) {
                        command.ExecuteNonQuery();
                    }
                }
            } else {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Database"].ConnectionString)) {
                    conn.Open();

                    string commandString = String.Format("DECLARE @id int;" +
                                                         "SET @id = (select id from Image where Image.path = '{0}' and Image.title = '{1}');" +
                                                         "delete Tag_Image where Tag_Image.image_id = @id;" +
                                                         "delete Image where Image.id = @id", mediaFile.Path.Replace("'", "''"), mediaFile.Title.Replace("'", "''"));

                    using (SqlCommand command = new SqlCommand(commandString, conn)) {
                        command.ExecuteNonQuery();
                    }
                }
            }
        }
        public static List<Song> GetSongs() {
            List<Song> newList = new List<Song>();
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Database"].ConnectionString)) {
                conn.Open();

                int lastId = 0;
                Song newSong = new Song();
                using (SqlCommand command = new SqlCommand("select distinct Song.* , Artist.id as artistId, Artist.name as artist, Genre.id as genreId, Genre.name as genre " +
                                                           "from Song, Artist ,Genre, Genre_Song g_s, Artist_Song a_s " +
                                                           "where (Song.id = a_s.song_id and Artist.id = a_s.artist_id) " +
                                                           "and (Song.id = g_s.song_id and Genre.id = g_s.genre_id);", conn))
                using (SqlDataReader reader = command.ExecuteReader()) {
                    while (reader.Read()) {
                        if (Convert.ToInt16(reader["id"]) != lastId) {
                            newList.Add(newSong);

                            newSong = new Song(
                                Convert.ToInt16(reader["id"].ToString()),
                                reader["title"].ToString(),
                                reader["path"].ToString(),
                                Convert.ToInt16(reader["length"].ToString()),
                                reader["album"].ToString(),
                                Convert.ToInt16(reader["year"].ToString()),
                                new List<Artist>(),
                                new List<Genre>(),
                                new List<Tag>());
                        }
                        newSong.Artists.Add(new Artist(Convert.ToInt16(reader["artistId"]), reader["artist"].ToString()));
                        newSong.Genres.Add(new Genre(Convert.ToInt16(reader["genreId"]), reader["genre"].ToString()));

                        lastId = newSong.Id;
                    }
                }
            }
            if (newList.Count > 0) {
                newList.RemoveAt(0);
            }
            return newList;
        }
        public static List<Artist> GetArtists(int id) {
            List<Artist> artists = new List<Artist>();

            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Database"].ConnectionString)) {
                conn.Open();

                string commandString = String.Format("select * from Artist where Artist.id in (select Artist_Song.artist_id from Artist_Song where Artist_Song.song_id = {0})", id);

                using (SqlCommand command = new SqlCommand(commandString, conn))
                using (SqlDataReader reader = command.ExecuteReader()) {
                    while (reader.Read()) {
                        artists.Add(new Artist(Convert.ToInt16(reader["id"]), reader["name"].ToString()));
                    }
                }
            }

            return artists;
        }
        public static List<Genre> GetGenres() {
            List<Genre> Genres = new List<Genre>();

            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Database"].ConnectionString)) {
                conn.Open();

                string commandString = "select * from Genre";

                using (SqlCommand command = new SqlCommand(commandString, conn))
                using (SqlDataReader reader = command.ExecuteReader()) {
                    while (reader.Read()) {
                        Genres.Add(new Genre(Convert.ToInt16(reader["id"]), reader["name"].ToString()));
                    }
                }
            }

            return Genres;
        }
        public static List<Genre> GetGenres(int id) {
            List<Genre> Genres = new List<Genre>();

            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Database"].ConnectionString)) {
                conn.Open();

                string commandString = String.Format("select * from Genre where genre.id in (select Genre_Song.Genre_id from Genre_Song where Genre_Song.song_id = {0})", id);

                using (SqlCommand command = new SqlCommand(commandString, conn))
                using (SqlDataReader reader = command.ExecuteReader()) {
                    while (reader.Read()) {
                        Genres.Add(new Genre(Convert.ToInt16(reader["id"]), reader["name"].ToString()));
                    }
                }
            }

            return Genres;
        }
        public static List<Tag> GetTags() {
            List<Tag> Tags = new List<Tag>();

            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Database"].ConnectionString)) {
                conn.Open();

                string commandString = "select * from Tags";

                using (SqlCommand command = new SqlCommand(commandString, conn))
                using (SqlDataReader reader = command.ExecuteReader()) {
                    while (reader.Read()) {
                        Tags.Add(new Tag(Convert.ToInt16(reader["id"]), reader["name"].ToString()));
                    }
                }
            }

            return Tags;
        }
        public static List<Tag> GetTags(int id, MediaType type) {
            List<Tag> Tags = new List<Tag>();
            switch (type) {
                case MediaType.Song:
                    using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Database"].ConnectionString)) {
                        conn.Open();

                        string commandString = String.Format("select * from Tag where tag.id in (select Tag_Song.Tag_id from Tag_Song where Tag_Song.song_id = {0})", id);

                        using (SqlCommand command = new SqlCommand(commandString, conn))
                        using (SqlDataReader reader = command.ExecuteReader()) {
                            while (reader.Read()) {
                                Tags.Add(new Tag(Convert.ToInt16(reader["id"]), reader["name"].ToString()));
                            }
                        }
                    }
                    break;
                case MediaType.Image:
                    using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Database"].ConnectionString)) {
                        conn.Open();

                        string commandString = String.Format("select * from Tag where tag.id in (select Tag_Image.Tag_id from Tag_Image where Tag_Image.image_id = {0})", id);

                        using (SqlCommand command = new SqlCommand(commandString, conn))
                        using (SqlDataReader reader = command.ExecuteReader()) {
                            while (reader.Read()) {
                                Tags.Add(new Tag(Convert.ToInt16(reader["id"]), reader["name"].ToString()));
                            }
                        }
                    }
                    break;
            }
            return Tags;
        }
        public static List<MediaFile> Search(MediaType searchFilter) {
            List<MediaFile> newList = new List<MediaFile>();
            switch (searchFilter) {
                case MediaType.Song:
                    using (SqlConnection conn =
                        new SqlConnection(ConfigurationManager.ConnectionStrings["Database"].ConnectionString)) {
                        conn.Open();

                        using (SqlCommand command = new SqlCommand("select * from Song", conn))
                        using (SqlDataReader reader = command.ExecuteReader()) {
                            while (reader.Read()) {
                                newList.Add(new Song(
                                    Convert.ToInt16(reader["id"].ToString()),
                                    reader["title"].ToString(),
                                    reader["path"].ToString(),
                                    Convert.ToInt16(reader["length"].ToString()),
                                    reader["album"].ToString(),
                                    Convert.ToInt16(reader["year"].ToString()),
                                    GetArtists(Convert.ToInt16(reader["id"])),
                                    GetGenres(Convert.ToInt16(reader["id"])),
                                    GetTags(Convert.ToInt16(reader["id"]), MediaType.Song)));
                            }
                        }
                    }
                    break;
                case MediaType.Image:
                    using (SqlConnection conn =
                        new SqlConnection(ConfigurationManager.ConnectionStrings["Database"].ConnectionString)) {
                        conn.Open();

                        using (SqlCommand command = new SqlCommand("select * from Song", conn))
                        using (SqlDataReader reader = command.ExecuteReader()) {
                            while (reader.Read()) {
                                newList.Add(new Song(
                                    Convert.ToInt16(reader["id"].ToString()),
                                    reader["title"].ToString(),
                                    reader["path"].ToString(),
                                    Convert.ToInt16(reader["length"].ToString()),
                                    reader["album"].ToString(),
                                    Convert.ToInt16(reader["year"].ToString()),
                                    GetArtists(Convert.ToInt16(reader["id"])),
                                    GetGenres(Convert.ToInt16(reader["id"])),
                                    GetTags(Convert.ToInt16(reader["id"]), MediaType.Image)));
                            }
                        }
                    }
                    break;
            }
            return newList;
        }
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
        internal static void InsertGenre(string genre) {
            using (SqlConnection conn =
                new SqlConnection(ConfigurationManager.ConnectionStrings["Database"].ConnectionString)) {
                conn.Open();
                string commandString = String.Format(
                    "if not exists (select 1 from Genre where name = '{0}')" +
                    "insert into Genre (name)" +
                    "values('{0}');",
                    genre.Replace("'", "''"));

                using (SqlCommand command = new SqlCommand(commandString, conn)) {
                    command.ExecuteNonQuery();
                }
            }
        }
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
        internal static void InsertTag(string tag) {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Database"].ConnectionString)) {
                conn.Open();

                string commandString = String.Format(
                    "if not exists (select 1 from Tag where name = '{0}')" +
                    "insert into Tag (name)" +
                    "values('{0}');",
                    tag.Replace("'", "''"));

                using (SqlCommand command = new SqlCommand(commandString, conn)) {
                    command.ExecuteNonQuery();
                }
            }
        }
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
        internal static void InsertArtist(string artist) {
            using (SqlConnection conn =
                new SqlConnection(ConfigurationManager.ConnectionStrings["Database"].ConnectionString)) {
                conn.Open();

                string commandString = String.Format(
                    "if not exists (select 1 from Artist where name = '{0}')" +
                    "insert into Artist (name)" +
                    "values('{0}');",
                    artist.Replace("'", "''"));

                using (SqlCommand command = new SqlCommand(commandString, conn)) {
                    command.ExecuteNonQuery();
                }
            }
        }
        public static List<Image> GetImages() {
            List<Image> newList = new List<Image>();
            using (SqlConnection conn =
                new SqlConnection(ConfigurationManager.ConnectionStrings["Database"].ConnectionString)) {
                conn.Open();

                using (SqlCommand command = new SqlCommand("select * from Image", conn))
                using (SqlDataReader reader = command.ExecuteReader()) {
                    while (reader.Read()) {
                        newList.Add(new Image(
                            Convert.ToInt16(reader["id"]),
                            reader["title"].ToString(),
                            reader["path"].ToString(),
                            Convert.ToInt16(reader["height"]),
                            Convert.ToInt16(reader["width"]),
                            Database.GetTags(Convert.ToInt16(reader["id"]), Database.MediaType.Image)));
                    }
                }
            }
            return newList;
        }
        public enum MediaType { Song, Image }
    }
}