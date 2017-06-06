using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using TagLib;

namespace Killer_App {
    public partial class AddItemDialog : Form {

        private int _dialogItemType = 0;
        private Song _dialogSong = new Song();
        private Image _dialogImage = new Image();

        public int DialogItemType {
            get {
                return _dialogItemType;
            }
        }
        public Song DialogSong {
            get {
                return _dialogSong;
            }
        }
        public Image DialogImage {
            get {
                return _dialogImage;
            }
        }

        public AddItemDialog(Song song) {
            InitializeComponent();

            btnSong.Enabled = false;
            tbcType.TabPages.Remove(tpImage);

            tbImagePath.Text = song.Path;
            tbSongTitle.Text = song.Title;
            tbAlbum.Text = song.Album;
            tbDuration.Text = Song.secondsToTime(song.Length);
            tbArtists.Text = song.ArtistsAsString();
            tbGenres.Text = song.GenresAsString();
            tbSongTags.Tag = song.TagsAsString();

        }
        public AddItemDialog(Image image) {
            InitializeComponent();

            btnSelectImage.Enabled = false;
            tbcType.TabPages.Remove(tpSong);

            tbSongPath.Text = image.Path;
            tbSongTitle.Text = image.Title;
            tbHeight.Text = image.Height.ToString();
            tbWidth.Text = image.Width.ToString();
            tbAspect.Text = image.AspectRatio;
            tbImageTags.Tag = image.TagsAsString();
            pbPreview.Image = System.Drawing.Image.FromFile(image.Path);
        }

        public AddItemDialog() {
            InitializeComponent();

            PopulateDropDowns();
        }

        //Event Handlers
        private void btnSong_Click(object sender, EventArgs e) {
            LoadFile();
        }
        private void btnSelectImage_Click(object sender, EventArgs e) {
            LoadFile();
        }
        private void cbbGenres_SelectedIndexChanged(object sender, EventArgs e) {
            tbGenres.Text += string.Format(",{0}", cbbGenres.Text);
        }

        private void cbbArtists_SelectedIndexChanged(object sender, EventArgs e) {
            tbArtists.Text += string.Format(",{0}", cbbArtists.Text);
        }

        private void cbbSongTags_SelectedIndexChanged(object sender, EventArgs e) {
            tbSongTags.Text += string.Format(",{0}", cbbSongTags.Text);
        }

        private void cbbImageTags_SelectedIndexChanged(object sender, EventArgs e) {
            tbImageTags.Text += string.Format(",{0}", cbbImageTags.Text);
        }

        private void tbDuration_TextChanged(object sender, EventArgs e) {
            AutoSize((Control)sender);
        }

        private void tbSongTitle_TextChanged(object sender, EventArgs e) {
            AutoSize((Control)sender);
        }

        private void tbAlbum_TextChanged(object sender, EventArgs e) {
            AutoSize((Control)sender);
        }

        // Methods
        private void LoadFile() {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);
            dialog.Filter = "All|*.bmp;*.jpg;*.jpeg;*.png;*.tif;*.tiff;*.mp3|Images|*.bmp;*.jpg;*.jpeg;*.png;*.tif;*.tiff|Music|*.mp3";
            DialogResult result = dialog.ShowDialog();
            if (result != DialogResult.OK) {
                return;
            }

            if (!dialog.CheckFileExists && dialog.FileName == null) {
                MessageBox.Show("The chosen file does not exist!", "Invalid Path");
                return;
            }

            FileInfo file = new FileInfo(dialog.FileName);
            TagLib.File fileTagLib = TagLib.File.Create(dialog.FileName, ReadStyle.Average);
            if (file.Extension == ".mp3") {
                tbcType.SelectedIndex = 0;

                List<Artist> artists = new List<Artist>();
                foreach (string artist in fileTagLib.Tag.Performers) {
                    artists.Add(new Artist(0, artist));
                }
                List<Genre> genres = new List<Genre>();
                foreach (string genre in fileTagLib.Tag.Genres) {
                    genres.Add(new Genre(0, genre));
                }

                string title = file.Name.Remove(file.Name.LastIndexOf('.'));
                if (!string.IsNullOrWhiteSpace(fileTagLib.Tag.Title)) {
                    title = fileTagLib.Tag.Title;
                }

                _dialogSong = new Song(0,
                    title,
                    file.FullName,
                    Convert.ToInt16(fileTagLib.Properties.Duration.TotalSeconds),
                    fileTagLib.Tag.Album,
                    Convert.ToInt16(fileTagLib.Tag.Year),
                    artists,
                    genres,
                    new List<Tag>());

                FillMusicFields();
            } else {
                tbcType.SelectedIndex = 1;

                _dialogImage = new Image(0,
                    file.Name.Remove(file.Name.LastIndexOf('.')),
                    file.FullName,
                    fileTagLib.Properties.PhotoHeight,
                    fileTagLib.Properties.PhotoWidth,
                    new List<Tag>());
                FillImageFields();
            }
        }

