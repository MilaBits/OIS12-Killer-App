using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Killer_App {
    public class Song {

        // FIELDS
        private int _id;
        private string _title;
        private string _path;
        private int _lenght;
        private string _album;
        private int _year;
        private List<Artist> _artists;
        private List<Genre> _genres;
        private List<Tag> _tags;

        // PROPERTIES
        public int Id {
            get { return _id; }
        }
        public string Title {
            get { return _title; }
            set { _title = value; }
        }
        public string Path {
            get { return _path; }
            set { _path = value; }
        }
        public int Length {
            get { return _lenght; }
        }
        public string Album {
            get { return _album; }
            set { _album = value; }
        }
        public int Year {
            get { return _year; }
        }
        public List<Artist> Artists {
            get { return _artists; }
            set { _artists = value; }
        }
        public List<Genre> Genres {
            get { return _genres; }
            set { _genres = value; }
        }
        public List<Tag> Tags {
            get { return _tags; }
            set { _tags = value; }
        }

        // CONSTRUCTORS
        public Song() {
            _artists = new List<Artist>();
            _genres = new List<Genre>();
            _tags = new List<Tag>();
        }
        public Song(int id, string title, string path, int length, string album, int year, List<Artist> artists, List<Genre> genres, List<Tag> tags) {
            _id = id;
            _title = title;
            _path = path;
            _lenght = length;
            _album = album;
            _year = year;
            _artists = artists;
            _genres = genres;
            _tags = tags;
        }

        // METHODS
        internal static void Insert(Song song) {

            // Make sure the related genres, artists and tags exist
            foreach (Genre songGenre in song.Genres) {
                Genre.Insert(songGenre.Name);
            }
            foreach (Artist songArtist in song.Artists) {
                Artist.Insert(songArtist.Name);
            }
            foreach (Tag songTag in song.Tags) {
                Tag.Insert(songTag.Name);
            }

            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Database"].ConnectionString)) {
                conn.Open();

                if (Song.isStored(song, conn)) {
                    return;
                }

                //Insert song
                string commandString = string.Format(
                    "insert into Song (title, path, length, album, year)" +
                    "values('{0}', '{1}', {2}, '{3}', {4});",
                    song.Title.Replace("'", "''"),
                    song.Path.Replace("'", "''"),
                    song.Length,
                    song.Album.Replace("'", "''"),
                    song.Year);
                using (SqlCommand command = new SqlCommand(commandString, conn)) {
                    if (!string.IsNullOrWhiteSpace(commandString))
                        command.ExecuteNonQuery();
                }

                //Insert song's Genres
                string genresCommand = string.Empty;
                foreach (Genre songGenre in song.Genres.Distinct()) {
                    genresCommand += string.Format(
                        "insert into Genre_Song (song_id, genre_id)" +
                        "values((select id from Song where title = '{0}')," +
                        "(select id from Genre where name = '{1}')); ",
                        song.Title.Replace("'", "''"),
                        songGenre.Name.Replace("'", "''"));

                    using (SqlCommand command = new SqlCommand(genresCommand, conn)) {
                        if (!string.IsNullOrWhiteSpace(genresCommand))
                            command.ExecuteNonQuery();
                    }
                }

                //Insert song's Artists
                string artistsCommand = string.Empty;
                foreach (Artist songArtist in song.Artists.Distinct()) {
                    artistsCommand += string.Format(
                        "insert into Artist_Song (song_id, artist_id)" +
                        "values((select id from Song where title = '{0}')," +
                        "(select id from Artist where name = '{1}')); ",
                        song.Title.Replace("'", "''"),
                        songArtist.Name.Replace("'", "''"));
                }
                using (SqlCommand command = new SqlCommand(artistsCommand, conn)) {
                    if (!string.IsNullOrWhiteSpace(artistsCommand))
                        command.ExecuteNonQuery();
                }

                //Insert song's Tags
                string tagsCommand = string.Empty;
                foreach (Tag songTag in song.Tags.Distinct()) {
                    tagsCommand += string.Format(
                        "insert into Tag_Song (song_id, tag_id)" +
                        "values((select id from Song where title = '{0}')," +
                        "(select id from Tag where name = '{1}')); ",
                        song.Title.Replace("'", "''"),
                        songTag.Name.Replace("'", "''"));
                }
                using (SqlCommand command = new SqlCommand(tagsCommand, conn)) {
                    if (!string.IsNullOrWhiteSpace(tagsCommand))
                        command.ExecuteNonQuery();
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
            newList.RemoveAt(0);
            return newList;
        }
        internal static void Insert(List<Song> songs) {
            foreach (Song song in songs) {

                // Make sure the related genres, artists and tags exist
                foreach (Genre songGenre in song.Genres) {
                    Genre.Insert(songGenre.Name);
                }
                foreach (Artist songArtist in song.Artists) {
                    Artist.Insert(songArtist.Name);
                }
                foreach (Tag songTag in song.Tags) {
                    Tag.Insert(songTag.Name);
                }

                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Database"].ConnectionString)) {
                    conn.Open();

                    if (Song.isStored(song, conn)) {
                        continue;
                    }

                    //Insert song
                    string commandString = string.Format(
                        "insert into Song (title, path, length, album, year)" +
                        "values('{0}', '{1}', {2}, '{3}', {4});",
                        song.Title.Replace("'", "''"),
                        song.Path.Replace("'", "''"),
                        song.Length,
                        song.Album.Replace("'", "''"),
                        song.Year);
                    using (SqlCommand command = new SqlCommand(commandString, conn)) {
                        if (!string.IsNullOrWhiteSpace(commandString))
                            command.ExecuteNonQuery();
                    }

                    //Insert song's Genres
                    string genresCommand = string.Empty;
                    foreach (Genre songGenre in song.Genres.Distinct()) {
                        genresCommand += string.Format(
                            "insert into Genre_Song (song_id, genre_id)" +
                            "values((select id from Song where path = '{0}')," +
                            "(select id from Genre where name = '{1}')); ",
                            song.Path.Replace("'", "''"),
                            songGenre.Name.Replace("'", "''"));

                        using (SqlCommand command = new SqlCommand(genresCommand, conn)) {
                            if (!string.IsNullOrWhiteSpace(genresCommand))
                                command.ExecuteNonQuery();
                        }
                    }

                    //Insert song's Artists
                    string artistsCommand = string.Empty;
                    foreach (Artist songArtist in song.Artists.Distinct()) {
                        artistsCommand += string.Format(
                            "insert into Artist_Song (song_id, artist_id)" +
                            "values((select id from Song where path = '{0}')," +
                            "(select id from Artist where name = '{1}')); ",
                            song.Path.Replace("'", "''"),
                            songArtist.Name.Replace("'", "''"));
                    }
                    using (SqlCommand command = new SqlCommand(artistsCommand, conn)) {
                        if (!string.IsNullOrWhiteSpace(artistsCommand))
                            command.ExecuteNonQuery();
                    }

                    //Insert song's Tags
                    string tagsCommand = string.Empty;
                    foreach (Tag songTag in song.Tags.Distinct()) {
                        tagsCommand += string.Format(
                            "insert into Tag_Song (song_id, tag_id)" +
                            "values((select id from Song where path = '{0}')," +
                            "(select id from Tag where name = '{1}')); ",
                            song.Path.Replace("'", "''"),
                            songTag.Name.Replace("'", "''"));
                    }
                    using (SqlCommand command = new SqlCommand(tagsCommand, conn)) {
                        if (!string.IsNullOrWhiteSpace(tagsCommand))
                            command.ExecuteNonQuery();
                    }
                }
            }
        }
        internal static void Update(Song song) {
            // Make sure the related genres, artists and tags exist
            foreach (Genre songGenre in song.Genres) {
                Genre.Insert(songGenre.Name);
            }
            foreach (Artist songArtist in song.Artists) {
                Artist.Insert(songArtist.Name);
            }
            foreach (Tag songTag in song.Tags) {
                Tag.Insert(songTag.Name);
            }

            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Database"].ConnectionString)) {
                conn.Open();

                if (Song.isStored(song, conn)) {
                    return;
                }

                //Insert song
                string commandString = string.Format(
                    "update Song set title = '{0}', path = '{1}', length = {2}, album = '{4}', year {5} where path = '{1}'",
                    song.Title.Replace("'", "''"),
                    song.Path.Replace("'", "''"),
                    song.Length,
                    song.Album.Replace("'", "''"),
                    song.Year);
                using (SqlCommand command = new SqlCommand(commandString, conn)) {
                    if (!string.IsNullOrWhiteSpace(commandString))
                        command.ExecuteNonQuery();
                }

                //Insert song's Genres
                string genresCommand = string.Empty;
                foreach (Genre songGenre in song.Genres.Distinct()) {
                    genresCommand += string.Format(
                        "insert into Genre_Song (song_id, genre_id)" +
                        "values((select id from Song where title = '{0}')," +
                        "(select id from Genre where name = '{1}')); ",
                        song.Title.Replace("'", "''"),
                        songGenre.Name.Replace("'", "''"));

                    using (SqlCommand command = new SqlCommand(genresCommand, conn)) {
                        if (!string.IsNullOrWhiteSpace(genresCommand))
                            command.ExecuteNonQuery();
                    }
                }

                //Insert song's Artists
                string artistsCommand = string.Empty;
                foreach (Artist songArtist in song.Artists.Distinct()) {
                    artistsCommand += string.Format(
                        "insert into Artist_Song (song_id, artist_id)" +
                        "values((select id from Song where title = '{0}')," +
                        "(select id from Artist where name = '{1}')); ",
                        song.Title.Replace("'", "''"),
                        songArtist.Name.Replace("'", "''"));
                }
                using (SqlCommand command = new SqlCommand(artistsCommand, conn)) {
                    if (!string.IsNullOrWhiteSpace(artistsCommand))
                        command.ExecuteNonQuery();
                }

                //Insert song's Tags
                string tagsCommand = string.Empty;
                foreach (Tag songTag in song.Tags.Distinct()) {
                    tagsCommand += string.Format(
                        "insert into Tag_Song (song_id, tag_id)" +
                        "values((select id from Song where title = '{0}')," +
                        "(select id from Tag where name = '{1}')); ",
                        song.Title.Replace("'", "''"),
                        songTag.Name.Replace("'", "''"));
                }
                using (SqlCommand command = new SqlCommand(tagsCommand, conn)) {
                    if (!string.IsNullOrWhiteSpace(tagsCommand))
                        command.ExecuteNonQuery();
                }
            }
        }
        public static bool isStored(Song song, SqlConnection conn) {
            bool exists;
            string songCheck = string.Format("select Song.path from Song where path = '{0}'", song.Path.Replace("'", "''"));
            using (SqlCommand command = new SqlCommand(songCheck, conn)) {
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
        public List<Artist> GetArtists() {
            List<Artist> artists = new List<Artist>();

            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Database"].ConnectionString)) {
                conn.Open();

                string commandString = string.Format("select Artist.name as Artist from Artist where Artist.id = (select Artist_Song.artist_id from Artist_Song where Artist_Song.song_id = {0})", _id);

                using (SqlCommand command = new SqlCommand(commandString, conn))
                using (SqlDataReader reader = command.ExecuteReader()) {
                    while (reader.Read()) {
                        artists.Add(new Artist(Convert.ToInt16(reader["id"]), reader["Artist"].ToString()));
                    }
                }
            }

            return artists;
        }
        public static List<Artist> GetArtists(int id) {
            List<Artist> artists = new List<Artist>();

            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Database"].ConnectionString)) {
                conn.Open();

                string commandString = string.Format("select * from Artist where Artist.id in (select Artist_Song.artist_id from Artist_Song where Artist_Song.song_id = {0})", id);

                using (SqlCommand command = new SqlCommand(commandString, conn))
                using (SqlDataReader reader = command.ExecuteReader()) {
                    while (reader.Read()) {
                        artists.Add(new Artist(Convert.ToInt16(reader["id"]), reader["name"].ToString()));
                    }
                }
            }

            return artists;
        }
        public string ArtistsAsString() {
            string artistsString = string.Empty;
            foreach (Artist artist in _artists) {
                artistsString += "," + artist.Name;
            }
            return artistsString.TrimStart(',');
        }
        public List<Genre> GetGenres() {
            List<Genre> Genres = new List<Genre>();

            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Database"].ConnectionString)) {
                conn.Open();

                string commandString = string.Format("select Genre.name as Genre from Genre where Genre.id = (select Genre_Song.Genre_id from Genre_Song where Genre_Song.song_id = {0})", _id);

                using (SqlCommand command = new SqlCommand(commandString, conn))
                using (SqlDataReader reader = command.ExecuteReader()) {
                    while (reader.Read()) {
                        Genres.Add(new Genre(Convert.ToInt16(reader["id"]), reader["Genre"].ToString()));
                    }
                }
            }

            return Genres;
        }
        public static List<Genre> GetGenres(int id) {
            List<Genre> Genres = new List<Genre>();

            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Database"].ConnectionString)) {
                conn.Open();

                string commandString = string.Format("select * from Genre where genre.id in (select Genre_Song.Genre_id from Genre_Song where Genre_Song.song_id = {0})", id);

                using (SqlCommand command = new SqlCommand(commandString, conn))
                using (SqlDataReader reader = command.ExecuteReader()) {
                    while (reader.Read()) {
                        Genres.Add(new Genre(Convert.ToInt16(reader["id"]), reader["name"].ToString()));
                    }
                }
            }

            return Genres;
        }
        public string GenresAsString() {
            string GenresString = string.Empty;
            StringBuilder builder = new StringBuilder();
            {
                foreach (Genre Genre in _genres) {
                    builder.Append(", ");
                    builder.Append(Genre.Name);
                }
                GenresString = builder.ToString();
            }
            return GenresString.Trim(' ');
        }
        public List<Tag> GetTags() {
            List<Tag> Tags = new List<Tag>();

            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Database"].ConnectionString)) {
                conn.Open();

                string commandString = string.Format("select Tag.name as Tag from Tag where Tag.id = (select Tag_Song.Tag_id from Tag_Song where Tag_Song.song_id = {0})", _id);

                using (SqlCommand command = new SqlCommand(commandString, conn))
                using (SqlDataReader reader = command.ExecuteReader()) {
                    while (reader.Read()) {
                        Tags.Add(new Tag(Convert.ToInt16(reader["id"]), reader["Tag"].ToString()));
                    }
                }
            }

            return Tags;
        }
        public static List<Tag> GetTags(int id) {
            List<Tag> Tags = new List<Tag>();

            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Database"].ConnectionString)) {
                conn.Open();

                string commandString = string.Format("select * from Tag where tag.id in (select Tag_Song.Tag_id from Tag_Song where Tag_Song.song_id = {0})", id);

                using (SqlCommand command = new SqlCommand(commandString, conn))
                using (SqlDataReader reader = command.ExecuteReader()) {
                    while (reader.Read()) {
                        Tags.Add(new Tag(Convert.ToInt16(reader["id"]), reader["name"].ToString()));
                    }
                }
            }

            return Tags;
        }
        public string TagsAsString() {
            string TagsString = string.Empty;
            foreach (Tag Tag in _tags) {
                TagsString += "," + Tag.Name;
            }
            return TagsString.TrimStart(',');
        }
        public static int timeToSeconds(string time) {
            string[] split = time.Split(':');
            int seconds = Convert.ToInt16(split[0]) * 60 + Convert.ToInt16(split[1]);

            return seconds;
        }
        public static string secondsToTime(int seconds) {
            string minutesString = Convert.ToString(seconds / 60);
            string secondsString = Convert.ToString(seconds % 60);
            if (secondsString.Length < 2)
                secondsString = "0" + secondsString;
            return String.Format("{0}:{1}", minutesString, secondsString);
        }
        public static void DeleteFromDB(Song song) {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Database"].ConnectionString)) {
                conn.Open();

                string commandString = string.Format("DECLARE @id int;" +
                                                     "SET @id = (select id from Song where Song.path = '{0}' and Song.title = '{1}');" +
                                                     "delete Tag_Song where Tag_Song.song_id = @id;" +
                                                     "delete Artist_Song where Artist_Song.song_id = @id;" +
                                                     "delete Genre_Song where Genre_Song.song_id = @id;" +
                                                     "delete Song where Song.id = @id;", song.Path.Replace("'", "''"), song.Title.Replace("'", "''"));

                using (SqlCommand command = new SqlCommand(commandString, conn)) {
                    command.ExecuteNonQuery();
                }
            }
        }
        public static List<Song> Search() {
            List<Song> newList = new List<Song>();
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
                            Song.GetArtists(Convert.ToInt16(reader["id"])),
                            Song.GetGenres(Convert.ToInt16(reader["id"])),
                            Song.GetTags(Convert.ToInt16(reader["id"]))));
                    }
                }
            }
            return newList;
        }
        public override string ToString() {
            return _title;
        }
    }
}
