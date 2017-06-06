namespace Killer_App {
    partial class mainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnPlayer = new System.Windows.Forms.Panel();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.lbSongPlaying = new System.Windows.Forms.Label();
            this.lbTime = new System.Windows.Forms.Label();
            this.pbSongProgress = new System.Windows.Forms.ProgressBar();
            this.dgvMusic = new System.Windows.Forms.DataGridView();
            this.dgvMusicTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvMusicArtist = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvMusicLength = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvMusicAlbum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvMusicGenre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvMusicYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvMusicPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dgvImages = new System.Windows.Forms.DataGridView();
            this.dgvImagesTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvImagesAspectRatio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvImagesHeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvImagesWidth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvImagesTags = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvImagesPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.btnMusic = new System.Windows.Forms.Button();
            this.btnImages = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.tbcMain = new System.Windows.Forms.TabControl();
            this.tabMusic = new System.Windows.Forms.TabPage();
            this.tabImages = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tmMusicPlayer = new System.Windows.Forms.Timer(this.components);
            this.pnPlayer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMusic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.tbcMain.SuspendLayout();
            this.tabMusic.SuspendLayout();
            this.tabImages.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnPlayer
            // 
            this.pnPlayer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnPlayer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnPlayer.Controls.Add(this.btnStop);
            this.pnPlayer.Controls.Add(this.btnPause);
            this.pnPlayer.Controls.Add(this.btnStart);
            this.pnPlayer.Controls.Add(this.lbSongPlaying);
            this.pnPlayer.Controls.Add(this.lbTime);
            this.pnPlayer.Controls.Add(this.pbSongProgress);
            this.pnPlayer.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnPlayer.Location = new System.Drawing.Point(0, 546);
            this.pnPlayer.Margin = new System.Windows.Forms.Padding(0);
            this.pnPlayer.Name = "pnPlayer";
            this.pnPlayer.Size = new System.Drawing.Size(1088, 80);
            this.pnPlayer.TabIndex = 6;
            // 
            // btnStop
            // 
            this.btnStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStop.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnStop.FlatAppearance.BorderSize = 0;
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStop.Font = new System.Drawing.Font("Webdings", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnStop.ForeColor = System.Drawing.SystemColors.Control;
            this.btnStop.Location = new System.Drawing.Point(975, 42);
            this.btnStop.Margin = new System.Windows.Forms.Padding(0);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(32, 32);
            this.btnStop.TabIndex = 12;
            this.btnStop.Text = "g";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnPause
            // 
            this.btnPause.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPause.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnPause.FlatAppearance.BorderSize = 0;
            this.btnPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPause.Font = new System.Drawing.Font("Webdings", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnPause.ForeColor = System.Drawing.SystemColors.Control;
            this.btnPause.Location = new System.Drawing.Point(1012, 42);
            this.btnPause.Margin = new System.Windows.Forms.Padding(0);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(32, 32);
            this.btnPause.TabIndex = 11;
            this.btnPause.Text = ";";
            this.btnPause.UseVisualStyleBackColor = false;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStart.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnStart.FlatAppearance.BorderSize = 0;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Wingdings 3", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnStart.ForeColor = System.Drawing.SystemColors.Control;
            this.btnStart.Location = new System.Drawing.Point(1049, 42);
            this.btnStart.Margin = new System.Windows.Forms.Padding(0);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(32, 32);
            this.btnStart.TabIndex = 10;
            this.btnStart.Text = "u";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lbSongPlaying
            // 
            this.lbSongPlaying.AutoSize = true;
            this.lbSongPlaying.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSongPlaying.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbSongPlaying.Location = new System.Drawing.Point(13, 31);
            this.lbSongPlaying.Name = "lbSongPlaying";
            this.lbSongPlaying.Size = new System.Drawing.Size(292, 37);
            this.lbSongPlaying.TabIndex = 7;
            this.lbSongPlaying.Text = "Songname - Artist";
            // 
            // lbTime
            // 
            this.lbTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTime.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbTime.Location = new System.Drawing.Point(976, 17);
            this.lbTime.Name = "lbTime";
            this.lbTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbTime.Size = new System.Drawing.Size(106, 23);
            this.lbTime.TabIndex = 6;
            this.lbTime.Text = "0:00/ -";
            this.lbTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pbSongProgress
            // 
            this.pbSongProgress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbSongProgress.BackColor = System.Drawing.Color.Black;
            this.pbSongProgress.Location = new System.Drawing.Point(0, 0);
            this.pbSongProgress.Margin = new System.Windows.Forms.Padding(0);
            this.pbSongProgress.Name = "pbSongProgress";
            this.pbSongProgress.Size = new System.Drawing.Size(1088, 10);
            this.pbSongProgress.TabIndex = 6;
            // 
            // dgvMusic
            // 
            this.dgvMusic.AllowUserToAddRows = false;
            this.dgvMusic.AllowUserToDeleteRows = false;
            this.dgvMusic.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvMusic.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMusic.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMusic.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMusic.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMusic.ColumnHeadersHeight = 32;
            this.dgvMusic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvMusic.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvMusicTitle,
            this.dgvMusicArtist,
            this.dgvMusicLength,
            this.dgvMusicAlbum,
            this.dgvMusicGenre,
            this.dgvMusicYear,
            this.dgvMusicPath});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMusic.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMusic.Location = new System.Drawing.Point(-4, 0);
            this.dgvMusic.Margin = new System.Windows.Forms.Padding(0);
            this.dgvMusic.Name = "dgvMusic";
            this.dgvMusic.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMusic.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvMusic.RowHeadersVisible = false;
            this.dgvMusic.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvMusic.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.dgvMusic.RowTemplate.Height = 30;
            this.dgvMusic.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMusic.Size = new System.Drawing.Size(1092, 545);
            this.dgvMusic.TabIndex = 0;
            this.dgvMusic.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMusic_CellDoubleClick);
            this.dgvMusic.SelectionChanged += new System.EventHandler(this.dgvMusic_SelectionChanged);
            this.dgvMusic.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvMusic_KeyDown);
            // 
            // dgvMusicTitle
            // 
            this.dgvMusicTitle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvMusicTitle.HeaderText = "Title";
            this.dgvMusicTitle.Name = "dgvMusicTitle";
            this.dgvMusicTitle.ReadOnly = true;
            this.dgvMusicTitle.Width = 365;
            // 
            // dgvMusicArtist
            // 
            this.dgvMusicArtist.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvMusicArtist.HeaderText = "Artist";
            this.dgvMusicArtist.Name = "dgvMusicArtist";
            this.dgvMusicArtist.ReadOnly = true;
            // 
            // dgvMusicLength
            // 
            this.dgvMusicLength.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvMusicLength.HeaderText = "Length";
            this.dgvMusicLength.Name = "dgvMusicLength";
            this.dgvMusicLength.ReadOnly = true;
            this.dgvMusicLength.Width = 50;
            // 
            // dgvMusicAlbum
            // 
            this.dgvMusicAlbum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvMusicAlbum.HeaderText = "Album";
            this.dgvMusicAlbum.Name = "dgvMusicAlbum";
            this.dgvMusicAlbum.ReadOnly = true;
            this.dgvMusicAlbum.Width = 150;
            // 
            // dgvMusicGenre
            // 
            this.dgvMusicGenre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvMusicGenre.HeaderText = "Genre(s)";
            this.dgvMusicGenre.Name = "dgvMusicGenre";
            this.dgvMusicGenre.ReadOnly = true;
            this.dgvMusicGenre.Width = 150;
            // 
            // dgvMusicYear
            // 
            this.dgvMusicYear.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvMusicYear.HeaderText = "Year";
            this.dgvMusicYear.Name = "dgvMusicYear";
            this.dgvMusicYear.ReadOnly = true;
            this.dgvMusicYear.Width = 50;
            // 
            // dgvMusicPath
            // 
            this.dgvMusicPath.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvMusicPath.HeaderText = "Path";
            this.dgvMusicPath.Name = "dgvMusicPath";
            this.dgvMusicPath.ReadOnly = true;
            this.dgvMusicPath.Width = 224;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(-4, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dgvImages);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pbImage);
            this.splitContainer1.Size = new System.Drawing.Size(1092, 626);
            this.splitContainer1.SplitterDistance = 373;
            this.splitContainer1.TabIndex = 1;
            // 
            // dgvImages
            // 
            this.dgvImages.AllowUserToAddRows = false;
            this.dgvImages.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvImages.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvImages.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvImages.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvImages.ColumnHeadersHeight = 32;
            this.dgvImages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvImages.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvImagesTitle,
            this.dgvImagesAspectRatio,
            this.dgvImagesHeight,
            this.dgvImagesWidth,
            this.dgvImagesTags,
            this.dgvImagesPath});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvImages.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvImages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvImages.EnableHeadersVisualStyles = false;
            this.dgvImages.Location = new System.Drawing.Point(0, 0);
            this.dgvImages.Margin = new System.Windows.Forms.Padding(0);
            this.dgvImages.Name = "dgvImages";
            this.dgvImages.ReadOnly = true;
            this.dgvImages.RowHeadersVisible = false;
            this.dgvImages.RowTemplate.Height = 30;
            this.dgvImages.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvImages.Size = new System.Drawing.Size(373, 626);
            this.dgvImages.TabIndex = 0;
            this.dgvImages.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvImages_CellDoubleClick);
            this.dgvImages.SelectionChanged += new System.EventHandler(this.dgvImages_SelectionChanged);
            this.dgvImages.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvImages_KeyDown);
            // 
            // dgvImagesTitle
            // 
            this.dgvImagesTitle.HeaderText = "Title";
            this.dgvImagesTitle.Name = "dgvImagesTitle";
            this.dgvImagesTitle.ReadOnly = true;
            // 
            // dgvImagesAspectRatio
            // 
            this.dgvImagesAspectRatio.HeaderText = "Aspect Ratio";
            this.dgvImagesAspectRatio.Name = "dgvImagesAspectRatio";
            this.dgvImagesAspectRatio.ReadOnly = true;
            this.dgvImagesAspectRatio.Width = 60;
            // 
            // dgvImagesHeight
            // 
            this.dgvImagesHeight.HeaderText = "Height";
            this.dgvImagesHeight.Name = "dgvImagesHeight";
            this.dgvImagesHeight.ReadOnly = true;
            this.dgvImagesHeight.Width = 40;
            // 
            // dgvImagesWidth
            // 
            this.dgvImagesWidth.HeaderText = "Width";
            this.dgvImagesWidth.Name = "dgvImagesWidth";
            this.dgvImagesWidth.ReadOnly = true;
            this.dgvImagesWidth.Width = 40;
            // 
            // dgvImagesTags
            // 
            this.dgvImagesTags.HeaderText = "Tags";
            this.dgvImagesTags.Name = "dgvImagesTags";
            this.dgvImagesTags.ReadOnly = true;
            this.dgvImagesTags.Width = 80;
            // 
            // dgvImagesPath
            // 
            this.dgvImagesPath.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvImagesPath.HeaderText = "Path";
            this.dgvImagesPath.Name = "dgvImagesPath";
            this.dgvImagesPath.ReadOnly = true;
            // 
            // pbImage
            // 
            this.pbImage.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pbImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbImage.Location = new System.Drawing.Point(0, 0);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(715, 626);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImage.TabIndex = 0;
            this.pbImage.TabStop = false;
            // 
            // tbSearch
            // 
            this.tbSearch.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tbSearch.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.tbSearch.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.tbSearch.Location = new System.Drawing.Point(3, 3);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(293, 29);
            this.tbSearch.TabIndex = 11;
            this.tbSearch.Text = "search...";
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            this.tbSearch.Enter += new System.EventHandler(this.tbSearch_Enter);
            this.tbSearch.Leave += new System.EventHandler(this.tbSearch_Leave);
            // 
            // btnMusic
            // 
            this.btnMusic.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnMusic.FlatAppearance.BorderSize = 0;
            this.btnMusic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMusic.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMusic.ForeColor = System.Drawing.SystemColors.Control;
            this.btnMusic.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMusic.Location = new System.Drawing.Point(334, 3);
            this.btnMusic.Margin = new System.Windows.Forms.Padding(0);
            this.btnMusic.Name = "btnMusic";
            this.btnMusic.Size = new System.Drawing.Size(75, 33);
            this.btnMusic.TabIndex = 8;
            this.btnMusic.Text = "Music";
            this.btnMusic.UseVisualStyleBackColor = false;
            this.btnMusic.Click += new System.EventHandler(this.btnMusic_Click);
            // 
            // btnImages
            // 
            this.btnImages.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnImages.FlatAppearance.BorderSize = 0;
            this.btnImages.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImages.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImages.ForeColor = System.Drawing.SystemColors.Control;
            this.btnImages.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnImages.Location = new System.Drawing.Point(412, 3);
            this.btnImages.Margin = new System.Windows.Forms.Padding(0);
            this.btnImages.Name = "btnImages";
            this.btnImages.Size = new System.Drawing.Size(75, 33);
            this.btnImages.TabIndex = 9;
            this.btnImages.Text = "Images";
            this.btnImages.UseVisualStyleBackColor = false;
            this.btnImages.Click += new System.EventHandler(this.btnImages_Click);
            // 
            // btnImport
            // 
            this.btnImport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImport.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnImport.FlatAppearance.BorderSize = 0;
            this.btnImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImport.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImport.ForeColor = System.Drawing.SystemColors.Control;
            this.btnImport.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnImport.Location = new System.Drawing.Point(1005, 3);
            this.btnImport.Margin = new System.Windows.Forms.Padding(0);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(75, 33);
            this.btnImport.TabIndex = 10;
            this.btnImport.Text = "Import";
            this.btnImport.UseVisualStyleBackColor = false;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInsert.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnInsert.FlatAppearance.BorderSize = 0;
            this.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsert.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.ForeColor = System.Drawing.SystemColors.Control;
            this.btnInsert.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnInsert.Location = new System.Drawing.Point(927, 3);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(0);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 33);
            this.btnInsert.TabIndex = 13;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Wingdings 3", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnRefresh.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRefresh.Location = new System.Drawing.Point(298, 3);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(0);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(33, 33);
            this.btnRefresh.TabIndex = 14;
            this.btnRefresh.Text = "Q";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // tbcMain
            // 
            this.tbcMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbcMain.Controls.Add(this.tabMusic);
            this.tbcMain.Controls.Add(this.tabImages);
            this.tbcMain.Location = new System.Drawing.Point(-4, 13);
            this.tbcMain.Name = "tbcMain";
            this.tbcMain.SelectedIndex = 0;
            this.tbcMain.Size = new System.Drawing.Size(1092, 652);
            this.tbcMain.TabIndex = 15;
            // 
            // tabMusic
            // 
            this.tabMusic.BackColor = System.Drawing.Color.DimGray;
            this.tabMusic.Controls.Add(this.pnPlayer);
            this.tabMusic.Controls.Add(this.dgvMusic);
            this.tabMusic.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tabMusic.Location = new System.Drawing.Point(4, 22);
            this.tabMusic.Name = "tabMusic";
            this.tabMusic.Padding = new System.Windows.Forms.Padding(3);
            this.tabMusic.Size = new System.Drawing.Size(1084, 626);
            this.tabMusic.TabIndex = 0;
            this.tabMusic.Text = "Music";
            // 
            // tabImages
            // 
            this.tabImages.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabImages.Controls.Add(this.splitContainer1);
            this.tabImages.Location = new System.Drawing.Point(4, 22);
            this.tabImages.Name = "tabImages";
            this.tabImages.Padding = new System.Windows.Forms.Padding(3);
            this.tabImages.Size = new System.Drawing.Size(1084, 626);
            this.tabImages.TabIndex = 1;
            this.tabImages.Text = "Images";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.tbSearch);
            this.panel1.Controls.Add(this.btnInsert);
            this.panel1.Controls.Add(this.btnMusic);
            this.panel1.Controls.Add(this.btnImages);
            this.panel1.Controls.Add(this.btnImport);
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1084, 35);
            this.panel1.TabIndex = 16;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnUpdate.Enabled = false;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.Control;
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnUpdate.Location = new System.Drawing.Point(849, 3);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(0);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 33);
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // tmMusicPlayer
            // 
            this.tmMusicPlayer.Interval = 1;
            this.tmMusicPlayer.Tick += new System.EventHandler(this.tmMusicPlayer_Tick);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1084, 661);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tbcMain);
            this.MinimumSize = new System.Drawing.Size(821, 700);
            this.Name = "mainForm";
            this.Text = "Killer App";
            this.pnPlayer.ResumeLayout(false);
            this.pnPlayer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMusic)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvImages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.tbcMain.ResumeLayout(false);
            this.tabMusic.ResumeLayout(false);
            this.tabImages.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnPlayer;
        private System.Windows.Forms.Label lbSongPlaying;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.ProgressBar pbSongProgress;
        private System.Windows.Forms.DataGridView dgvMusic;
        private System.Windows.Forms.Button btnMusic;
        private System.Windows.Forms.Button btnImages;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.DataGridView dgvImages;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.TabControl tbcMain;
        private System.Windows.Forms.TabPage tabMusic;
        private System.Windows.Forms.TabPage tabImages;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvImagesTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvImagesAspectRatio;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvImagesHeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvImagesWidth;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvImagesTags;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvImagesPath;
        private System.Windows.Forms.Timer tmMusicPlayer;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvMusicTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvMusicArtist;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvMusicLength;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvMusicAlbum;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvMusicGenre;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvMusicYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvMusicPath;
    }
}

