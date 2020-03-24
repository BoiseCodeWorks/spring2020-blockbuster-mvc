namespace bb_mvc.Models
{
    class DVD : Video
    {
        public bool IsHD { get; set; }
        public DVD(string title, string rating, int runtime, bool hd) : base(title, rating, runtime)
        {
            IsHD = hd;
        }
    }
}