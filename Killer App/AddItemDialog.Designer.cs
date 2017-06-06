namespace Killer_App {
    partial class AddItemDialog {
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
            this.tbcType = new System.Windows.Forms.TabControl();
            this.tpSong = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.tbSongTags = new System.Windows.Forms.TextBox();
            this.tbGenres = new System.Windows.Forms.TextBox();
            this.tbArtists = new System.Windows.Forms.TextBox();
            this.cbbArtists = new System.Windows.Forms.ComboBox();
            this.cbbSongTags = new System.Windows.Forms.ComboBox();
            this.cbbGenres = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSong = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbAlbum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbDuration = new System.Windows.Forms.TextBox();
            this.tbSongPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbSongTitle = new System.Windows.Forms.TextBox();
            this.tpImage = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.tbImagePath = new System.Windows.Forms.TextBox();
            this.tbAspect = new System.Windows.Forms.TextBox();
            this.pbPreview = new System.Windows.Forms.PictureBox();
            this.tbImageTags = new System.Windows.Forms.TextBox();
            this.cbbImageTags = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSelectImage = new System.Windows.Forms.Button();
            this.tbWidth = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tbHeight = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tbImageTitle = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tbcType.SuspendLayout();
            this.tpSong.SuspendLayout();
            this.tpImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // tbcType
            // 
            this.tbcType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbcType.Controls.Add(this.tpSong);
            this.tbcType.Controls.Add(this.tpImage);
            this.tbcType.Location = new System.Drawing.Point(0, 0);
            this.tbcType.Margin = new System.Windows.Forms.Padding(0);
            this.tbcType.Name = "tbcType";
            this.tbcType.SelectedIndex = 0;
            this.tbcType.Size = new System.Drawing.Size(451, 246);
            this.tbcType.TabIndex = 0;
            // 
            // tpSong
            // 
            this.tpSong.Controls.Add(this.label10);
            this.tpSong.Controls.Add(this.tbSongTags);
            this.tpSong.Controls.Add(this.tbGenres);
            this.tpSong.Controls.Add(this.tbArtists);
            this.tpSong.Controls.Add(this.cbbArtists);
            this.tpSong.Controls.Add(this.cbbSongTags);
            this.tpSong.Controls.Add(this.cbbGenres);
            this.tpSong.Controls.Add(this.label7);
            this.tpSong.Controls.Add(this.label6);
            this.tpSong.Controls.Add(this.btnSong);
            this.tpSong.Controls.Add(this.label5);
            this.tpSong.Controls.Add(this.label4);
            this.tpSong.Controls.Add(this.tbAlbum);
            this.tpSong.Controls.Add(this.label3);
            this.tpSong.Controls.Add(this.tbDuration);
            this.tpSong.Controls.Add(this.tbSongPath);
            this.tpSong.Controls.Add(this.label1);
            this.tpSong.Controls.Add(this.tbSongTitle);
            this.tpSong.Location = new System.Drawing.Point(4, 22);
            this.tpSong.Name = "tpSong";
            this.tpSong.Padding = new System.Windows.Forms.Padding(3);
            this.tpSong.Size = new System.Drawing.Size(443, 220);
            this.tpSong.TabIndex = 0;
            this.tpSong.Text = "Song";
            this.tpSong.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label10.Location = new System.Drawing.Point(187, 123);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(246, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Add manually seperated by commas if not yet listed";
            // 
            // tbSongTags
            // 
            this.tbSongTags.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSongTags.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tbSongTags.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbSongTags.Location = new System.Drawing.Point(186, 192);
            this.tbSongTags.Name = "tbSongTags";
            this.tbSongTags.Size = new System.Drawing.Size(247, 20);
            this.tbSongTags.TabIndex = 19;
            // 
            // tbGenres
            // 
            this.tbGenres.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbGenres.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tbGenres.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbGenres.Location = new System.Drawing.Point(186, 165);
            this.tbGenres.Name = "tbGenres";
            this.tbGenres.Size = new System.Drawing.Size(247, 20);
            this.tbGenres.TabIndex = 18;
            // 
            // tbArtists
            // 
            this.tbArtists.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbArtists.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tbArtists.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbArtists.Location = new System.Drawing.Point(186, 139);
            this.tbArtists.Name = "tbArtists";
            this.tbArtists.Size = new System.Drawing.Size(247, 20);
            this.tbArtists.TabIndex = 17;
            // 
            // cbbArtists
            // 
            this.cbbArtists.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbArtists.FormattingEnabled = true;
            this.cbbArtists.Location = new System.Drawing.Point(61, 139);
            this.cbbArtists.Name = "cbbArtists";
            this.cbbArtists.Size = new System.Drawing.Size(119, 21);
            this.cbbArtists.TabIndex = 16;
            this.cbbArtists.SelectedIndexChanged += new System.EventHandler(this.cbbArtists_SelectedIndexChanged);
            // 
            // cbbSongTags
            // 
            this.cbbSongTags.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSongTags.FormattingEnabled = true;
            this.cbbSongTags.Location = new System.Drawing.Point(61, 192);
            this.cbbSongTags.Name = "cbbSongTags";
            this.cbbSongTags.Size = new System.Drawing.Size(119, 21);
            this.cbbSongTags.TabIndex = 15;
            this.cbbSongTags.SelectedIndexChanged += new System.EventHandler(this.cbbSongTags_SelectedIndexChanged);
            // 
            // cbbGenres
            // 
            this.cbbGenres.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbGenres.FormattingEnabled = true;
            this.cbbGenres.Location = new System.Drawing.Point(61, 165);
            this.cbbGenres.Name = "cbbGenres";
            this.cbbGenres.Size = new System.Drawing.Size(119, 21);
            this.cbbGenres.TabIndex = 14;
            this.cbbGenres.SelectedIndexChanged += new System.EventHandler(this.cbbGenres_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Tags";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Genres";
            // 
            // btnSong
            // 
            this.btnSong.Location = new System.Drawing.Point(8, 6);
            this.btnSong.Name = "btnSong";
            this.btnSong.Size = new System.Drawing.Size(86, 23);
            this.btnSong.TabIndex = 10;
            this.btnSong.Text = "Select File";
            this.btnSong.UseVisualStyleBackColor = true;
            this.btnSong.Click += new System.EventHandler(this.btnSong_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Artists";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Album";
            // 
            // tbAlbum
            // 
            this.tbAlbum.Location = new System.Drawing.Point(61, 61);
            this.tbAlbum.Name = "tbAlbum";
            this.tbAlbum.Size = new System.Drawing.Size(372, 20);
            this.tbAlbum.TabIndex = 6;
            this.tbAlbum.TextChanged += new System.EventHandler(this.tbAlbum_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Duration";
            // 
            // tbDuration
            // 
            this.tbDuration.Location = new System.Drawing.Point(61, 87);
            this.tbDuration.Name = "tbDuration";
            this.tbDuration.ReadOnly = true;
            this.tbDuration.Size = new System.Drawing.Size(68, 20);
            this.tbDuration.TabIndex = 4;
            this.tbDuration.TextChanged += new System.EventHandler(this.tbDuration_TextChanged);
            // 
            // tbSongPath
            // 
            this.tbSongPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSongPath.Location = new System.Drawing.Point(100, 8);
            this.tbSongPath.Name = "tbSongPath";
            this.tbSongPath.ReadOnly = true;
            this.tbSongPath.Size = new System.Drawing.Size(333, 20);
            this.tbSongPath.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Title";
            // 
            // tbSongTitle
            // 
            this.tbSongTitle.Location = new System.Drawing.Point(61, 35);
            this.tbSongTitle.Name = "tbSongTitle";
            this.tbSongTitle.Size = new System.Drawing.Size(372, 20);
            this.tbSongTitle.TabIndex = 0;
            this.tbSongTitle.TextChanged += new System.EventHandler(this.tbSongTitle_TextChanged);
            // 
            // tpImage
            // 
            this.tpImage.Controls.Add(this.label11);
            this.tpImage.Controls.Add(this.tbImagePath);
            this.tpImage.Controls.Add(this.tbAspect);
            this.tpImage.Controls.Add(this.pbPreview);
            this.tpImage.Controls.Add(this.tbImageTags);
            this.tpImage.Controls.Add(this.cbbImageTags);
            this.tpImage.Controls.Add(this.label8);
            this.tpImage.Controls.Add(this.btnSelectImage);
            this.tpImage.Controls.Add(this.tbWidth);
            this.tpImage.Controls.Add(this.label13);
            this.tpImage.Controls.Add(this.tbHeight);
            this.tpImage.Controls.Add(this.label15);
            this.tpImage.Controls.Add(this.tbImageTitle);
            this.tpImage.Location = new System.Drawing.Point(4, 22);
            this.tpImage.Margin = new System.Windows.Forms.Padding(0);
            this.tpImage.Name = "tpImage";
            this.tpImage.Padding = new System.Windows.Forms.Padding(3);
            this.tpImage.Size = new System.Drawing.Size(443, 220);
            this.tpImage.TabIndex = 1;
            this.tpImage.Text = "Image";
            this.tpImage.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 116);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 13);
            this.label11.TabIndex = 43;
            this.label11.Text = "Aspect Ratio";
            // 
            // tbImagePath
            // 
            this.tbImagePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbImagePath.Location = new System.Drawing.Point(100, 8);
            this.tbImagePath.Name = "tbImagePath";
            this.tbImagePath.ReadOnly = true;
            this.tbImagePath.Size = new System.Drawing.Size(337, 20);
            this.tbImagePath.TabIndex = 41;
            this.tbImagePath.TabStop = false;
            // 
            // tbAspect
            // 
            this.tbAspect.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbAspect.Location = new System.Drawing.Point(91, 113);
            this.tbAspect.Name = "tbAspect";
            this.tbAspect.ReadOnly = true;
            this.tbAspect.Size = new System.Drawing.Size(137, 20);
            this.tbAspect.TabIndex = 40;
            this.tbAspect.TabStop = false;
            // 
            // pbPreview
            // 
            this.pbPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbPreview.BackColor = System.Drawing.SystemColors.MenuBar;
            this.pbPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbPreview.Location = new System.Drawing.Point(234, 35);
            this.pbPreview.Name = "pbPreview";
            this.pbPreview.Size = new System.Drawing.Size(203, 177);
            this.pbPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPreview.TabIndex = 39;
            this.pbPreview.TabStop = false;
            // 
            // tbImageTags
            // 
            this.tbImageTags.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tbImageTags.Location = new System.Drawing.Point(91, 192);
            this.tbImageTags.Name = "tbImageTags";
            this.tbImageTags.Size = new System.Drawing.Size(137, 20);
            this.tbImageTags.TabIndex = 38;
            // 
            // cbbImageTags
            // 
            this.cbbImageTags.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbImageTags.FormattingEnabled = true;
            this.cbbImageTags.Location = new System.Drawing.Point(91, 165);
            this.cbbImageTags.Name = "cbbImageTags";
            this.cbbImageTags.Size = new System.Drawing.Size(137, 21);
            this.cbbImageTags.TabIndex = 34;
            this.cbbImageTags.SelectedIndexChanged += new System.EventHandler(this.cbbImageTags_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 168);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 32;
            this.label8.Text = "Tags";
            // 
            // btnSelectImage
            // 
            this.btnSelectImage.Location = new System.Drawing.Point(8, 6);
            this.btnSelectImage.Name = "btnSelectImage";
            this.btnSelectImage.Size = new System.Drawing.Size(86, 23);
            this.btnSelectImage.TabIndex = 29;
            this.btnSelectImage.Text = "Select File";
            this.btnSelectImage.UseVisualStyleBackColor = true;
            this.btnSelectImage.Click += new System.EventHandler(this.btnSelectImage_Click);
            // 
            // tbWidth
            // 
            this.tbWidth.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbWidth.Location = new System.Drawing.Point(162, 87);
            this.tbWidth.Name = "tbWidth";
            this.tbWidth.ReadOnly = true;
            this.tbWidth.Size = new System.Drawing.Size(66, 20);
            this.tbWidth.TabIndex = 26;
            this.tbWidth.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(8, 90);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(77, 13);
            this.label13.TabIndex = 25;
            this.label13.Text = "Height / Width";
            // 
            // tbHeight
            // 
            this.tbHeight.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbHeight.Location = new System.Drawing.Point(91, 87);
            this.tbHeight.Name = "tbHeight";
            this.tbHeight.ReadOnly = true;
            this.tbHeight.Size = new System.Drawing.Size(66, 20);
            this.tbHeight.TabIndex = 24;
            this.tbHeight.TabStop = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(8, 38);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(27, 13);
            this.label15.TabIndex = 21;
            this.label15.Text = "Title";
            // 
            // tbImageTitle
            // 
            this.tbImageTitle.Location = new System.Drawing.Point(91, 35);
            this.tbImageTitle.Name = "tbImageTitle";
            this.tbImageTitle.Size = new System.Drawing.Size(137, 20);
            this.tbImageTitle.TabIndex = 20;
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(281, 249);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(362, 249);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // AddItemDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 284);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.tbcType);
            this.Name = "AddItemDialog";
            this.Text = "Add Item";
            this.tbcType.ResumeLayout(false);
            this.tpSong.ResumeLayout(false);
            this.tpSong.PerformLayout();
            this.tpImage.ResumeLayout(false);
            this.tpImage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPreview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcType;
        private System.Windows.Forms.TabPage tpSong;
        private System.Windows.Forms.TabPage tpImage;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbAlbum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbDuration;
        private System.Windows.Forms.TextBox tbSongPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSongTitle;
        private System.Windows.Forms.Button btnSong;
        private System.Windows.Forms.TextBox tbSongTags;
        private System.Windows.Forms.TextBox tbGenres;
        private System.Windows.Forms.TextBox tbArtists;
        private System.Windows.Forms.ComboBox cbbArtists;
        private System.Windows.Forms.ComboBox cbbSongTags;
        private System.Windows.Forms.ComboBox cbbGenres;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbImageTags;
        private System.Windows.Forms.ComboBox cbbImageTags;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSelectImage;
        private System.Windows.Forms.TextBox tbWidth;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbHeight;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tbImageTitle;
        private System.Windows.Forms.PictureBox pbPreview;
        private System.Windows.Forms.TextBox tbImagePath;
        private System.Windows.Forms.TextBox tbAspect;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}