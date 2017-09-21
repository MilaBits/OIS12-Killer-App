using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using TagLib;
using TextBox = System.Windows.Forms.TextBox;

namespace Killer_App {
    public partial class AddItemDialogExperimental : Form {
        enum AutoCompleteType { Artist, Genre, Tag }

        // FIELDS
        private int _dialogItemType = 0;
        private MediaFile _dialogItem = new Song();

        AutoCompleteStringCollection artistAutocomplete = new AutoCompleteStringCollection();
        AutoCompleteStringCollection tagAutocomplete = new AutoCompleteStringCollection();
        AutoCompleteStringCollection genreAutocomplete = new AutoCompleteStringCollection();

        // PROPERTIES
        public MediaFile DialogItem {
            get { return _dialogItem; }
            private set { _dialogItem = value; }
        }

        // CONSTRUCTORS
        public AddItemDialogExperimental() {
            InitializeComponent();

            PopulateDropDowns();
        }
        public AddItemDialogExperimental(Song song) {
            InitializeComponent();

            btnSong.Enabled = false;
            //tbcType.TabPages.Remove(tpImage);

            tbSongPath.Text = song.Path;
            tbSongTitle.Text = song.Title;
            tbAlbum.Text = song.Album;
            tbDuration.Text = Song.secondsToTime(song.Length);
            foreach (Artist songArtist in song.Artists) {
                MakeTag(flpnArtists, songArtist.Name, AutoCompleteType.Artist);
            }
            foreach (Genre songGenre in song.Genres) {
                MakeTag(flpnGenres, songGenre.Name, AutoCompleteType.Genre);
            }
            foreach (Tag songTag in song.Tags) {
                MakeTag(flpnTags, songTag.Name, AutoCompleteType.Tag);
            }
            PopulateDropDowns();
        }
        public AddItemDialogExperimental(Image image) {
            InitializeComponent();

            btnSelectImage.Enabled = false;
            tbcType.SelectedIndex = 1;
            //tbcType.TabPages.Remove(tpSong);

            tbImagePath.Text = image.Path;
            tbImageTitle.Text = image.Title;
            tbHeight.Text = image.Height.ToString();
            tbWidth.Text = image.Width.ToString();
            tbAspect.Text = image.AspectRatio;
            foreach (Tag imageTag in image.Tags) {
                MakeTag(flpnImageTags, imageTag.Name, AutoCompleteType.Tag);
            }
            pbPreview.Image = System.Drawing.Image.FromFile(image.Path);

            PopulateDropDowns();
        }

        // METHODS
        private void MakeTag(Control target, string text, AutoCompleteType type) {
            TextBox tb = new TextBox();
            tb.ForeColor = Color.White;
            tb.Font = new Font("Arial Rounded MT Bold", 9.75f);
            tb.BorderStyle = BorderStyle.None;
            tb.TextAlign = HorizontalAlignment.Center;
            tb.TextChanged += textbox_AutoSize;
            tb.LostFocus += textbox_LostFocus;

            tb.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            tb.AutoCompleteSource = AutoCompleteSource.CustomSource;

            switch (type) {
                case AutoCompleteType.Artist:
                    tb.AutoCompleteCustomSource = artistAutocomplete;
                    tb.BackColor = Color.Tomato;
                    break;
                case AutoCompleteType.Genre:
                    tb.AutoCompleteCustomSource = genreAutocomplete;
                    tb.BackColor = Color.CornflowerBlue;
                    break;
                case AutoCompleteType.Tag:
                    tb.AutoCompleteCustomSource = tagAutocomplete;
                    tb.BackColor = Color.LightGreen;
                    break;
            }

            tb.Text = string.Format("{0}", text);
            tb.Margin = new Padding(2, 2, 2, 2);
            target.Controls.Add(tb);
        }
        private void AutoSize(Control control) {
            Size size = TextRenderer.MeasureText(control.Text, control.Font);
            control.Width = size.Width;
            control.Height = size.Height;
        }
        private void DeleteIfEmpty(Control control) {
            if (string.IsNullOrWhiteSpace(control.Text)) {
                control.Dispose();
            }
        }


