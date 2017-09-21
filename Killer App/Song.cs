using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Killer_App {
    public class Song : MediaFile {

        // FIELDS
        private int _lenght;
        private string _album;
        private int _year;
        private List<Artist> _artists;
        private List<Genre> _genres;
        private List<Tag> _tags;

        // PROPERTIES

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
        public Song(int id, string title, string path, int length, string album, int year, List<Artist> artists, List<Genre> genres, List<Tag> tags) : base(id, title, path) {
            _lenght = length;
            _album = album;
            _year = year;
            _artists = artists;
            _genres = genres;
            _tags = tags;
        }

        // METHODS
        public string ArtistsAsString() {
            string artistsString = string.Empty;
            foreach (Artist artist in _artists) {
                artistsString += "," + artist.Name;
            }
            return artistsString.TrimStart(',');
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
    }
}
