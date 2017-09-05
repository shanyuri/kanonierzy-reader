using HtmlAgilityPack;
using System;
using System.Collections.Generic;

namespace kanonierzyReader.Lib
{
    public static class KanonierzyParser
    {
        #region Constants
        // strings for News Archive
        private static readonly string NewsArchiveUrl = "http://kanonierzy.com/archiwum/";
        private static readonly string NewsArchiveXpath = "//div[contains(@class, 'smallnews newsarchive')]";
        private static readonly string NewsContainerXpath = "div[contains(@class, 'singlenews')]/div[contains(@class, 'newscont')]";
        private static readonly string NewsTitleXpath = "h3[contains(@class, 'title')]/a";
        private static readonly string NewsShortContentXpath = "p[contains(@class, 'text')]/a/span[contains(@class, 'text')]";
        private static readonly string NewsCreatedAtXpath = "p[contains(@class, 'text')]/a/span[contains(@class, 'details')]/span[contains(@class, 'date')]";
        private static readonly string NewsNumberOfCommentsXpath = "p[contains(@class, 'text')]/a/span[contains(@class, 'details')]/span[contains(@class, 'comments')]";
        // strings for Single News
        private static readonly string SingleNewsParagraphXpath = "//div[contains(@class, 'thenews ')]/p[contains(@class, 'text')]"; // do not erase space in 'thenews '
        private static readonly string SingleNewsContentTextDelimiter = "komentarzy";
        private static readonly string SingleNewsCreatedAtNodeXpath = "span[contains(@class, 'details')]/span[contains(@class, 'date')]";
        private static readonly string SingleNewsNumberOfCommentsNodeXpath = "span[contains(@class, 'details')]/a[contains(@class, 'comments')]";
        private static readonly string SingleNewsTitleNodeXpath = "//div[contains(@class, 'columnwide')]/h1[contains(@class, 'sub')]";
        // strings for News Comments
        private static readonly string CommentsListXpath = "//div[contains(@class, 'commentslist')]";
        private static readonly string CommentXpath = "div[contains(@class, 'singlecomment')]";
        private static readonly string CommentContainerXpath = ".//div[contains(@class, 'commentcontent')]";
        private static readonly string CommentAuthorXpath = "span[contains(@class, 'author')]";
        private static readonly string CommentCreatedAtXpath = "span[contains(@class, 'details')]/span[contains(@class, 'date')]";
        private static readonly string CommentContentXpath = "p[contains(@class, 'com')]";
        // strings for Main or Single News
        private static readonly string WebsiteUrl = "http://kanonierzy.com/";
        private static readonly string MainNewsAnchorXPath = "//div[contains(@class, 'mainnews')]/div[contains(@class, 'text')]/span[contains(@class, 'more')]/a[contains(@class, 'readmore')]";
        #endregion

        #region Methods for parsing News
        public static List<News> GetNewsPageForDate(int year, int month, int page = 1)
        {
            year = Math.Abs(year);
            month = Math.Abs(month);
            page = Math.Abs(page);

            HtmlDocument htmlDoc = HtmlClient.GetHtmlDocument(NewsArchiveUrl + $"/{year}/{month}/{page}");
            if (htmlDoc == null)
            {
                return null;
            }

            // select news archive container
            HtmlNode newsArchiveNode = htmlDoc.DocumentNode.SelectSingleNode(NewsArchiveXpath);
            if (newsArchiveNode == null)
            {
                return null;
            }

            List<News> news = GetNewsFromNewsArchiveNode(newsArchiveNode);
            return news;
        }

        public static string GetSingleNewsContent(string newsUrl)
        {
            if (string.IsNullOrEmpty(newsUrl.Trim()))
            {
                throw new ArgumentException();
            }

            newsUrl = newsUrl.Trim();
            HtmlDocument htmlDoc = HtmlClient.GetHtmlDocument(newsUrl);
            HtmlNode newsNode = htmlDoc.DocumentNode.SelectSingleNode(SingleNewsParagraphXpath);
            string newsContent = newsNode.InnerText.Trim();

            // search and skip "komentarzy" part
            int posOftextDelimiter = newsContent.IndexOf(SingleNewsContentTextDelimiter);
            return (posOftextDelimiter == -1) ?
                newsContent : newsContent.Substring(posOftextDelimiter + SingleNewsContentTextDelimiter.Length).Trim();
        }

