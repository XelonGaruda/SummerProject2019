using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Game
    {
        public List<Track> Tracks { get; set; }
        public Game() => this.Tracks = new List<Track>();
        
    }
}
