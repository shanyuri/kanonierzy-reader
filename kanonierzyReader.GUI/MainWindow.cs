using kanonierzyReader.Lib;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace kanonierzyReader.GUI
{
    public partial class MainWindow : Form
    {
        #region Members
        private News MainNews { get; set; }
        private List<News> News { get; set; }
        private string SelectedNewsUrl { get; set; }
        private string SelectedNewsTitle { get; set; }
        private int SelectedNewsIndex { get; set; } = -1;
        private const string CommentsLabelText = "Comments for: ";
        #endregion

        #region Constructor
        public MainWindow()
        {
            InitializeComponent();
            InitializeMainNews();
            InitNewsArchiveFormComboboxes();
        }
        #endregion

        #region Help Methods
        private void InitializeMainNews()
        {
            MainNews = KanonierzyParser.GetMainNews();
            if (MainNews != null)
            {
                mainNewsTitleTextBox.Text = MainNews.Title;
                mainNewsContentTextBox.Text = MainNews.Content;
                mainNewsLabel2.Text = MainNews.CreatedAt.ToString("MM/dd/yy HH:mm");
                mainNewsLabel4.Text = MainNews.NumberOfComments.ToString();
            }
            else
            {
                MessageBox.Show("Error during fetching Main News", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InitNewsArchiveFormComboboxes()
        {
            for (int i = DateTime.Now.Year; i >= 2006; i--)
            {
                newsYearComboBox1.Items.Add(i);
            }
            newsYearComboBox1.SelectedIndex = 0;

            for (int i = 1; i <= 12; i++)
            {
                newsMonthComboBox2.Items.Add(CultureInfo.CurrentUICulture
                    .DateTimeFormat.GetAbbreviatedMonthName(i).ToUpper());
            }
            newsMonthComboBox2.SelectedIndex = DateTime.Now.Month - 1;
        }

        private void LoadNewsList()
        {
            newsListBox.Items.Clear();

            var yearItem = newsYearComboBox1.SelectedItem;
            var selectedMonth = newsMonthComboBox2.SelectedIndex + 1;
            int.TryParse(yearItem.ToString(), out int selectedYear);
            int.TryParse(newsPageTextBox.Text.Trim(), out int selectedPage);
            newsPageTextBox.Text = "" + (selectedPage > 0 ? selectedPage : selectedPage + 1);
            News = KanonierzyParser.GetNewsPageForDate(selectedYear, selectedMonth, selectedPage);

            if (News != null)
            {
                foreach (var item in News)
                {
                    string newsRecord = item.CreatedAt.ToString("MM/dd/yy HH:mm") 
                        + "\t" + $"{item.Title}  (comments: {item.NumberOfComments})";
                    newsListBox.Items.Add(newsRecord);
                }
            }
        }
        #endregion

        #region Tab Control Events
        private void TabControl_Selected(object sender, TabControlEventArgs e)
        {
            commentsPageTextBox.Text = "1";
            //if (tabControl.SelectedIndex == 1)
            //{
            //    LoadNewsList();
            //}
        }
        #endregion

        #region MainNews Control Events
        private void MainNewsRefreshBtn_Click(object sender, EventArgs e)
        {
            InitializeMainNews();
        }

        private void MainNewsBrowserBtn_Click(object sender, EventArgs e)
        {
            if (MainNews != null && !string.IsNullOrEmpty(MainNews.Url))
            {
                System.Diagnostics.Process.Start(MainNews.Url);
            }
            else
            {
                MessageBox.Show("Main News is invalid.", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region News Archive Control Events
        private void NewsDownloadBtn_Click(object sender, EventArgs e)
        {
            SelectedNewsUrl = null;
            LoadNewsList();
            if (newsListBox.Items.Count > 0)
            {
                newsListBox.SelectedIndex = 0;
                SelectedNewsIndex = 0;
            }
        }

        private void NewsPrevPage_Click(object sender, EventArgs e)
        {
            int.TryParse(newsPageTextBox.Text.Trim(), out int page);
            if (page > 1)
            {
                page--;
                newsPageTextBox.Text = page.ToString();
                newsDownloadBtn.PerformClick();
            }
        }

        private void NewsNextPage_Click(object sender, EventArgs e)
        {
            int.TryParse(newsPageTextBox.Text.Trim(), out int page);
            page++;
            newsPageTextBox.Text = page.ToString();
            newsDownloadBtn.PerformClick();
        }

        private void NewsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = newsListBox.SelectedIndex;
            if (selectedIndex != SelectedNewsIndex)
            {
                commentsPageTextBox.Text = "1";
                News selectedNews = News.ElementAt(selectedIndex);
                SelectedNewsUrl = selectedNews.Url;
                SelectedNewsTitle = selectedNews.Title;
                SelectedNewsIndex = selectedIndex;
            }
        }

        private void NewsListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int selectedNewsIndex = newsListBox.SelectedIndex;
            if (selectedNewsIndex > -1)
            {
                News selectedNews = News.ElementAt(newsListBox.SelectedIndex);
                NewsDetailsWindow newsDetailsWindow = new NewsDetailsWindow(
                    selectedNews.Url, selectedNews.Title, selectedNews.CreatedAt, selectedNews.NumberOfComments);
                newsDetailsWindow.Show();
            }
        }
        #endregion

        #region Comments Control Events
        private void CommentsDownloadBtn_Click(object sender, EventArgs e)
        {
            int.TryParse(commentsPageTextBox.Text.Trim(), out int selectedCommentPage);
            string commNewsUrl = "";
            string commNewsTitle = "";

            if (tabControl.SelectedIndex == 0) // main news tab
            {
                if (MainNews != null && !string.IsNullOrEmpty(MainNews.Url))
                {
                    commNewsUrl = MainNews.Url;
                    commNewsTitle = MainNews.Title;
                }
                else
                {
                    MessageBox.Show("There is no main news.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (tabControl.SelectedIndex == 1) // news archive tab
            {
                if (string.IsNullOrEmpty(SelectedNewsUrl))
                {
                    MessageBox.Show("Select news from the list.", "Error", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                commNewsUrl = SelectedNewsUrl;
                commNewsTitle = SelectedNewsTitle;
            }

            var comments = KanonierzyParser.GetCommentsPageForNews(commNewsUrl, selectedCommentPage);
            commentsGrid.DataSource = comments;
            label5.Text = $"{CommentsLabelText}\"{commNewsTitle}\"";
        }

        private void CommentsPrevPageBtn_Click(object sender, EventArgs e)
        {
            int.TryParse(commentsPageTextBox.Text.Trim(), out int page);
            if (page > 1)
            {
                page--;
                commentsPageTextBox.Text = page.ToString();
                commentsDownloadBtn.PerformClick();
            }
        }

        private void CommentsNextPageBtn_Click(object sender, EventArgs e)
        {
            int.TryParse(commentsPageTextBox.Text.Trim(), out int page);
            page++;
            commentsPageTextBox.Text = page.ToString();
            commentsDownloadBtn.PerformClick();
        }
        #endregion
    }
}
