using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MovieWatchlist
{
    public partial class MainForm : Form
    {
        private MovieManager movieManager;
        private DataHandler dataHandler;
        private const string filePath = "Movies.json";

        public MainForm()
        {
            InitializeComponent();
            InitializeDataGridView(); // ✅ Ensure DataGridView columns are defined
            movieManager = new MovieManager();
            dataHandler = new DataHandler(filePath);
            UpdateMovieList();
        }

        private void InitializeDataGridView()
        {
            dgvMovies.ColumnCount = 4;
            dgvMovies.Columns[0].Name = "Title";
            dgvMovies.Columns[1].Name = "Genre";
            dgvMovies.Columns[2].Name = "Rating";
            dgvMovies.Columns[3].Name = "Watch Date";

            dgvMovies.Columns[2].Width = 60; // Adjust Rating column width
            dgvMovies.Columns[3].Width = 100; // Adjust Date column width
        }

        private void btnAddMovie_Click(object sender, EventArgs e)
        {
            string title = txtTitle.Text.Trim();
            string genre = cmbGenre.SelectedItem?.ToString();
            int rating = (int)numRating.Value;
            DateTime watchDate = dtpWatchDate.Value;

            if (string.IsNullOrEmpty(title) || string.IsNullOrEmpty(genre))
            {
                MessageBox.Show("Please enter a valid title and select a genre.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Movie newMovie = new Movie(title, genre, rating, watchDate);
            movieManager.AddMovie(newMovie);
            UpdateMovieList();
            ClearInputFields();
        }

        private void btnRemoveMovie_Click(object sender, EventArgs e)
        {
            if (dgvMovies.SelectedRows.Count > 0)
            {
                string title = dgvMovies.SelectedRows[0].Cells[0].Value.ToString();
                movieManager.RemoveMovie(title);
                UpdateMovieList();
            }
            else
            {
                MessageBox.Show("Please select a movie to remove.", "Remove Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            dataHandler.SaveMovies(movieManager.GetMovies());
            MessageBox.Show("Movies saved successfully.", "Save Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            List<Movie> loadedMovies = dataHandler.LoadMovies();
            if (loadedMovies != null)
            {
                movieManager = new MovieManager();
                foreach (var movie in loadedMovies)
                {
                    movieManager.AddMovie(movie);
                }
                UpdateMovieList();
            }
            else
            {
                MessageBox.Show("No saved movies found.", "Load Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void UpdateMovieList()
        {
            dgvMovies.Rows.Clear();
            foreach (var movie in movieManager.GetMovies())
            {
                dgvMovies.Rows.Add(movie.Title, movie.Genre, movie.Rating, movie.WatchDate.ToShortDateString());
            }
        }

        private void ClearInputFields()
        {
            txtTitle.Clear();
            cmbGenre.SelectedIndex = -1;
            numRating.Value = 1;
            dtpWatchDate.Value = DateTime.Now;
        }
    }
}
