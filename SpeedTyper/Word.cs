using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedTyper
{
    internal class Word
    {
        private List<string> _words = new List<string>()
        {
            "Christmas",
            "Ducks",
            "Mountain",
            "Galaxy",
            "Umbrella",
            "Penguin",
            "Whisper",
            "Candle",
            "Guitar",
            "Rainbow",
            "Elephant",
            "Chocolate",
            "Thunder",
            "Ocean",
            "Butterfly",
            "Adventure",
            "Volcano",
            "Sunflower",
            "Library",
            "Puzzle",
            "Treasure",
            "Journey",
            "Castle",
            "Starlight",
            "Dragon",
            "Midnight",
            "Pirate",
            "Festival",
            "Mystery",
            "Harmony",
            "Aurora"
        };

        public string GetWord()
        {
            Random random = new Random();
            int number = random.Next(0, _words.Count);

            return _words[number];
        }
    }
}
