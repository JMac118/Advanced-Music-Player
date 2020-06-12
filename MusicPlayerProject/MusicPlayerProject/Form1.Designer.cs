namespace MusicPlayerProject
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.profilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewSongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.savePlaylistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadPlaylistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortPlaylistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonToolStripSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBoxSearch = new System.Windows.Forms.ToolStripTextBox();
            this.createProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Player = new AxWMPLib.AxWindowsMediaPlayer();
            this.listBoxSongs = new System.Windows.Forms.ListBox();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
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
            this.toolStripTextBoxSearch,
            this.createProfileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(430, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.profilesToolStripMenuItem,
            this.addNewSongToolStripMenuItem,
            this.savePlaylistToolStripMenuItem,
            this.loadPlaylistToolStripMenuItem,
            this.sortPlaylistToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(50, 23);
            this.toolStripMenuItem1.Text = "Menu";
            // 
            // profilesToolStripMenuItem
            // 
            this.profilesToolStripMenuItem.Name = "profilesToolStripMenuItem";
            this.profilesToolStripMenuItem.Size = new System.Drawing.Size(271, 22);
            this.profilesToolStripMenuItem.Text = "Profiles";
            // 
            // addNewSongToolStripMenuItem
            // 
            this.addNewSongToolStripMenuItem.Name = "addNewSongToolStripMenuItem";
            this.addNewSongToolStripMenuItem.Size = new System.Drawing.Size(271, 22);
            this.addNewSongToolStripMenuItem.Text = "Add New Song";
            this.addNewSongToolStripMenuItem.Click += new System.EventHandler(this.addNewSongToolStripMenuItem_Click);
            // 
            // savePlaylistToolStripMenuItem
            // 
            this.savePlaylistToolStripMenuItem.Name = "savePlaylistToolStripMenuItem";
            this.savePlaylistToolStripMenuItem.Size = new System.Drawing.Size(271, 22);
            this.savePlaylistToolStripMenuItem.Text = "Save Playlist";
            // 
            // loadPlaylistToolStripMenuItem
            // 
            this.loadPlaylistToolStripMenuItem.Name = "loadPlaylistToolStripMenuItem";
            this.loadPlaylistToolStripMenuItem.Size = new System.Drawing.Size(271, 22);
            this.loadPlaylistToolStripMenuItem.Text = "Load Playlist";
            // 
            // sortPlaylistToolStripMenuItem
            // 
            this.sortPlaylistToolStripMenuItem.Name = "sortPlaylistToolStripMenuItem";
            this.sortPlaylistToolStripMenuItem.Size = new System.Drawing.Size(271, 22);
            this.sortPlaylistToolStripMenuItem.Text = "Sort Playlist (Alphabetical Ascending)";
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
            // createProfileToolStripMenuItem
            // 
            this.createProfileToolStripMenuItem.Name = "createProfileToolStripMenuItem";
            this.createProfileToolStripMenuItem.Size = new System.Drawing.Size(90, 23);
            this.createProfileToolStripMenuItem.Text = "Create Profile";
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
            this.listBoxSongs.Location = new System.Drawing.Point(12, 30);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 278);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.buttonPlay);
            this.Controls.Add(this.listBoxSongs);
            this.Controls.Add(this.Player);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "JMAC Music Player";
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
        private System.Windows.Forms.ToolStripMenuItem createProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem savePlaylistToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadPlaylistToolStripMenuItem;
        private AxWMPLib.AxWindowsMediaPlayer Player;
        private System.Windows.Forms.ToolStripMenuItem addNewSongToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sortPlaylistToolStripMenuItem;
        private System.Windows.Forms.ListBox listBoxSongs;
        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
    }
}

