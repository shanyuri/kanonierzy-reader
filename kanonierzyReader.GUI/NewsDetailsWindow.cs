using kanonierzyReader.Lib;
using System;
using System.Windows.Forms;

namespace kanonierzyReader.GUI
{
    public partial class NewsDetailsWindow : Form
    {
        #region Members
        private string NewsUrl { get; set; }
        #endregion

        #region Constructor
        public NewsDetailsWindow(string newsUrl, string newsTitle, DateTime newsCreatedAt, int newsNumberOfComments)
        {
            InitializeComponent();

            NewsUrl = newsUrl ?? "";
            textBox1.Text = newsTitle ?? "";
            textBox2.Text = KanonierzyParser.GetSingleNewsContent(newsUrl);
            label2.Text = newsCreatedAt.ToString("MM/dd/yy HH:mm");
            label4.Text = newsNumberOfComments.ToString();

            this.Select();
        }
        #endregion

        #region Control Events
        private void NewsBrowserBtn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(NewsUrl);
        }
        #endregion
    }
}
