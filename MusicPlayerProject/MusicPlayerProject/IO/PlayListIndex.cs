using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MusicPlayer;

namespace MusicPlayerProject.IO
{
    class PlayListIndex : ClassMap<Song>
    {
        public PlayListIndex()
        {
            Map(m => m.SongName).Index(0).Name("songName");
            Map(m => m.Uri).Index(1).Name("uri");
        }
    }
}
