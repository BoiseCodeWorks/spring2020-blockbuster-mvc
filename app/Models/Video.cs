namespace bb_mvc.Models
{
    class Video
    {
        public Video(string title, string rating, int runtime)
        {
            Title = title;
            Rating = rating;
            Runtime = runtime;
            IsAvailable = true;
        }

        public string Title { get; set; }
        public string Rating { get; set; }
        public int Runtime { get; set; }
        public bool IsAvailable { get; set; }
    }
}