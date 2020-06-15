namespace MusicPlayerProject
{
    partial class FormMusicPlayer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMusicPlayer));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewSongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadPlaylistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortPlaylistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonToolStripSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBoxSearch = new System.Windows.Forms.ToolStripTextBox();
            this.Player = new AxWMPLib.AxWindowsMediaPlayer();
            this.listBoxSongs = new System.Windows.Forms.ListBox();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.buttonStop = new System.Windows.Forms.Button();
            this.exportPlaylistcsvToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importPlaylistcsvToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.buttonToolStripSearch,
            this.toolStripTextBoxSearch});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(430, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewSongToolStripMenuItem,
            this.saveProfileToolStripMenuItem,
            this.loadPlaylistToolStripMenuItem,
            this.sortPlaylistToolStripMenuItem,
            this.exportPlaylistcsvToolStripMenuItem,
            this.importPlaylistcsvToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(50, 23);
            this.toolStripMenuItem1.Text = "Menu";
            // 
            // addNewSongToolStripMenuItem
            // 
            this.addNewSongToolStripMenuItem.Name = "addNewSongToolStripMenuItem";
            this.addNewSongToolStripMenuItem.Size = new System.Drawing.Size(271, 22);
            this.addNewSongToolStripMenuItem.Text = "Add New Song";
            this.addNewSongToolStripMenuItem.Click += new System.EventHandler(this.addNewSongToolStripMenuItem_Click);
            // 
            // saveProfileToolStripMenuItem
            // 
            this.saveProfileToolStripMenuItem.Name = "saveProfileToolStripMenuItem";
            this.saveProfileToolStripMenuItem.Size = new System.Drawing.Size(271, 22);
            this.saveProfileToolStripMenuItem.Text = "Save Profile";
            this.saveProfileToolStripMenuItem.Click += new System.EventHandler(this.saveProfileToolStripMenuItem_Click);
            // 
            // loadPlaylistToolStripMenuItem
            // 
            this.loadPlaylistToolStripMenuItem.Name = "loadPlaylistToolStripMenuItem";
            this.loadPlaylistToolStripMenuItem.Size = new System.Drawing.Size(271, 22);
            this.loadPlaylistToolStripMenuItem.Text = "Load Profile";
            // 
            // sortPlaylistToolStripMenuItem
            // 
            this.sortPlaylistToolStripMenuItem.Name = "sortPlaylistToolStripMenuItem";
            this.sortPlaylistToolStripMenuItem.Size = new System.Drawing.Size(271, 22);
            this.sortPlaylistToolStripMenuItem.Text = "Sort Playlist (Alphabetical Ascending)";
            this.sortPlaylistToolStripMenuItem.Click += new System.EventHandler(this.sortPlaylistToolStripMenuItem_Click);
            // 
            // buttonToolStripSearch
            // 
            this.buttonToolStripSearch.Name = "buttonToolStripSearch";
            this.buttonToolStripSearch.Size = new System.Drawing.Size(140, 23);
            this.buttonToolStripSearch.Text = "Search Song in Playlist:";
            this.buttonToolStripSearch.Click += new System.EventHandler(this.buttonToolStripSearch_Click);
            // 
            // toolStripTextBoxSearch
            // 
            this.toolStripTextBoxSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBoxSearch.Name = "toolStripTextBoxSearch";
            this.toolStripTextBoxSearch.Size = new System.Drawing.Size(100, 23);
            // 
            // Player
            // 
            this.Player.Enabled = true;
            this.Player.Location = new System.Drawing.Point(12, 171);
            this.Player.Name = "Player";
            this.Player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Player.OcxState")));
            this.Player.Size = new System.Drawing.Size(406, 45);
            this.Player.TabIndex = 1;
            this.Player.Visible = false;
            // 
            // listBoxSongs
            // 
            this.listBoxSongs.FormattingEnabled = true;
            this.listBoxSongs.Location = new System.Drawing.Point(12, 31);
            this.listBoxSongs.Name = "listBoxSongs";
            this.listBoxSongs.Size = new System.Drawing.Size(406, 186);
            this.listBoxSongs.TabIndex = 3;
            // 
            // buttonPlay
            // 
            this.buttonPlay.Location = new System.Drawing.Point(13, 223);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(75, 23);
            this.buttonPlay.TabIndex = 4;
            this.buttonPlay.Text = "Play";
            this.buttonPlay.UseVisualStyleBackColor = true;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 256);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(430, 22);
            this.statusStrip.TabIndex = 5;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(57, 17);
            this.toolStripStatusLabel.Text = "Welcome";
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(95, 223);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(75, 23);
            this.buttonStop.TabIndex = 6;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // exportPlaylistcsvToolStripMenuItem
            // 
            this.exportPlaylistcsvToolStripMenuItem.Name = "exportPlaylistcsvToolStripMenuItem";
            this.exportPlaylistcsvToolStripMenuItem.Size = new System.Drawing.Size(271, 22);
            this.exportPlaylistcsvToolStripMenuItem.Text = "Export Playlist (.csv)";
            this.exportPlaylistcsvToolStripMenuItem.Click += new System.EventHandler(this.exportPlaylistcsvToolStripMenuItem_Click);
            // 
            // importPlaylistcsvToolStripMenuItem
            // 
            this.importPlaylistcsvToolStripMenuItem.Name = "importPlaylistcsvToolStripMenuItem";
            this.importPlaylistcsvToolStripMenuItem.Size = new System.Drawing.Size(271, 22);
            this.importPlaylistcsvToolStripMenuItem.Text = "Import Playlist (.csv)";
            this.importPlaylistcsvToolStripMenuItem.Click += new System.EventHandler(this.importPlaylistcsvToolStripMenuItem_Click);
            // 
            // FormMusicPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 278);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.buttonPlay);
            this.Controls.Add(this.listBoxSongs);
            this.Controls.Add(this.Player);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMusicPlayer";
            this.Text = "JMAC Music Player";
            this.Load += new System.EventHandler(this.FormMusicPlayer_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxSearch;
        private System.Windows.Forms.ToolStripMenuItem buttonToolStripSearch;
        private System.Windows.Forms.ToolStripMenuItem saveProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadPlaylistToolStripMenuItem;
        private AxWMPLib.AxWindowsMediaPlayer Player;
        private System.Windows.Forms.ToolStripMenuItem addNewSongToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sortPlaylistToolStripMenuItem;
        private System.Windows.Forms.ListBox listBoxSongs;
        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.ToolStripMenuItem exportPlaylistcsvToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importPlaylistcsvToolStripMenuItem;
    }
}

