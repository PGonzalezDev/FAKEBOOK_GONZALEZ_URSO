using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FAKEMODELS
{
    public class Comment
    {
        public int Id { get; set; }
        public int PublicationId { get; set; }
        public User User { get; set; }
        public string Text { get; set; }
        public string Image { get; set; }
        public DateTime Date_Time { get; set; }

        public Comment()
        {
            Id = 0;
            PublicationId = 0;
            User = null;
            Text = string.Empty;
            Image = string.Empty;
            Date_Time = DateTime.MinValue;
        }

        /*public Comment(int id, int parentId, User user, string text, DateTime dateTime)
        {
            Id = id;
            PublicationId = parentId;
            User = user;
            Text = text;
            Image = string.Empty;
            Date_Time = dateTime;
        }*/

        public Comment(int id, int parentId, User user, string text, DateTime dateTime, string image = "")
        {
            Id = id;
            PublicationId = parentId;
            User = user;
            Text = text;
            Date_Time = dateTime;
            Image = image;
        }
    }
}