        //Event Handlers
        private void btnSong_Click(object sender, EventArgs e) {
            LoadFile();
        }
        private void btnSelectImage_Click(object sender, EventArgs e) {
            LoadFile();
        }
        private void cbbGenres_SelectedIndexChanged(object sender, EventArgs e) {
            MakeTag(flpnGenres, cbbGenres.Text, AutoCompleteType.Genre);
        }
        private void cbbArtists_SelectedIndexChanged(object sender, EventArgs e) {
            MakeTag(flpnArtists, cbbArtists.Text, AutoCompleteType.Artist);
        }
        private void cbbSongTags_SelectedIndexChanged(object sender, EventArgs e) {
            MakeTag(flpnTags, cbbSongTags.Text, AutoCompleteType.Tag);
        }
        private void cbbImageTags_SelectedIndexChanged(object sender, EventArgs e) {
            MakeTag(flpnImageTags, cbbImageTags.Text, AutoCompleteType.Tag);
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
        private void btnOK_Click(object sender, EventArgs e) {
            ConfirmAddition();
        }
        private void btnCancel_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
        private void cbbArtists_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Return && !cbbArtists.Items.Contains(cbbSongTags.Text)) {
                MakeTag(flpnArtists, cbbArtists.Text, AutoCompleteType.Artist);
            }
        }
        private void cbbGenres_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Return && !cbbGenres.Items.Contains(cbbSongTags.Text)) {
                MakeTag(flpnGenres, cbbGenres.Text, AutoCompleteType.Genre);
            }
        }
        private void cbbSongTags_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Return && !cbbSongTags.Items.Contains(cbbSongTags.Text)) {
                MakeTag(flpnTags, cbbSongTags.Text, AutoCompleteType.Tag);
            }
        }
        private void textbox_AutoSize(object sender, EventArgs e) {
            AutoSize((Control)sender);
        }
        private void textbox_LostFocus(object sender, EventArgs e) {
            DeleteIfEmpty((Control)sender);
        }

        // Methods
        private void LoadFile() {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);
            dialog.Multiselect = true;
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

                DialogItem = new Song(0,
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

                DialogItem = new Image(0,
                    file.Name.Remove(file.Name.LastIndexOf('.')),
                    file.FullName,
                    fileTagLib.Properties.PhotoHeight,
                    fileTagLib.Properties.PhotoWidth,
                    new List<Tag>());
                FillImageFields();
            }
        }
        private void FillMusicFields() {

            tbSongTitle.Text = DialogItem.Title;
            tbSongPath.Text = DialogItem.Path;
            tbDuration.Text = TimeSpan.FromSeconds(((Song)DialogItem).Length).ToString(@"m\:ss");
            tbAlbum.Text = ((Song)DialogItem).Album;

            flpnArtists.Controls.Clear();
            flpnGenres.Controls.Clear();
            flpnTags.Controls.Clear();
            foreach (Artist songArtist in ((Song)DialogItem).Artists) {
                MakeTag(flpnArtists, songArtist.Name, AutoCompleteType.Artist);
            }
            foreach (Genre songGenre in ((Song)DialogItem).Genres) {
                MakeTag(flpnGenres, songGenre.Name, AutoCompleteType.Genre);
            }
            foreach (Tag songTag in ((Song)DialogItem).Tags) {
                MakeTag(flpnTags, songTag.Name, AutoCompleteType.Tag);
            }
        }
        private void FillImageFields() {

            tbImageTitle.Text = DialogItem.Title;
            tbImagePath.Text = DialogItem.Path;
            tbHeight.Text = ((Image)DialogItem).Height.ToString();
            tbWidth.Text = ((Image)DialogItem).Width.ToString();

            tbAspect.Text = ((Image)DialogItem).AspectRatio;

            pbPreview.Image = System.Drawing.Image.FromFile(DialogItem.Path);
            foreach (Tag imageTag in ((Image)DialogItem).Tags) {
                MakeTag(flpnImageTags, imageTag.Name, AutoCompleteType.Tag);
            }
        }
        private void PopulateDropDowns() {

            //TODO: Fix autocomplete    
            foreach (Artist artist in Database.GetAllArtists().OrderBy(item => item.Name)) {
                cbbArtists.Items.Add(artist.Name);
                artistAutocomplete.Add(artist.Name);
            }
            cbbArtists.AutoCompleteCustomSource = artistAutocomplete;

            foreach (Tag tag in Killer_App.Database.GetAllTags().OrderBy(item => item.Name)) {
                cbbSongTags.Items.Add(tag.Name);
                cbbImageTags.Items.Add(tag.Name);
                tagAutocomplete.Add(tag.Name);
            }
            cbbImageTags.AutoCompleteCustomSource = tagAutocomplete;
            cbbSongTags.AutoCompleteCustomSource = tagAutocomplete;

            foreach (Genre genre in Database.GetAllGenres().OrderBy(item => item.Name)) {
                cbbGenres.Items.Add(genre.Name);
                genreAutocomplete.Add(genre.Name);
            }
            cbbGenres.AutoCompleteCustomSource = genreAutocomplete;
        }
        private void ConfirmAddition() {
            if (tbcType.SelectedIndex == 0) {
                if (string.IsNullOrEmpty(tbSongTitle.Text)) {
                    MessageBox.Show("Please enter a title");
                    return;
                }

                DialogItem.Title = tbSongTitle.Text;
                DialogItem.Path = tbSongPath.Text;
                ((Song)DialogItem).Album = tbAlbum.Text;

                //_dialogSong.Artists.Clear();
                foreach (TextBox artist in flpnArtists.Controls) {
                    ((Song)DialogItem).Artists.Add(new Artist(0, artist.Text.Trim(' ')));
                }
                //_dialogSong.Genres.Clear();
                foreach (TextBox genre in flpnGenres.Controls) {
                    ((Song)DialogItem).Genres.Add(new Genre(0, genre.Text.Trim(' ')));
                }
                //_dialogSong.Tags.Clear();
                foreach (TextBox tag in flpnTags.Controls) {
                    ((Song)DialogItem).Tags.Add(new Tag(0, tag.Text.Trim(' ')));
                }
            } else if (tbcType.SelectedIndex == 1) {
                if (string.IsNullOrEmpty(tbImageTitle.Text)) {
                    MessageBox.Show("Please enter a title");
                    return;
                }

                DialogItem.Title = tbImageTitle.Text;
                DialogItem.Path = tbImagePath.Text;

                ((Image)DialogItem).Height = Convert.ToInt16(tbHeight.Text);
                ((Image)DialogItem).Width = Convert.ToInt16(tbWidth.Text);


                ((Image)DialogItem).Tags.Clear();
                foreach (TextBox tag in flpnImageTags.Controls) {
                    ((Image)DialogItem).Tags.Add(new Tag(0, tag.Text.Trim(' ')));
                }
            }

            _dialogItemType = tbcType.SelectedIndex;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
