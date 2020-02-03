using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UWPSoundBoard.Model
{
    public static class SoundManager
    {
        private static List<Sound> getSounds()
        {
            var sounds = new List<Sound>();
            sounds.Add(new Sound("Cow", SoundCategory.Animals));
            sounds.Add(new Sound("Cat", SoundCategory.Animals));

            sounds.Add(new Sound("Gun", SoundCategory.Catoons));
            sounds.Add(new Sound("Spring", SoundCategory.Catoons));

            sounds.Add(new Sound("Clock", SoundCategory.Tanuts));
            sounds.Add(new Sound("LOL", SoundCategory.Tanuts));

            sounds.Add(new Sound("Ship", SoundCategory.Warnings));
            sounds.Add(new Sound("Siren", SoundCategory.Warnings));

            return sounds;
        }
    }
}
