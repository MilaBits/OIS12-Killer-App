using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Killer_App {
    public abstract class MediaFile {

        // Fields
        private int id;
        private string title;
        private string path;

        // Properties
        public int Id {
            get { return id; }
        }
        public string Title {
            get { return title; }
            set { title = value; }
        }
        public string Path {
            get { return path; }
            set { path = value; }
        }

        // Constructor
        public MediaFile()
        {
            this.id = 0;
            this.title = string.Empty;
            this.path = string.Empty;
        }

        public MediaFile(int id, string title, string path)
        {
            this.id = id;
            this.title = title;
            this.path = path;
        }

        public override string ToString() {
            return title;
        }
    }
}