        private void FillMusicFields() {

            tbSongTitle.Text = _dialogSong.Title;
            tbSongPath.Text = _dialogSong.Path;
            tbDuration.Text = TimeSpan.FromSeconds(_dialogSong.Length).ToString(@"m\:ss");
            tbAlbum.Text = _dialogSong.Album;

            tbGenres.Text = _dialogSong.GenresAsString();
            tbArtists.Text = _dialogSong.ArtistsAsString();
            tbSongTags.Text = _dialogSong.TagsAsString();
        }

        private void FillImageFields() {

            tbImageTitle.Text = _dialogImage.Title;
            tbImagePath.Text = _dialogImage.Path;
            tbHeight.Text = _dialogImage.Height.ToString();
            tbWidth.Text = _dialogImage.Width.ToString();

            tbAspect.Text = _dialogImage.AspectRatio;

            pbPreview.Image = System.Drawing.Image.FromFile(_dialogImage.Path);

            tbImageTags.Text = _dialogImage.TagsAsString();
        }

        private void PopulateDropDowns() {

            //TODO: Fix autocomplete    
            List<string> artistsAutocomplete = new List<string>();
            foreach (Artist artist in Artist.GetAllArtists().OrderBy(item => item.Name)) {
                cbbArtists.Items.Add(artist.ToString());
                artistsAutocomplete.Add(artist.ToString());
            }
            AutoCompleteStringCollection autoCompleteStringCollection = new AutoCompleteStringCollection();
            autoCompleteStringCollection.AddRange(artistsAutocomplete.ToArray());

            tbArtists.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            tbArtists.AutoCompleteSource = AutoCompleteSource.CustomSource;
            tbArtists.AutoCompleteCustomSource = autoCompleteStringCollection;


            AutoCompleteStringCollection tagAutocomplete = new AutoCompleteStringCollection();
            foreach (Tag tag in Killer_App.Tag.GetAllTags().OrderBy(item => item.Name)) {
                cbbSongTags.Items.Add(tag.ToString());
                cbbImageTags.Items.Add(tag.ToString());
                tagAutocomplete.Add(tag.Name);
            }
            tbImageTags.AutoCompleteCustomSource = tagAutocomplete;
            tbSongTags.AutoCompleteCustomSource = tagAutocomplete;

            AutoCompleteStringCollection genreAutocomplete = new AutoCompleteStringCollection();
            foreach (Genre genre in Genre.GetAllGenres().OrderBy(item => item.Name)) {
                cbbGenres.Items.Add(genre.ToString());
                genreAutocomplete.Add(genre.ToString());
            }
            tbGenres.AutoCompleteCustomSource = genreAutocomplete;
        }

        private void btnOK_Click(object sender, EventArgs e) {
            if (tbcType.SelectedIndex == 0) {
                _dialogSong.Title = tbSongTitle.Text;
                _dialogSong.Album = tbAlbum.Text;

                _dialogSong.Artists.Clear();
                foreach (string artist in tbArtists.Text.Trim(',').Split(',')) {
                    _dialogSong.Artists.Add(new Artist(0, artist));
                }
                _dialogSong.Genres.Clear();
                foreach (string genre in tbGenres.Text.Trim(',').Split(',')) {
                    _dialogSong.Genres.Add(new Genre(0, genre));
                }
                _dialogSong.Tags.Clear();
                foreach (string tag in tbSongTags.Text.Trim(',').Split(',')) {
                    _dialogSong.Tags.Add(new Tag(0, tag));
                }
            } else if (tbcType.SelectedIndex == 1) {

                _dialogImage.Title = tbSongTitle.Text;

                DialogImage.Tags.Clear();
                foreach (string tag in tbImageTags.Text.Trim(',').Split(',')) {
                    _dialogImage.Tags.Add(new Tag(0, tag));
                }
            }

            _dialogItemType = tbcType.SelectedIndex;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void AutoSize(Control control) {
            Size size = TextRenderer.MeasureText(control.Text, control.Font);
            control.Width = size.Width;
            control.Height = size.Height;
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
