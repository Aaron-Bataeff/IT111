using System;
using System.Collections.Generic;
using System.Linq;

namespace MovieWatchlist
{
    public class MovieManager
    {
        private List<Movie> movies;

        public MovieManager()
        {
            movies = new List<Movie>();
        }

        // Add a new movie to the list
        public void AddMovie(Movie movie)
        {
            if (movie != null)
            {
                movies.Add(movie);
            }
        }

        // Remove a movie by title
        public void RemoveMovie(string title)
        {
            var movieToRemove = movies.FirstOrDefault(m => m.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
            if (movieToRemove != null)
            {
                movies.Remove(movieToRemove);
            }
        }

        // Get all movies
        public List<Movie> GetMovies()
        {
            return movies;
        }

        // Search movies by title
        public List<Movie> SearchMovies(string title)
        {
            return movies.Where(m => m.Title.Contains(title, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        // Filter movies by genre
        public List<Movie> FilterByGenre(string genre)
        {
            return movies.Where(m => m.Genre.Equals(genre, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        // Filter movies by rating (e.g., show only 4-star and above movies)
        public List<Movie> FilterByRating(int minRating)
        {
            return movies.Where(m => m.Rating >= minRating).ToList();
        }

        // Sort movies by watch date (oldest to newest)
        public List<Movie> SortByDate()
        {
            return movies.OrderBy(m => m.WatchDate).ToList();
        }

        // Clear all movies (useful for resetting the list)
        public void ClearMovies()
        {
            movies.Clear();
        }
    }
}
