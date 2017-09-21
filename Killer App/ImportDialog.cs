using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace Killer_App {
    public partial class ImportDialog : Form {

        // FIELDS

        // PROPERTIES

        // CONSTRUCTORS
        public ImportDialog() {
            InitializeComponent();
        }

        // EVENT HANDLERS
        private void btnUpdate_Click(object sender, EventArgs e) {
            LoadFiles();
        }
        private void btnCancel_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
        }
        private void btnOk_Click(object sender, EventArgs e) {
            ImportFiles();
            DialogResult = DialogResult.OK;
        }
        private void dgvMusic_SelectionChanged(object sender, EventArgs e) {
            updateFileCounter();
        }
        private void dgvImages_SelectionChanged(object sender, EventArgs e) {
            updateFileCounter();
        }
        private void btnAddFolders_Click(object sender, EventArgs e) {
            LoadFolders();
        }

        // METHODS
        private void LoadFiles() {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = true;
            dialog.CheckFileExists = false;
            dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyComputer);
            dialog.Filter = "All|*.bmp;*.jpg;*.jpeg;*.png;*.tif;*.tiff;*.mp3|Images|*.bmp;*.jpg;*.jpeg;*.png;*.tif;*.tiff|Music|*.mp3";
            DialogResult result = dialog.ShowDialog();
            if (result != DialogResult.OK) {
                return;
            }

            int invalidPathCount = 0;
            foreach (string path in dialog.FileNames) {
                if (!File.Exists(path)) {
                    invalidPathCount++;
                }
            }

            if (invalidPathCount > 0) {
                MessageBox.Show(string.Format("Failed to add {0} of {1} files", invalidPathCount, dialog.FileNames.Length), "Invalid Paths");
            }

            foreach (string fileName in dialog.FileNames) {
                FileInfo file = new FileInfo(fileName);
                TagLib.File fileTagLib = TagLib.File.Create(fileName);
                if (file.Extension == ".mp3") {
                    string artists = string.Empty;
                    string genres = string.Empty;

                    foreach (string artist in fileTagLib.Tag.Performers) {
                        artists += "," + artist;
                    }
                    artists = artists.TrimStart(',');

                    foreach (string genre in fileTagLib.Tag.Genres) {
                        genres += "," + genre;
                    }
                    genres = genres.TrimStart(',');

                    string title = file.Name.Remove(file.Name.LastIndexOf('.'));
                    if (!string.IsNullOrWhiteSpace(fileTagLib.Tag.Title)) {
                        title = fileTagLib.Tag.Title;
                    }

                    dgvMusic.Rows.Add(
                        title,
                        artists,
                        Song.secondsToTime(Convert.ToInt16(fileTagLib.Properties.Duration.TotalSeconds)),
                        fileTagLib.Tag.Album,
                        genres,
                        fileTagLib.Tag.Year,
                        file.FullName);
                } else {
                    dgvImages.Rows.Add(
                        System.Drawing.Image.FromFile(file.FullName),
                        file.Name.Remove(file.Name.LastIndexOf('.')),
                        Image.CalculateAspectRatio(fileTagLib.Properties.PhotoWidth, fileTagLib.Properties.PhotoHeight),
                        fileTagLib.Properties.PhotoHeight,
                        fileTagLib.Properties.PhotoWidth,
                        string.Empty,
                        file.FullName);
                }
            }
            dgvMusic.Rows[0].Cells[0].Selected = true;
            dgvMusic.Rows[0].Cells[0].Selected = false;
        }
        private void LoadFolders() {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.Multiselect = true;
            dialog.IsFolderPicker = true;
            dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyComputer);
            dialog.ShowDialog();

            int invalidPathCount = 0;
            try {
                foreach (string path in dialog.FileNames) {
                    if (!Directory.Exists(path)) {
                        invalidPathCount++;
                    }
                }
            } catch (InvalidOperationException ex) {
                return;
            }

            if (invalidPathCount > 0) {
                MessageBox.Show(string.Format("Failed to add {0} of {1} files", invalidPathCount, dialog.FileNames.Count()), "Invalid Paths");
            }

            List<string> directories = new List<string>();
            foreach (string directory in dialog.FileNames) {
                directories.AddRange(directories);
                directories.AddRange(Directory.GetDirectories(directory, "*", SearchOption.AllDirectories));
            }

            foreach (string path in directories) {
                DirectoryInfo dir = new DirectoryInfo(path);
                foreach (FileInfo file in dir.GetFiles()) {
                    if (file.Extension == ".mp3") {
                        TagLib.File fileTagLib = TagLib.File.Create(file.FullName);
                        string artists = string.Empty;
                        string genres = string.Empty;

                        foreach (string artist in fileTagLib.Tag.Performers) {
                            artists += "," + artist;
                        }
                        artists = artists.TrimStart(',');

                        foreach (string genre in fileTagLib.Tag.Genres) {
                            genres += "," + genre;
                        }
                        genres = genres.TrimStart(',');

                        string title = file.Name.Remove(file.Name.LastIndexOf('.'));
                        if (!string.IsNullOrWhiteSpace(fileTagLib.Tag.Title)) {
                            title = fileTagLib.Tag.Title;
                        }

                        dgvMusic.Rows.Add(
                            title,
                            artists,
                            Song.secondsToTime(Convert.ToInt16(fileTagLib.Properties.Duration.TotalSeconds)),
                            fileTagLib.Tag.Album,
                            genres,
                            fileTagLib.Tag.Year,
                            file.FullName);

                    } else if (file.Extension == ".png" || file.Extension == ".jpeg" || file.Extension == ".jpg" ||
                               file.Extension == ".bmp" || file.Extension == ".tif" || file.Extension == ".tiff") {
                        try {
                            TagLib.File fileTagLib = TagLib.File.Create(file.FullName);
                            dgvImages.Rows.Add(
                                System.Drawing.Image.FromFile(file.FullName),
                                file.Name.Remove(file.Name.LastIndexOf('.')),
                                Image.CalculateAspectRatio(fileTagLib.Properties.PhotoWidth, fileTagLib.Properties.PhotoHeight),
                                fileTagLib.Properties.PhotoHeight,
                                fileTagLib.Properties.PhotoWidth,
                                string.Empty,
                                file.FullName);
                        } catch (Exception e) {
                            MessageBox.Show(e.ToString());
                        }
                    }
                }
            }
            //dgvMusic.Rows[0].Cells[0].Selected = true;
            //dgvMusic.Rows[0].Cells[0].Selected = false;
        }
        private void updateFileCounter() {
            int files = dgvMusic.RowCount + dgvImages.RowCount;

            int incompleteRows = 0;
            int emptyFields = 0;
            bool rowChecked = false;

            lbFileCount.Text = String.Format("{0} Files\n{1} Songs\n{2} Images", files, dgvMusic.RowCount, dgvImages.RowCount);
        }
        private void ImportFiles() {
            int errorCount = 0;

            List<Song> songs = new List<Song>();
            List<Image> images = new List<Image>();
            try {
                foreach (DataGridViewRow row in dgvMusic.Rows) {
                    songs.Add(new Song(
                        0,
                        row.Cells[0].Value.ToString(),
                        row.Cells[6].Value.ToString(),
                        Convert.ToInt16(Song.timeToSeconds(row.Cells[2].Value.ToString())),
                        row.Cells[3].Value.ToString(),
                        Convert.ToInt16(row.Cells[5].Value),
                        Artist.ArtistsFromString(row.Cells[1].Value.ToString(), ','),
                        Genre.GenresFromString(row.Cells[4].Value.ToString(), ','),
                        new List<Tag>()));
                }
                foreach (DataGridViewRow row in dgvImages.Rows) {
                    images.Add(new Image(
                        0,
                        row.Cells[1].Value.ToString(),
                        row.Cells[6].Value.ToString(),
                        Convert.ToInt16(row.Cells[4].Value),
                        Convert.ToInt16(row.Cells[3].Value),
                        Killer_App.Tag.TagsFromString(row.Cells[4].Value.ToString(), ',')));
                }
            } catch (NullReferenceException e) {
                errorCount++;
            }
            if (errorCount > 0) {
                MessageBox.Show(string.Format("Failed to add {0} files due to empty values", errorCount));
            }

            Database.InsertMediaFiles(songs.Cast<MediaFile>().ToList());
            Database.InsertMediaFiles(images.Cast<MediaFile>().ToList());
            songs.Clear();
            images.Clear();
        }

    }
}
