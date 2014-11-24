using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FAKEMODELS
{
    public class Publication
    {
        public int Id { get; set; }
        public User User { get; set; }
        public string Text { get; set; }
        public string Image { get; set; }
        public DateTime Date_Time { get; set; }
        List<Comment> CommentList { get; set; }

        public Publication()
        {
            Id = 0;
            User = null;
            Text = string.Empty;
            Image = string.Empty;
            Date_Time = DateTime.MinValue;
            CommentList = new List<Comment>();

        }
        /*
        public Publication(int id, User user, string text, DateTime dateTime)
        {
            Id = id;
            User = user;
            Text = text;
            Date_Time = dateTime;
            CommentList = new List<Comment>();
            
        }*/

        public Publication(User user, string text, DateTime dateTime, string img = "")
        {

            Id = 0;
            User = user;
            Text = text;
            Date_Time = dateTime;
            Image = img;
            CommentList = new List<Comment>();
        }

        public bool IsValid()
        {
            return ((User != null)
                    && !string.IsNullOrEmpty(Text.Trim())
                    && (Date_Time != null && DateTime.Compare(Date_Time, DateTime.MinValue) != 0));
        }
    }
}
