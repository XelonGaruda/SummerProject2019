namespace Summer2019.Models
{
    public class Artist
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Link { get; set; }
        public string Picture { get; set; }

        public Artist(int id, string name, string link, string picture)
        {
            this.Id = id;
            this.Name = name;
            this.Link = link;
            this.Picture = picture;
        }
    }
}