using MusicPlayer;
using MusicPlayerProject.BinaryTree;
using System;
using System.Windows.Forms;

namespace BinaryTree
{
    class BinarySearchTreeSong
    {
        SongNode root;

        public BinarySearchTreeSong()
        {
            root = null;
        }

        public void Insert(Song song)
        {
            //string str = root.Left.GetSong().getSongName();
            //string str2 = song.getSongName();
            if (root == null)
            {
                root = new SongNode(song);
            }
            else
            {
                root.Insert(song);
            }
        }

        public Song Search(string songName)
        {
            Song found = null;
            if(root != null)
            {
                if(root.GetSong().getSongName().Equals(songName))
                {
                    found = root.GetSong();
                }
                else
                {
                    found = root.Search(songName);
                }
            }

            return found;
        }
    }
}


// if(String.CompareOrdinal(root.Left.GetSong().getSongName(), song.getSongName())>0)