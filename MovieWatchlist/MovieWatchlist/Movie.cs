using System;

namespace MovieWatchlist
{
    public class Movie
    {
        public string Title { get; set; }
        public string Genre { get; set; }
        public int Rating { get; set; } // 1-5 stars
        public DateTime WatchDate { get; set; }

        // Constructor to initialize movie object
        public Movie(string title, string genre, int rating, DateTime watchDate)
        {
            Title = title;
            Genre = genre;
            Rating = rating;
            WatchDate = watchDate;
        }

        // Override ToString for better debugging and list representation
        public override string ToString()
        {
            return $"{Title} ({Genre}) - {Rating}/5 Stars - Watched on {WatchDate.ToShortDateString()}";
        }
    }
}
