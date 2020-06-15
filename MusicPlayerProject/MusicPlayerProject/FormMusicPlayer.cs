/*
 * Programmed by Joshua Macaulay
 * 30008704
 */

using MusicPlayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BinaryTree;
using Sort;
using Security;
using System.IO;
using CsvHelper;
using System.Globalization;
using IO;

namespace MusicPlayerProject
{
    public partial class FormMusicPlayer : Form
    {
        public Form thisForm;
        UserRepository profiles = new UserRepository();
        static PasswordManager passwordManager = new PasswordManager();
        string salt = null;

        BinarySearchTreeSong songList = new BinarySearchTreeSong();
        Song[] playList = new Song[20];
        int numSongs = 0;
        bool stopped = true;
        public FormMusicPlayer()
        {
            InitializeComponent();
            toolStripStatusLabel.Text = "Welcome";
            Player.PlayStateChange += (sender, eventArgs) => Player_PlayStateChange(sender, eventArgs);
            thisForm = System.Windows.Forms.Form.ActiveForm;
        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addNewSongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Opens file dialog for browse menu
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.ShowDialog();

            string uri = fileDialog.FileName;
            string fileName = fileDialog.SafeFileName;

            //Create new song object
            Song newSong = new Song(fileName, uri);

            //add to tree
            songList.Insert(newSong);

            //add to playList
            AddPlayListSong(newSong);

            //refresh displayed playlist
            RefreshList();
        }

        //adds a song to the playlist
        private void AddPlayListSong(Song newSong)
        {
            if (numSongs < playList.Length)
            {
                for (int i = 0; i < playList.Length; i++)
                {
                    if (playList[i] == null)
                    {
                        playList[i] = newSong;
                        numSongs++;
                        break;
                    }
                }
            }
            else
            {
                toolStripStatusLabel.Text = "Playlist is full";
            }
        }
        //refreshes the listbox with the contents of playlist
        private void RefreshList()
        {
            listBoxSongs.Items.Clear();

            for (int i = 0; i < playList.Length; i++)
            {
                if (playList[i] != null)
                {
                    listBoxSongs.Items.Add(playList[i].getSongName());
                }
            }
        }

        //search bar function, searches the binary tree for the song and plays it if it exists
        private void buttonToolStripSearch_Click(object sender, EventArgs e)
        {
            Song searchSong = songList.Search(toolStripTextBoxSearch.Text);

            if (searchSong == null)
            {
                toolStripStatusLabel.Text = "Song: " + toolStripTextBoxSearch.Text + "not found";
                
            }
            else
            {
                toolStripStatusLabel.Text = "Found song: " + searchSong.getSongName();
                try
                {
                    Player.URL = searchSong.getUri();
                }
                catch (Exception f)
                {
                    toolStripStatusLabel.Text = "Something went wrong\n" + f.Message;
                }
            }
        }

        //button method for playing selected song or the first song in list
        private void buttonPlay_Click(object sender, EventArgs e)
        {
            if(numSongs > 0)
            {
                stopped = false;
                int index = listBoxSongs.SelectedIndex;
                if((index > -1) && (index <= numSongs))
                {
                    PlaySong(index);
                }
                else
                {
                    listBoxSongs.SelectedIndex = 0;
                    PlaySong(0);
                }
            }
            else
            {
                toolStripStatusLabel.Text = "Add a song using the 'Add new Song' menu item";
                
            }
        }

        //function to play a song based on its index position in the list
        private void PlaySong(int index)
        {
            try
            {
                Player.URL = playList[index].getUri();
                toolStripStatusLabel.Text = "Currently playing: " + playList[index].getSongName();
            }
            catch(Exception f)
            {
                toolStripStatusLabel.Text = "Something went wrong\n" + f.Message;
            }
        }

        //simple button method to stop the music
        private void buttonStop_Click(object sender, EventArgs e)
        {
            stopped = true;
            Player.Ctlcontrols.stop();
            toolStripStatusLabel.Text = "Music has been stopped";
        }

        //toolstrip button method to merge sort the playlist
        private void sortPlaylistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SongSort sorter = new SongSort();

            Song[] temp = new Song[numSongs];

            for(int i = 0; i < numSongs; i++)
            {
                temp[i] = playList[i];
            }

            temp = sorter.MergeSortSong(temp);

            for(int i = 0; i < numSongs; i++)
            {
                playList[i] = temp[i];
            }

            RefreshList();
        }

