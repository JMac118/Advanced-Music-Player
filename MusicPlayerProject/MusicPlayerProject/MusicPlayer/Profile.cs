using MusicPlayer;
using Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer
{
    class Profile
    {
        User user;
        Song[] list;


        public Profile(User user, Song[] list)
        {
            this.user = user;
            this.list = list;
        }

        internal User User { get => user; set => user = value; }
        internal Song[] List { get => list; set => list = value; }
    }
}
