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

namespace MusicPlayerProject
{
    public partial class FormMusicPlayer : Form
    {
        public Form thisForm;
        UserRepository profiles = new UserRepository();
        static PasswordManager passwordManager = new PasswordManager();
        static string salt = null;
        static string passwordHash = passwordManager.GeneratePasswordHash("admin", out salt);
        User user = new User
        {
            UserId = "admin",
            PasswordHash = passwordHash,
            Salt = salt
        };

        BinarySearchTreeSong songList = new BinarySearchTreeSong();
        Song[] playList = new Song[20];
        int numSongs = 0;
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
        private void PrintArray()
        {
            //Console.WriteLine(playList[19].ToString());
            /*for(int i = 19; i > 0; i --)
            {
                if(playList[i] != null)
                {
                    Console.WriteLine(i + playList[i].ToString());
                }
            }*/
        }
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

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            if(numSongs > 0)
            {
                int index = listBoxSongs.SelectedIndex;
                if(index > -1)
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

        private void buttonStop_Click(object sender, EventArgs e)
        {
            Player.Ctlcontrols.stop();
        }

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
            if (e.newState == 1)
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

        private void saveProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FormNewProfile saveProfile = new FormNewProfile())
            {
                if (saveProfile.ShowDialog() == DialogResult.OK)
                {
                    User newUser = new User();
                    newUser.UserId = saveProfile.GetUsername();
                    newUser.PasswordHash = passwordManager.GeneratePasswordHash(saveProfile.GetUsername(), out salt);
                    profiles.AddUser(newUser);
                }
            }

            RefreshProfiles();
        }
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
                    }
                    else
                    {
                        //password failed
                    }
                }
            }

        }
    }
}
