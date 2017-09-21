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
    }
}
