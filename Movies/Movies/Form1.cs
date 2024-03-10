using Movies.Data;
using Movies.Model;

namespace Movies
{
    public partial class Form1 : Form
    {
        private MovieContext context;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (context = new MovieContext())
            { 
                Movie movie = new Movie();
                movie.Name = textBox1.Text;
                movie.Description = textBox2.Text;
                movie.Date = dateTimePicker1.Value.Date;
                context.Movies.Add(movie);
                context.SaveChanges();
                MessageBox.Show("Movie has been added!");
            }
        }
        private void UpdateGrid()
        { 
            dataGridView1.DataSource = context.Movies;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateGrid();
        }
    }
}