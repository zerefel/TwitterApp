using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Twitter.Models
{
    public class TweetReply : ITweet
    {
        public int Id { get; set; }

        public string Content { get; set; }

        public User Poster { get; set; }

        public ICollection<ITweet> Replies { get; set; }

        public Tweet ReplyTo { get; set; }

        public DateTime PostDate { get; set; }
    }
}