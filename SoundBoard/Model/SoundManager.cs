using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoundBoard.Model
{
    public class SoundManager
    {
        public static void GetAllSounds(ObservableCollection<Sound> sounds)
        {
            sounds.Clear();
            getSounds().ForEach(p => sounds.Add(p));
        }
        
        public static void GetSoundsByCategory(ObservableCollection<Sound> sounds, SoundCategory soundCategory)
        {
            var filteredSounds = getSounds().Where(p => p.Category == soundCategory).ToList();
            sounds.Clear();
            filteredSounds.ForEach(p => sounds.Add(p));
        }

        private static List<Sound> getSounds()
        {
            var sounds = new List<Sound>
            {
                new Sound("Cow", SoundCategory.Animals),
                new Sound("Cat", SoundCategory.Animals),
                new Sound("Gun", SoundCategory.Cartoons),
                new Sound("Spring", SoundCategory.Cartoons),
                new Sound("Clock", SoundCategory.Taunts),
                new Sound("LOL", SoundCategory.Taunts),
                new Sound("Ship", SoundCategory.Warnings),
                new Sound("Siren", SoundCategory.Warnings)
            };

            return sounds;
        }
    }
}
