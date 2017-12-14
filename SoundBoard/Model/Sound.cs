using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoundBoard.Model
{
    class Sound
    {
        private string name;
        private SoundCategory category;
        private string audioFile;
        private string imageFile;

        public string Name { get => name; set => name = value; }
        public SoundCategory Category { get => category; set => category = value; }
        public string AudioFile { get => audioFile; set => audioFile = value; }
        public string ImageFile { get => imageFile; set => imageFile = value; }

        public Sound(string name)
        {
        }
    }

    public class SoundCategory
    {
    }
}
