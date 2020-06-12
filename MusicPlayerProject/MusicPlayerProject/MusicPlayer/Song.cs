using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer
{
    //Container class for songs to easily hold the songs name as well as the songs URI
    //for easier display.
    class Song
    {
        private string songName = "";
        private string uri = "";

        public Song(string songName, string uri)
        {
            this.songName = songName;
            this.uri = uri;
        }

        public string getSongName()
        {
            return songName;
        }

        public string getUri()
        {
            return uri;
        }
    }
}
