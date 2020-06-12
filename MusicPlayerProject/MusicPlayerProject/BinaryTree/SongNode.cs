using MusicPlayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayerProject.BinaryTree
{
    class SongNode
    {
        Song songValue;
        SongNode left;
        SongNode right;

        public SongNode(Song song)
        {
            songValue = song;
        }

        internal SongNode Left { get => left; set => left = value; }
        internal SongNode Right { get => right; set => right = value; }

        internal Song GetSong()
        {
            return songValue;
        }

        public void Insert(Song song)
        {
            if (String.CompareOrdinal(songValue.getSongName(), song.getSongName()) > 0)
            {
                right.Insert(song);
            }
            else if (String.CompareOrdinal(songValue.getSongName(), song.getSongName()) < 0)
            {
                left.Insert(song);
            }
            else if (String.CompareOrdinal(songValue.getSongName(), song.getSongName()) == 0)
            {
                //Do nothing as its already in the tree
            }
        }

        public Song Search(string songName)
        {
            Song found = null;

            if ((String.CompareOrdinal(songValue.getSongName(), songName) > 0) && right != null)
            {
                found = right.Search(songName);
            }
            else if ((String.CompareOrdinal(songValue.getSongName(), songName) < 0) && left != null)
            {
                found = left.Search(songName);
            }
            else if (String.CompareOrdinal(songValue.getSongName(), songName) == 0)
            {
                found = songValue;
            }
            else
            {
                //not found in tree
            }

            return found;
        }


    }
}