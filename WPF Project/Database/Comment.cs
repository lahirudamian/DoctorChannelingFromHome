using System;
using System.Collections.Generic;
using System.Text;

namespace WPF_Project.Database
{
    public class Comment
    {
        public int CommentId { get; set; }

        public string Text { get; set; }

        public virtual Citizen Citizen { get; set; }

        public Comment()
        {
        }

        public Comment(string text)
        {
            Text = text;
        }
    }
}
