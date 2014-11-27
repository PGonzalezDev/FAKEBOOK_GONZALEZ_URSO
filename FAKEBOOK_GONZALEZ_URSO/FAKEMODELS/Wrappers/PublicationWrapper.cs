using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace FAKEMODELS.Wrappers
{
    public class PublicationWrapper
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Text { get; set; }
        public string Image { get; set; }
        public DateTime Date_Time { get; set; }

        public PublicationWrapper(Publication post)
        {
            Id = post.Id;
            UserName = post.User.UserName;
            Text = breakLines(post.Text);
            Image = post.Image;
            Date_Time = post.Date_Time;
        }

        private string breakLines(string text)
        {
            int maxLength = 100;

            if (text.Length > maxLength)
            {
                StringBuilder sb = new StringBuilder();
                char[] array = text.ToArray();
                for (int i = 0; i < array.Length; i++)
                {
                    sb.Append(array[i]);

                    if (((i + 1) % maxLength) == 0)
                    {
                        sb.AppendLine();
                    }
                }

                text = sb.ToString();
            }

            return text;
        }
    }
}
