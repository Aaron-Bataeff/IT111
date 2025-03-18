namespace MovieWatchlist
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Text = "Movie Watchlist";
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

            this.lblTitle = new System.Windows.Forms.Label();
            this.lblTitle.Text = "Movie Title:";
            this.lblTitle.Location = new System.Drawing.Point(20, 20);

            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtTitle.Location = new System.Drawing.Point(120, 20);
            this.txtTitle.Size = new System.Drawing.Size(200, 22);

            this.lblGenre = new System.Windows.Forms.Label();
            this.lblGenre.Text = "Genre:";
            this.lblGenre.Location = new System.Drawing.Point(20, 60);

            this.cmbGenre = new System.Windows.Forms.ComboBox();
            this.cmbGenre.Location = new System.Drawing.Point(120, 60);
            this.cmbGenre.Size = new System.Drawing.Size(150, 22);
            this.cmbGenre.Items.AddRange(new string[] { "Action", "Comedy", "Drama", "Horror", "Sci-Fi", "Romance", "Thriller" });

            this.lblRating = new System.Windows.Forms.Label();
            this.lblRating.Text = "Rating:";
            this.lblRating.Location = new System.Drawing.Point(20, 100);

            this.numRating = new System.Windows.Forms.NumericUpDown();
            this.numRating.Location = new System.Drawing.Point(120, 100);
            this.numRating.Minimum = 1;
            this.numRating.Maximum = 5;
            this.numRating.Size = new System.Drawing.Size(50, 22);

            this.lblDate = new System.Windows.Forms.Label();
            this.lblDate.Text = "Watch Date:";
            this.lblDate.Location = new System.Drawing.Point(20, 140);

            this.dtpWatchDate = new System.Windows.Forms.DateTimePicker();
            this.dtpWatchDate.Location = new System.Drawing.Point(120, 140);
            this.dtpWatchDate.Size = new System.Drawing.Size(150, 22);

            this.btnAddMovie = new System.Windows.Forms.Button();
            this.btnAddMovie.Text = "Add Movie";
            this.btnAddMovie.Location = new System.Drawing.Point(20, 180);
            this.btnAddMovie.Click += new System.EventHandler(this.btnAddMovie_Click);

            this.btnRemoveMovie = new System.Windows.Forms.Button();
            this.btnRemoveMovie.Text = "Remove Movie";
            this.btnRemoveMovie.Location = new System.Drawing.Point(140, 180);
            this.btnRemoveMovie.Click += new System.EventHandler(this.btnRemoveMovie_Click);

            this.btnSave = new System.Windows.Forms.Button();
            this.btnSave.Text = "Save to File";
            this.btnSave.Location = new System.Drawing.Point(260, 180);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            this.btnLoad = new System.Windows.Forms.Button();
            this.btnLoad.Text = "Load from File";
            this.btnLoad.Location = new System.Drawing.Point(380, 180);
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);

            this.dgvMovies = new System.Windows.Forms.DataGridView();
            this.dgvMovies.Location = new System.Drawing.Point(20, 220);
            this.dgvMovies.Size = new System.Drawing.Size(550, 150);
            this.dgvMovies.ReadOnly = true;
            this.dgvMovies.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lblGenre);
            this.Controls.Add(this.cmbGenre);
            this.Controls.Add(this.lblRating);
            this.Controls.Add(this.numRating);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.dtpWatchDate);
            this.Controls.Add(this.btnAddMovie);
            this.Controls.Add(this.btnRemoveMovie);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.dgvMovies);

            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.ComboBox cmbGenre;
        private System.Windows.Forms.Label lblRating;
        private System.Windows.Forms.NumericUpDown numRating;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtpWatchDate;
        private System.Windows.Forms.Button btnAddMovie;
        private System.Windows.Forms.Button btnRemoveMovie;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.DataGridView dgvMovies;
    }
}
