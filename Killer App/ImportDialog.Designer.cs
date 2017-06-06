namespace Killer_App {
    partial class ImportDialog {
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbFileCount = new System.Windows.Forms.Label();
            this.lb = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dgvMusic = new System.Windows.Forms.DataGridView();
            this.dgvMusicTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvMusicArtist = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvMusicLength = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvMusicAlbum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvMusicGenre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvMusicYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvMusicPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddFiles = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvImages = new System.Windows.Forms.DataGridView();
            this.dgvImagesPreview = new System.Windows.Forms.DataGridViewImageColumn();
            this.dgvImagesTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvImagesAspectRatio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvImagesHeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvImagesWidth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvImagesTags = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvImagesPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddFolders = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMusic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImages)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbFileCount);
            this.panel2.Controls.Add(this.lb);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Controls.Add(this.btnOk);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 695);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1024, 45);
            this.panel2.TabIndex = 2;
            // 
            // lbFileCount
            // 
            this.lbFileCount.AutoSize = true;
            this.lbFileCount.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFileCount.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbFileCount.Location = new System.Drawing.Point(63, 3);
            this.lbFileCount.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.lbFileCount.Name = "lbFileCount";
            this.lbFileCount.Size = new System.Drawing.Size(0, 12);
            this.lbFileCount.TabIndex = 21;
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lb.Location = new System.Drawing.Point(2, 3);
            this.lb.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(61, 12);
            this.lb.TabIndex = 20;
            this.lb.Text = "Importing:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(537, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(310, 12);
            this.label3.TabIndex = 17;
            this.label3.Text = "Edit your files and hit OK to add them to your collection";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancel.Location = new System.Drawing.Point(937, 5);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(83, 33);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnOk.FlatAppearance.BorderSize = 0;
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.ForeColor = System.Drawing.SystemColors.Control;
            this.btnOk.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnOk.Location = new System.Drawing.Point(850, 5);
            this.btnOk.Margin = new System.Windows.Forms.Padding(0);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(83, 33);
            this.btnOk.TabIndex = 17;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnAddFolders);
            this.splitContainer1.Panel1.Controls.Add(this.dgvMusic);
            this.splitContainer1.Panel1.Controls.Add(this.btnAddFiles);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvImages);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Size = new System.Drawing.Size(1024, 695);
            this.splitContainer1.SplitterDistance = 352;
            this.splitContainer1.TabIndex = 3;
            // 
            // dgvMusic
            // 
            this.dgvMusic.AllowUserToAddRows = false;
            this.dgvMusic.AllowUserToResizeRows = false;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvMusic.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle22;
            this.dgvMusic.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMusic.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle23;
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
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle24.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMusic.DefaultCellStyle = dataGridViewCellStyle24;
            this.dgvMusic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMusic.EnableHeadersVisualStyles = false;
            this.dgvMusic.Location = new System.Drawing.Point(0, 36);
            this.dgvMusic.Margin = new System.Windows.Forms.Padding(0);
            this.dgvMusic.Name = "dgvMusic";
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle25.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle25.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle25.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMusic.RowHeadersDefaultCellStyle = dataGridViewCellStyle25;
            this.dgvMusic.RowHeadersVisible = false;
            this.dgvMusic.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvMusic.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.dgvMusic.RowTemplate.Height = 30;
            this.dgvMusic.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvMusic.Size = new System.Drawing.Size(1024, 316);
            this.dgvMusic.TabIndex = 5;
            this.dgvMusic.SelectionChanged += new System.EventHandler(this.dgvMusic_SelectionChanged);
            // 
            // dgvMusicTitle
            // 
            this.dgvMusicTitle.HeaderText = "Title";
            this.dgvMusicTitle.Name = "dgvMusicTitle";
            this.dgvMusicTitle.Width = 300;
            // 
            // dgvMusicArtist
            // 
            this.dgvMusicArtist.HeaderText = "Artist";
            this.dgvMusicArtist.Name = "dgvMusicArtist";
            this.dgvMusicArtist.Width = 110;
            // 
            // dgvMusicLength
            // 
            this.dgvMusicLength.HeaderText = "Length";
            this.dgvMusicLength.Name = "dgvMusicLength";
            this.dgvMusicLength.ReadOnly = true;
            this.dgvMusicLength.Width = 55;
            // 
            // dgvMusicAlbum
            // 
            this.dgvMusicAlbum.HeaderText = "Album";
            this.dgvMusicAlbum.Name = "dgvMusicAlbum";
            this.dgvMusicAlbum.Width = 150;
            // 
            // dgvMusicGenre
            // 
            this.dgvMusicGenre.HeaderText = "Genre(s)";
            this.dgvMusicGenre.Name = "dgvMusicGenre";
            this.dgvMusicGenre.Width = 150;
            // 
            // dgvMusicYear
            // 
            this.dgvMusicYear.HeaderText = "Year";
            this.dgvMusicYear.Name = "dgvMusicYear";
            this.dgvMusicYear.Width = 50;
            // 
            // dgvMusicPath
            // 
            this.dgvMusicPath.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvMusicPath.HeaderText = "Path";
            this.dgvMusicPath.Name = "dgvMusicPath";
            this.dgvMusicPath.ReadOnly = true;
            // 
            // btnAddFiles
            // 
            this.btnAddFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddFiles.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnAddFiles.FlatAppearance.BorderSize = 0;
            this.btnAddFiles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddFiles.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFiles.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAddFiles.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAddFiles.Location = new System.Drawing.Point(915, 5);
            this.btnAddFiles.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddFiles.Name = "btnAddFiles";
            this.btnAddFiles.Size = new System.Drawing.Size(105, 33);
            this.btnAddFiles.TabIndex = 16;
            this.btnAddFiles.Text = "Add Files";
            this.btnAddFiles.UseVisualStyleBackColor = false;
            this.btnAddFiles.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1024, 36);
            this.label2.TabIndex = 4;
            this.label2.Text = "Music";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvImages
            // 
            this.dgvImages.AllowUserToAddRows = false;
            dataGridViewCellStyle26.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvImages.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle26;
            this.dgvImages.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle27.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle27.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvImages.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle27;
            this.dgvImages.ColumnHeadersHeight = 32;
            this.dgvImages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvImages.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvImagesPreview,
            this.dgvImagesTitle,
            this.dgvImagesAspectRatio,
            this.dgvImagesHeight,
            this.dgvImagesWidth,
            this.dgvImagesTags,
            this.dgvImagesPath});
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle28.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle28.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle28.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle28.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            dataGridViewCellStyle28.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle28.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle28.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvImages.DefaultCellStyle = dataGridViewCellStyle28;
            this.dgvImages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvImages.EnableHeadersVisualStyles = false;
            this.dgvImages.Location = new System.Drawing.Point(0, 36);
            this.dgvImages.Margin = new System.Windows.Forms.Padding(0);
            this.dgvImages.Name = "dgvImages";
            this.dgvImages.RowHeadersVisible = false;
            this.dgvImages.RowTemplate.Height = 30;
            this.dgvImages.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvImages.Size = new System.Drawing.Size(1024, 303);
            this.dgvImages.TabIndex = 3;
            this.dgvImages.SelectionChanged += new System.EventHandler(this.dgvImages_SelectionChanged);
            // 
            // dgvImagesPreview
            // 
            this.dgvImagesPreview.HeaderText = "";
            this.dgvImagesPreview.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dgvImagesPreview.Name = "dgvImagesPreview";
            this.dgvImagesPreview.ReadOnly = true;
            this.dgvImagesPreview.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvImagesPreview.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dgvImagesPreview.Width = 30;
            // 
            // dgvImagesTitle
            // 
            this.dgvImagesTitle.HeaderText = "Title";
            this.dgvImagesTitle.Name = "dgvImagesTitle";
            this.dgvImagesTitle.Width = 300;
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
            this.dgvImagesHeight.Width = 50;
            // 
            // dgvImagesWidth
            // 
            this.dgvImagesWidth.HeaderText = "Width";
            this.dgvImagesWidth.Name = "dgvImagesWidth";
            this.dgvImagesWidth.ReadOnly = true;
            this.dgvImagesWidth.Width = 50;
            // 
            // dgvImagesTags
            // 
            this.dgvImagesTags.HeaderText = "Tags";
            this.dgvImagesTags.Name = "dgvImagesTags";
            // 
            // dgvImagesPath
            // 
            this.dgvImagesPath.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvImagesPath.HeaderText = "Path";
            this.dgvImagesPath.Name = "dgvImagesPath";
            this.dgvImagesPath.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1024, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "Images";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnAddFolders
            // 
            this.btnAddFolders.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddFolders.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnAddFolders.FlatAppearance.BorderSize = 0;
            this.btnAddFolders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddFolders.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFolders.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAddFolders.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAddFolders.Location = new System.Drawing.Point(782, 5);
            this.btnAddFolders.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddFolders.Name = "btnAddFolders";
            this.btnAddFolders.Size = new System.Drawing.Size(130, 33);
            this.btnAddFolders.TabIndex = 17;
            this.btnAddFolders.Text = "Add Folders";
            this.btnAddFolders.UseVisualStyleBackColor = false;
            this.btnAddFolders.Click += new System.EventHandler(this.btnAddFolders_Click);
            // 
            // ImportDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1024, 740);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel2);
            this.Name = "ImportDialog";
            this.Text = "Import Files";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMusic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImages)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvMusic;
        private System.Windows.Forms.DataGridView dgvImages;
        private System.Windows.Forms.Button btnAddFiles;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.DataGridViewImageColumn dgvImagesPreview;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvImagesTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvImagesAspectRatio;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvImagesHeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvImagesWidth;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvImagesTags;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvImagesPath;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvMusicTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvMusicArtist;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvMusicLength;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvMusicAlbum;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvMusicGenre;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvMusicYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvMusicPath;
        private System.Windows.Forms.Label lbFileCount;
        private System.Windows.Forms.Button btnAddFolders;
    }
}