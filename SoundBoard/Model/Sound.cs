using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoundBoard.Model
{
    public class Sound
    {
        public string Name { get ; set ; }
        public SoundCategory Category { get; set; }
        public string AudioFile { get; set; }
        public string ImageFile { get; set; }

        public Sound(string name, SoundCategory soundCategory)
        {
            Name = name;
            Category = soundCategory;
            AudioFile = string.Format("/assets/Audio/{1}/{0}.wav", name, soundCategory);
            ImageFile = string.Format("/assets/Images/{1}/{0}.png", name, soundCategory);
        }
    }

    public enum SoundCategory
    {
        Animals,
        Cartoons,
        Taunts,
        Warnings
    }
}
