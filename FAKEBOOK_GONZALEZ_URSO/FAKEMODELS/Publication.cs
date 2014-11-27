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
            User = new User();
            Text = string.Empty;
            Image = string.Empty;
            Date_Time = DateTime.MinValue;
            CommentList = new List<Comment>();

        }

        public Publication(int userId, string text, DateTime dateTime, int id = 0, string img = "")
        {

            Id = id;
            User = new User();
            User.Id = userId;
            Text = text;
            Date_Time = dateTime;
            Image = img;
            CommentList = new List<Comment>();
        }

        public Publication(User user, string text, DateTime dateTime, int id = 0, string img = "")
        {

            Id = id;
            User = user;
            Text = text;
            Date_Time = dateTime;
            Image = img;
            CommentList = new List<Comment>();
        }

        public override string ToString()
        {
            return (User != null) ? User.UserName : string.Empty;
        }

        public bool IsValid()
        {
            return ((User != null && User.Id != 0)
                    && !string.IsNullOrEmpty(Text.Trim())
                    && (Date_Time != null && DateTime.Compare(Date_Time, DateTime.MinValue) != 0));
        }
    }
}
