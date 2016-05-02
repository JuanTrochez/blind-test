using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlindTest
{
    public class Musique
    {
        private readonly string path = "C:\\Users\\userinsta\\Music\\MusicBlindTest";
        private List<String> listMusic = new List<String>();
        private int onPlay;

        public Musique()
        {
            fillListMusic(ListMusic);
        }

        public void fillListMusic(List<String> listeMusic)
        {
            DirectoryInfo directory = new DirectoryInfo(Path);
            FileInfo[] Files = directory.GetFiles("*.mp3");
            foreach (FileInfo file in Files)
            {
                ListMusic.Add(file.Name);
                if (ListMusic.Count > 100)
                    break;
            }
        }

        public List<string> ListMusic
        {
            get
            {
                return listMusic;
            }

            set
            {
                listMusic = value;
            }
        }

        public string Path
        {
            get
            {
                return path;
            }
        }

        public int OnPlay
        {
            get
            {
                return onPlay;
            }

            set
            {
                onPlay = value;
            }
        }
    }
}
