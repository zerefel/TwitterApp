using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Twitter.Models
{
    public class User
    {
       
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public DateTime RegisteredOn { get; set; }
        public virtual ICollection<Tweet> Tweets { get; set; } 
        public virtual ICollection<User> Followers { get; set; }
        public virtual ICollection<User> Following { get; set; }
        public virtual ICollection<Message> Messages { get; set; }
        public virtual ICollection<Tweet> FavoriteTweets { get; set; }
        public virtual ICollection<Tweet> ReportedTweets { get; set; }
        public virtual ICollection<TweetReply> TweetReplies { get; set; }
    }
}