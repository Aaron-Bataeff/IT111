using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using Newtonsoft.Json;

namespace MovieWatchlist
{
    public class DataHandler
    {
        private string filePath;

        public DataHandler(string path)
        {
            filePath = path;
        }

        // Save movies to a JSON file
        public void SaveMovies(List<Movie> movies)
        {
            try
            {
                string jsonData = JsonConvert.SerializeObject(movies, Newtonsoft.Json.Formatting.Indented);
                File.WriteAllText(filePath, jsonData);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error saving movies: " + ex.Message);
            }
        }

        // Load movies from a JSON file
        public List<Movie> LoadMovies()
        {
            try
            {
                if (File.Exists(filePath))
                {
                    string jsonData = File.ReadAllText(filePath);
                    return JsonConvert.DeserializeObject<List<Movie>>(jsonData) ?? new List<Movie>();
                }
                return new List<Movie>();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error loading movies: " + ex.Message);
                return new List<Movie>();
            }
        }
    }
}
