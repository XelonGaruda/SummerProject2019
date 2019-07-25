using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Track
    {
        public string Title { get; set; }
        public string Link { get; set; }
        public string Preview { get; set; }
        public List<Artist> Artists { get; set; }
        public string Picture { get; set; }

        public Track(string title, string link, string preview, string picture)
        {
            this.Title = title;
            this.Link = link;
            this.Preview = preview;
            this.Picture = picture;
            this.Artists = new List<Artist>();
        }
        public void AddArtist(int id, string name, string link, string picture) => Artists.Add(new Artist(id, name, link, picture));
        
    }
}
