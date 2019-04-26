namespace MusicPlaylistAnalyzer
{
    internal class Data
    {
        public Data(string name, string artist, string album, string genre, int size, int time, int year, int plays)
        {
            this.name = name;
            this.artist = artist;
            this.album = album;
            this.genre = genre;
            this.size = size;
            this.time = time;
            this.year = year;
            this.plays = plays;
        }

        public string name
        {
            get;
            set;
        }
        public string artist
        {
            get;
            set;
        }
        public string album
        {
            get;
            set;
        }
        public string genre
        {
            get;
            set;
        }

        public int size
        {
            get;
            set;
        }
        public int time
        {
            get;
            set;
        }
        public int year
        {
            get;
            set;
        }
        public int plays
        {
            get;
            set;
        }
    }
}