        private static List<News> GetNewsFromNewsArchiveNode(HtmlNode newsArchiveNode)
        {
            if (newsArchiveNode == null)
            {
                throw new ArgumentNullException();
            }

            List<News> news = new List<News>();
            foreach (HtmlNode newsContainerNode in newsArchiveNode.SelectNodes(NewsContainerXpath))
            {
                HtmlNode titleNode = newsContainerNode.SelectSingleNode(NewsTitleXpath);
                string newsUrl = titleNode.Attributes["href"].Value;
                string newsTitle = titleNode.InnerHtml.Trim();
                string newsShortContent = newsContainerNode.SelectSingleNode(NewsShortContentXpath).InnerHtml;
                string newsCreatedAtText = newsContainerNode.SelectSingleNode(NewsCreatedAtXpath).InnerText.Trim();
                DateTime.TryParse(newsCreatedAtText, out DateTime newsCreatedAt);
                HtmlNode newsNumberOfCommentsNode = newsContainerNode.SelectSingleNode(NewsNumberOfCommentsXpath);
                string newsNumberOfCommentsText = newsNumberOfCommentsNode.InnerText.Split(' ')[0]; // because innerText looks like "12 komentarzy"
                int.TryParse(newsNumberOfCommentsText, out int newsNumberOfComments);

                news.Add(
                    new News
                    {
                        Url = newsUrl,
                        Title = newsTitle,
                        Content = "",
                        ShortContent = newsShortContent,
                        CreatedAt = newsCreatedAt,
                        NumberOfComments = newsNumberOfComments
                    }
                );
            }

            return news;
        }

        public static News GetMainNews()
        {
            HtmlDocument htmlDoc = HtmlClient.GetHtmlDocument(WebsiteUrl);
            if (htmlDoc == null)
            {
                return null;
            }

            HtmlNode mainNewsReadMoreAnchorNode = htmlDoc.DocumentNode.SelectSingleNode(MainNewsAnchorXPath);
            if (mainNewsReadMoreAnchorNode == null)
            {
                return null;
            }
            string url = mainNewsReadMoreAnchorNode.Attributes["href"].Value;

            return GetSingleNews(url);
        }

        public static News GetSingleNews(string newsUrl)
        {
            if (string.IsNullOrEmpty(newsUrl.Trim()))
            {
                throw new ArgumentException();
            }

            newsUrl = newsUrl.Trim();
            HtmlDocument htmlDoc = HtmlClient.GetHtmlDocument(newsUrl);
            HtmlNode newsNode = htmlDoc.DocumentNode.SelectSingleNode(SingleNewsParagraphXpath);
            // title
            HtmlNode titleNode = htmlDoc.DocumentNode.SelectSingleNode(SingleNewsTitleNodeXpath);
            string title = titleNode.InnerText;

            // content
            string newsContent = newsNode.InnerText.Trim();
            int posOftextDelimiter = newsContent.IndexOf(SingleNewsContentTextDelimiter);
            if (posOftextDelimiter != -1)
            {
                newsContent = newsContent.Substring(posOftextDelimiter + SingleNewsContentTextDelimiter.Length).Trim();
            }

            // number of comments
            HtmlNode numberOfCommentsNode = newsNode.SelectSingleNode(SingleNewsNumberOfCommentsNodeXpath);
            string numberOfCommentsText = numberOfCommentsNode.InnerText.Split(' ')[0];
            int.TryParse(numberOfCommentsText, out int numberOfComments);

            // created date
            HtmlNode createdAtNode = newsNode.SelectSingleNode(SingleNewsCreatedAtNodeXpath);
            string createdAtText = createdAtNode.InnerText.Substring(0, 18);
            DateTime.TryParse(createdAtText, out DateTime createdAt);

            return new News
            {
                Url = newsUrl,
                Title = title,
                Content = newsContent,
                NumberOfComments = numberOfComments,
                CreatedAt = createdAt,
            };
        }
        #endregion

        #region Methods for parsing Comments
        public static List<Comment> GetCommentsPageForNews(string newsUrl, int page = 1)
        {
            if (string.IsNullOrEmpty(newsUrl.Trim()))
            {
                throw new ArgumentException();
            }

            newsUrl = newsUrl.Trim();
            HtmlDocument htmlDoc = HtmlClient.GetHtmlDocument(newsUrl + "/" + page);
            if (htmlDoc == null)
            {
                return null;
            }

            HtmlNode commentsListNode = htmlDoc.DocumentNode.SelectSingleNode(CommentsListXpath);
            if (commentsListNode == null)
            {
                return null;
            }

            List<Comment> comments = new List<Comment>();
            foreach (HtmlNode singleCommentNode in commentsListNode.SelectNodes(CommentXpath))
            {
                HtmlNode commentContentNode = singleCommentNode.SelectSingleNode(CommentContainerXpath);
                string commentAuthor = commentContentNode.SelectSingleNode(CommentAuthorXpath).InnerText.Trim();
                HtmlNode commentCreatedAtNode = commentContentNode.SelectSingleNode(CommentCreatedAtXpath);
                DateTime.TryParse(commentCreatedAtNode.InnerText.Trim(), out DateTime commentCreatedAt);
                string commentContent = singleCommentNode.SelectSingleNode(CommentContentXpath).InnerText.Trim();

                comments.Add(
                    new Comment
                    {
                        Author = commentAuthor,
                        CreatedAt = commentCreatedAt,
                        Content = commentContent
                    }    
                );

            }

            return comments;
        }
        #endregion
    }
}
