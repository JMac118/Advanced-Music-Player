using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using Security;
using MusicPlayer;

namespace IO
{
    class BinaryIO
    {
        public void BinaryWrite(string filename, Song[] arr, User user)
        {

            Stream stream = File.Open(filename, FileMode.Create);
            BinaryFormatter formatter = new BinaryFormatter();

            formatter.Serialize(stream, user);
            formatter.Serialize(stream, arr);
            stream.Close();

        }

        public Profile BinaryRead(string filename)
        {
            User user;
            Song[] arr;

            Stream stream = File.Open(filename, FileMode.Open);
            BinaryFormatter formatter = new BinaryFormatter();

            user = (User)formatter.Deserialize(stream);
            arr = (Song[])formatter.Deserialize(stream);
            stream.Close();

            Profile profile = new Profile(user, arr);

            return profile;
        }
    }
}
