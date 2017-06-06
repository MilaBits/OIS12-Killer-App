using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Linq;
using NAudio.Wave;

namespace Killer_App {

    public enum Tab { Music, Images }
    public partial class mainForm : Form {

        // FIELDS
        List<Song> songs = new List<Song>();
        List<Image> images = new List<Image>();
        IWavePlayer waveOutDevice = new WaveOut();

        // PROPERTIES

        // CONSTRUCTORS
        public mainForm() {
            InitializeComponent();
            tmMusicPlayer.Interval = 1000;

            SwitchScreen(Tab.Music);
        }

        // EVENT HANDLERS
        private void btnMusic_Click(object sender, EventArgs e) {
            SwitchScreen(Tab.Music);
        }
        private void btnImages_Click(object sender, EventArgs e) {
            SwitchScreen(Tab.Images);
        }
        private void tbSearch_Enter(object sender, EventArgs e) {
            tbSearch.Text = string.Empty;
            tbSearch.ForeColor = SystemColors.Control;
        }
        private void tbSearch_Leave(object sender, EventArgs e) {
            if (tbSearch.Text == string.Empty) {
                tbSearch.Text = "Search..";
                tbSearch.ForeColor = SystemColors.ScrollBar;
            }
        }
        private void btnInsert_Click(object sender, EventArgs e) {
            InsertItem();
            RefreshList();
        }
        private void btnRefresh_Click(object sender, EventArgs e) {
            RefreshList();
        }
        private void dgvImages_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            pbImage.Image = System.Drawing.Image.FromFile(dgvImages.SelectedRows[0].Cells[5].Value.ToString());
        }
        private void tbSearch_TextChanged(object sender, EventArgs e) {
            PopulateSongsTable(songs.Where(s => s.Title.Contains(tbSearch.Text) || s.Path.Contains(tbSearch.Text) || s.Album.Contains(tbSearch.Text)).ToList());
        }
        private void dgvImages_SelectionChanged(object sender, EventArgs e) {
            if (dgvImages.Rows.Count > 1) {
                try {
                    string path = dgvImages.SelectedRows[0].Cells[5].Value.ToString();
                    if (File.Exists(path)) {
                        pbImage.Image = System.Drawing.Image.FromFile(path);
                    }
                } catch (Exception ex) {
                    Debug.WriteLine(ex.ToString());
                }
            }
        }
        private void dgvMusic_SelectionChanged(object sender, EventArgs e) {
            if (dgvMusic.Rows.Count > 1) {
                try {
                    string path = dgvMusic.SelectedRows[0].Cells[5].Value.ToString();
                    if (File.Exists(path)) {
                        pbImage.Image = System.Drawing.Image.FromFile(path);
                    }
                } catch (Exception ex) {
                    Debug.WriteLine(ex.ToString());
                }
            }
        }
        private void dgvMusic_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            playSong(Song.timeToSeconds(dgvMusic.SelectedRows[0].Cells[2].Value.ToString()),
                dgvMusic.SelectedRows[0].Cells[6].Value.ToString());
        }
        private void dgvMusic_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Delete) {
                DeleteItems();
                RefreshList();
            }
        }
        private void dgvImages_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Delete) {
                DeleteItems();
                RefreshList();
            }
        }
        private void btnStop_Click(object sender, EventArgs e) {
            stopSong();
        }
        private void btnStart_Click(object sender, EventArgs e) {
            playSong(Song.timeToSeconds(dgvMusic.SelectedRows[0].Cells[2].Value.ToString()),
                dgvMusic.SelectedRows[0].Cells[6].Value.ToString());
        }
        private void btnPause_Click(object sender, EventArgs e) {
            pauseSong();
        }
        private void tmMusicPlayer_Tick(object sender, EventArgs e) {
            if (pbSongProgress.Value == pbSongProgress.Maximum) {
                stopSong();
                tmMusicPlayer.Stop();
                return;
            }
            pbSongProgress.Value++;
            lbTime.Text = String.Format("{0}/{1}", Song.secondsToTime(pbSongProgress.Value),
                dgvMusic.SelectedRows[0].Cells[2].Value);

        }
        private void btnImport_Click(object sender, EventArgs e) {
            ImportItems();
            RefreshList();
        }
        private void btnUpdate_Click(object sender, EventArgs e) {
            UpdateItem();
            RefreshList();
        }

        // METHODS
        private void SwitchScreen(Tab tab) {
            btnImages.BackColor = btnMusic.BackColor = SystemColors.ControlDark;

            switch (tab) {
                case Tab.Images:
                    tbcMain.SelectedIndex = 1;
                    this.Text = "Killer App | Images";
                    btnImages.BackColor = SystemColors.ControlDarkDark;
                    break;
                case Tab.Music:
                    tbcMain.SelectedIndex = 0;
                    this.Text = "Killer App | Music";
                    btnMusic.BackColor = SystemColors.ControlDarkDark;
                    break;
            }
            RefreshList();
        }
        private void InsertItem() {
            //AddItemDialog dialog = new AddItemDialog();
            AddItemDialogExperimental dialog = new AddItemDialogExperimental();
            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK) {
                if (dialog.DialogItemType == 0) {
                    Song.Insert(dialog.DialogSong);
                } else {
                    Image.Insert(dialog.DialogImage);
                }
            }
        }
        private void ImportItems() {
            ImportDialog dialog = new ImportDialog();
            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK) {
                //if (dialog.DialogItemType == 0) {
                //    Song.Insert(dialog.DialogSong);
                //} else {
                //    Image.Insert(dialog.DialogImage);
                //}
            }
        }
        private List<Image> GetImages() {
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
                            Image.GetTags(Convert.ToInt16(reader["id"]))));
                    }
                }
            }
            return newList;
        }
        private void PopulateSongsTable() {
            dgvMusic.Rows.Clear();
            foreach (Song song in songs) {
                dgvMusic.Rows.Add(song.Title, song.ArtistsAsString(),
                    TimeSpan.FromSeconds(song.Length).ToString(@"m\:ss"), song.Album, song.GenresAsString().Trim(','), song.Year,
                    song.Path);
            }
        }
        private void PopulateSongsTable(List<Song> customSongList) {
            dgvMusic.Rows.Clear();
            foreach (Song song in customSongList) {
                dgvMusic.Rows.Add(song.Title, song.ArtistsAsString(),
                    TimeSpan.FromSeconds(song.Length).ToString(@"m\:ss"), song.Album, song.GenresAsString().Trim(','), song.Year,
                    song.Path);
            }
        }
        private void PopulateImagesTable() {
            dgvImages.Rows.Clear();
            foreach (Image image in images) {
                dgvImages.Rows.Add(image.Title, image.AspectRatio, image.Height, image.Width, image.TagsAsString().Trim(','),
                    image.Path);
            }
        }
        private void RefreshList() {
            if (tbcMain.SelectedIndex == 0) {
                songs = Song.GetSongs();
                PopulateSongsTable();
            } else if (tbcMain.SelectedIndex == 1) {
                images = GetImages();
                PopulateImagesTable();
            }
        }
        private void playSong(int duration, string path) {
            // Stop current song
            stopSong();
            pbSongProgress.Value = 0;
            pbSongProgress.Maximum = duration;

            //start new song
            AudioFileReader audioFileReader = new AudioFileReader(path);
            waveOutDevice.Init(audioFileReader);
            lbSongPlaying.Text = dgvMusic.SelectedRows[0].Cells[0].Value.ToString();

            waveOutDevice.Play();
            tmMusicPlayer.Start();

        }
        private void pauseSong() {
            if (waveOutDevice.PlaybackState != PlaybackState.Paused) {
                waveOutDevice.Pause();
                tmMusicPlayer.Stop();
            } else {
                waveOutDevice.Play();
                tmMusicPlayer.Start();
            }
        }
        private void stopSong() {
            waveOutDevice.Stop();
            waveOutDevice.Dispose();
        }
        private Song SongFromDataGridViewRow(DataGridViewRow row) {
            return new Song(
                0,
                row.Cells[0].Value.ToString(),
                row.Cells[6].Value.ToString(),
                Convert.ToInt16(Song.timeToSeconds(row.Cells[2].Value.ToString())),
                row.Cells[3].Value.ToString(),
                Convert.ToInt16(row.Cells[5].Value),
                Artist.ArtistsFromString(row.Cells[1].Value.ToString(), ','),
                Genre.GenresFromString(row.Cells[4].Value.ToString(), ','),
                new List<Tag>());
        }
        private Image ImageFromDataGridViewRow(DataGridViewRow row) {
            return new Image(
                0,
                row.Cells[0].Value.ToString(),
                row.Cells[5].Value.ToString(),
                Convert.ToInt16(row.Cells[3].Value),
                Convert.ToInt16(row.Cells[2].Value),
                Killer_App.Tag.TagsFromString(row.Cells[4].Value.ToString(), ','));
        }
        private void UpdateItem() {
            //TODO: Make updating items work
            if (tbcMain.SelectedIndex == 0) {
                //AddItemDialog dialog = new AddItemDialog(SongFromDataGridViewRow(dgvMusic.CurrentRow));
                AddItemDialogExperimental dialog = new AddItemDialogExperimental(SongFromDataGridViewRow(dgvMusic.CurrentRow));
                DialogResult result = dialog.ShowDialog();
                if (result == DialogResult.OK) {
                    Song.Update(dialog.DialogSong);
                }
            } else {
                //AddItemDialog dialog = new AddItemDialog(ImageFromDataGridViewRow(dgvImages.CurrentRow));
                AddItemDialogExperimental dialog = new AddItemDialogExperimental(ImageFromDataGridViewRow(dgvImages.CurrentRow));
                DialogResult result = dialog.ShowDialog();
                if (result == DialogResult.OK) {
                    Image.Update(dialog.DialogImage);
                }
            }
        }
        private void DeleteItems() {
            tmMusicPlayer.Stop();
            pbSongProgress.Value = 0;
            lbSongPlaying.Text = "";
            foreach (DataGridViewRow row in dgvMusic.SelectedRows) {
                Song.DeleteFromDB(SongFromDataGridViewRow(row));
            }
            foreach (DataGridViewRow row in dgvImages.SelectedRows) {
                Image.DeleteFromDB(ImageFromDataGridViewRow(row));
            }
        }
    }
}