        //Code snippet for play next song taken from stack overflow
        //https://stackoverflow.com/questions/19671308/c-sharp-media-player-wmp-automatic-next-song
        //Mohamad Hedayati
        private void Player_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (e.newState == 1 && stopped == false)
            {
                if (listBoxSongs.SelectedIndex != listBoxSongs.Items.Count - 1)
                {
                    BeginInvoke(new Action(() =>
                    {
                        listBoxSongs.SelectedIndex = listBoxSongs.SelectedIndex + 1;
                        PlaySong(listBoxSongs.SelectedIndex);
                    }));
                }
            }
        }

        //toolstrip button to create a new profile
        private void saveProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FormNewProfile saveProfile = new FormNewProfile())
            {
                if (saveProfile.ShowDialog() == DialogResult.OK)
                {
                    User newUser = new User();
                    newUser.UserId = saveProfile.GetUsername();
                    newUser.PasswordHash = passwordManager.GeneratePasswordHash(saveProfile.GetPassword(), out salt);
                    newUser.Salt = salt;
                    profiles.AddUser(newUser);

                    WriteProfileToFile(newUser.UserId);
                }
            }

            RefreshProfiles();
        }

        //function that writes the user and playlist to a binary file
        private void WriteProfileToFile(string profileName)
        {
            string filename = profileName + ".bin";
            BinaryIO io = new BinaryIO();
            io.BinaryWrite(filename, playList, profiles.GetUser(profileName));
        }
        //function that reads a user and playlist from a binary file
        private void ReadProfileFromFile(string profileName)
        {
            string filename = profileName + ".bin";
            BinaryIO io = new BinaryIO();
            Profile profile = io.BinaryRead(filename);
            
            playList = profile.List;
            numSongs = playList.Length;

            FillBinaryTree();

            RefreshList();
        }

        //function to refresh the toolstrip menu items for profiles
        private void RefreshProfiles()
        {
            string[] arr = profiles.GetAllUserNames();
            for(int i = 0; i < arr.Length; i++)
            {
                ToolStripMenuItem newStrip = new ToolStripMenuItem(arr[i]);
                newStrip.Click += (sender, eventArgs) => LoadProfile(sender, eventArgs);

                loadPlaylistToolStripMenuItem.DropDownItems.Add(newStrip);

            }
            
        }

        //toolstrip menu button to load a profile
        private void LoadProfile(object sender, EventArgs e)
        {
            ToolStripMenuItem strip = (ToolStripMenuItem)sender;
            
            using (FormLoadProfile loadProfile = new FormLoadProfile(strip.Text))
            {
                if(loadProfile.ShowDialog() == DialogResult.OK)
                {
                    User user = profiles.GetUser(strip.Text);

                    bool result = passwordManager.IsPasswordMatch(loadProfile.GetPassword(), user.Salt, user.PasswordHash);
                    if(result == true)
                    {
                        //load profile playlist
                        MessageBox.Show("Confirmed profile: " + strip.Text);

                        ReadProfileFromFile(strip.Text);

                        toolStripStatusLabel.Text = "Welcome " + strip.Text;

                    }
                    else
                    {
                        //password failed
                        MessageBox.Show("Password failed for profile: " + strip.Text);
                    }
                }
            }

        }

        //toolstrip menu item to save a playlist to a csv file using CsvHelper
        private void exportPlaylistcsvToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.DefaultExt = ".csv";
            save.ShowDialog();


            using (var writer = new StreamWriter(save.FileName))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(playList);
            }
        }

        //toolstrip menu item to load a playlist from a csv file using CsvHelper
        private void importPlaylistcsvToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog load = new OpenFileDialog();
            load.DefaultExt = ".csv";
            load.ShowDialog();

            using (var reader = new StreamReader(load.FileName))
            {
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    csv.Configuration.PrepareHeaderForMatch = (string header, int index) => header.ToLower();
                    var records = csv.GetRecords<Song>();

                    var arr = records.ToArray();

                    numSongs = 0;
                    for (int i = 0; i < arr.Length; i++)
                    {
                        try
                        {
                            if (arr[i].getUri() != null && !arr[i].getUri().Equals(""))
                            {
                                playList[i] = arr[i];
                                numSongs++;
                            }
                        }
                        catch(Exception f)
                        {
                            //Caught empty song
                        }
                    }

                    FillBinaryTree();
                    RefreshList();
                }
            }

        }

        //Load method, once form it initially loaded, will scan directory for .bin files to load into profiles
        private void FormMusicPlayer_Load(object sender, EventArgs e)
        {
            string[] files = System.IO.Directory.GetFiles(Directory.GetCurrentDirectory(), "*.bin");

            for(int i = 0; i < files.Length; i++)
            {
                BinaryIO io = new BinaryIO();
                Profile profile = io.BinaryRead(files[i]);
                profiles.AddUser(profile.User);
                RefreshProfiles();
            }
        }

        //function to refill the binary tree with contents of playlist
        private void FillBinaryTree()
        {
            songList = new BinarySearchTreeSong();

            for(int i = 0; i < numSongs; i++)
            {
                if (playList[i] != null)
                {
                    songList.Insert(playList[i]);
                }
            }
        }
    }
}

