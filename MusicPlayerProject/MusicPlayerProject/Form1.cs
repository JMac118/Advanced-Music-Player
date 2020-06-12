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

namespace MusicPlayerProject
{
    public partial class Form1 : Form
    {
        BinarySearchTreeSong songList = new BinarySearchTreeSong();
        Song[] playList = new Song[20];
        int numSongs = 0;
        public Form1()
        {
            InitializeComponent();
            toolStripStatusLabel.Text = "Welcome";
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
                toolStripStatusLabel.Text = "not found";
            }
            else
            {
                toolStripStatusLabel.Text = "Found song: " + searchSong.getSongName();
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
                toolStripStatusLabel.Text = "Add a song using the 'Add a Song' menu item";
                
            }
        }

        private void PlaySong(int index)
        {
            try
            {
                Player.URL = playList[index].getUri();
            }
            catch(Exception f)
            {
                toolStripStatusLabel.Text = "Somthing went wrong\n" + f.Message;
            }
        }
    }
}
