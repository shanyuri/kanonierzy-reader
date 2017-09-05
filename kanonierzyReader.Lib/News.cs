using System;
using System.Collections.Generic;

namespace kanonierzyReader.Lib
{
    public class News
    {
        public string Url { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string ShortContent { get; set; }
        public int NumberOfComments { get; set; }
        public DateTime CreatedAt { get; set; }
        public List<Comment> Comments { get; set; }

        public News()
        {
            Comments = new List<Comment>();
        }

        public override string ToString()
        {
            return $"Title: {Title}, createdAt: {CreatedAt.ToString("MM/dd/yy HH:mm")}";
        }
    }
}
