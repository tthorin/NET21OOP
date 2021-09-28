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
        public int Page { get; set; }
        public string SearchString { get; set; } = "";

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
                progressBar1.Value = Page * 10;
            }
            label3.Text = Result.Response;
        }


        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


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
        private void DoSearch()
        {
            Result = OMDB.Search(SearchString, page: Page.ToString());
            DisplaySearchResult();
            HandleNavigationButtons();
        }

        private void HandleNavigationButtons()
        {
            if (Page * 10 < Int32.Parse(Result.totalResults)) moreButton.Enabled = true;
            else moreButton.Enabled = false;

            if (Page == 1) backButton.Enabled = false;
            else backButton.Enabled = true;
        }

        private void DisplaySearchResult()
        {
            treeView1.Nodes.Clear();
            if (Result is SearchResult && Result.Response == "True")
            {
                label1.Text = $"Search results for \"{SearchString}\" :";

                label2.Text = $"Showing {Page * 10 - 9} to {Page * 10} out of {Result.totalResults} results.";

                for (int i = 0; i < Result.Search.Length; i++)
                {
                    treeView1.Nodes.Add(new TreeNode(Result.Search[i].Title));
                    treeView1.Nodes[i].Nodes.Add(new TreeNode("Year: " + Result.Search[i].Year));
                    treeView1.Nodes[i].Nodes.Add(new TreeNode("Type: " + Result.Search[i].Type));
                    treeView1.Nodes[i].Nodes.Add(new TreeNode("ImdbID: " + Result.Search[i].imdbID));
                }
            }
            else searchResultListBox.Items.Add("Nothing found");
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {   
            string imdbID = "";
            if (e.Node.Parent != null)
            {
                imdbID = Result.Search[e.Node.Parent.Index].imdbID;
            }
            else imdbID = Result.Search[e.Node.Index].imdbID;
            if (Result is SearchResult && Result.Response == "True")
            {
                MovieToDisplay = OMDB.GetMovieByIMDB(imdbID);
                posterPictureBox.ImageLocation = MovieToDisplay.Poster;
                posterPictureBox.Load();
                movieInfotextBox.Text =
                    $"{MovieToDisplay.Title} - {MovieToDisplay.Year}\r\n" +
                    $"Director: {MovieToDisplay.Director}\r\n" +
                    $"Actors: {MovieToDisplay.Actors}\r\n" +
                    $"\r\n" +
                    $"Plot: {MovieToDisplay.Plot}";
            }
        }
    }
}
