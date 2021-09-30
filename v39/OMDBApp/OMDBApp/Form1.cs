namespace OMDBApp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using OMDBApp.Helpers;

    public partial class Form1 : Form
    {
        public static SearchResult Result { get; set; }
        public static Movie MovieToDisplay { get; set; }
        public static int Page { get; set; }
        public static string SearchString { get; set; } = "";

        public Form1()
        {
            InitializeComponent();
            progressBar1.Minimum = 0;
            backButton.Enabled = false;
            moreButton.Enabled = false;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            Page = 1;
            SearchString = searchTextBox.Text;
            DoSearch();
            if (Result is SearchResult && Result.Response == "True")
            {
                progressBar1.Maximum = Int32.Parse(Result.totalResults);
                progressBar1.Value = Page * 10 > progressBar1.Maximum ? progressBar1.Maximum : Page * 10;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if ((Result is SearchResult && Result.Response == "True") && Page * 10 < Int32.Parse(Result.totalResults))
            {
                Page++;
                progressBar1.Value = Page * 10 < progressBar1.Maximum ? Page * 10 : progressBar1.Maximum;
                DoSearch();
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            if (Page > 1)
            {
                Page--;
                progressBar1.Value = Page * 10;
                DoSearch();
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Page = 1;
            SearchString = "";
            searchTextBox.Text = "";
            treeView1.Nodes.Clear();
            backButton.Enabled = false;
            moreButton.Enabled = false;
            posterPictureBox.Image = null;
            movieInfotextBox.Text = "";
            progressBar1.Value = 0;
            searchResultLabel.Text = "Search results:";
            resultCountLabel.Text = "Awaiting search result";
        }

        private void treeView1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                treeViewSelect();
                e.Handled = true;
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string imdbID = "";
            if (treeView1.SelectedNode.Parent != null)
            {
                imdbID = Result.Search[treeView1.SelectedNode.Parent.Index].imdbID;
            }
            else imdbID = Result.Search[treeView1.SelectedNode.Index].imdbID;
            if (Result is SearchResult && Result.Response == "True")
            {
                MovieToDisplay = OMDB.GetMovieByIMDB(imdbID, fullPlot: plotCheckBox.Checked);
                posterPictureBox.ImageLocation = MovieToDisplay.Poster;
                if (MovieToDisplay.Poster != "N/A")posterPictureBox.Load();
                movieInfotextBox.Text =
                    $"{MovieToDisplay.Title} - {MovieToDisplay.Year}\r\n" +
                    $"Genre: {MovieToDisplay.Genre}\r\n" +
                    $"Lenght: {MovieToDisplay.Runtime}\r\n" +
                    $"Director: {MovieToDisplay.Director}\r\n" +
                    $"Actors: {MovieToDisplay.Actors}\r\n" +
                    $"\r\n" +
                    $"Plot: {MovieToDisplay.Plot}";
            }
        }

        private void DisplaySearchResult()
        {
            treeView1.Nodes.Clear();
            if (Result is SearchResult && Result.Response == "True")
            {
                searchResultLabel.Text = $"Search results for \"{SearchString}\" :";

                resultCountLabel.Text = $"Showing {Page * 10 - 9} to {Page * 10} out of {Result.totalResults} results.";

                for (int i = 0; i < Result.Search.Length; i++)
                {
                    treeView1.Nodes.Add(new TreeNode(Result.Search[i].Title));
                    treeView1.Nodes[i].Nodes.Add(new TreeNode("Year: " + Result.Search[i].Year));
                    treeView1.Nodes[i].Nodes.Add(new TreeNode("Type: " + Result.Search[i].Type));
                    treeView1.Nodes[i].Nodes.Add(new TreeNode("ImdbID: " + Result.Search[i].imdbID));
                }
            }
            else treeView1.Nodes.Add("Nothing found...");
        }
        public void DoSearch()
        {   
            Result = OMDB.Search(SearchString, page: Page.ToString());
            DisplaySearchResult();
            HandleNavigationButtons();
            Console.WriteLine();
        }
        private void HandleNavigationButtons()
        {
            if (Result is SearchResult && Result.Response == "True")
            {
                if (Page * 10 < Int32.Parse(Result.totalResults)) moreButton.Enabled = true;
                else moreButton.Enabled = false;

                if (Page == 1) backButton.Enabled = false;
                else backButton.Enabled = true;
            }
            else
            {
                backButton.Enabled = false;
                moreButton.Enabled = false;
            }
        }
        private void treeViewSelect()
        {
            string imdbID = "";
            
            if (treeView1.SelectedNode.Parent != null)
            {
                imdbID = Result.Search[treeView1.SelectedNode.Parent.Index].imdbID;
            }
            else imdbID = Result.Search[treeView1.SelectedNode.Index].imdbID;
            if (Result is SearchResult && Result.Response == "True")
            {
                MovieToDisplay = OMDB.GetMovieByIMDB(imdbID,fullPlot:plotCheckBox.Checked);
                posterPictureBox.ImageLocation = MovieToDisplay.Poster;
                posterPictureBox.Load();
                movieInfotextBox.Text =
                    $"{MovieToDisplay.Title} - {MovieToDisplay.Year}\r\n" +
                    $"Genre: {MovieToDisplay.Genre}\r\n" +
                    $"Lenght: {MovieToDisplay.Runtime}\r\n" +
                    $"Director: {MovieToDisplay.Director}\r\n" +
                    $"Actors: {MovieToDisplay.Actors}\r\n" +
                    $"\r\n" +
                    $"Plot: {MovieToDisplay.Plot}";
            }
        }
    }
}
