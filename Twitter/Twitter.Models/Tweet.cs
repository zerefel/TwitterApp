using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Twitter.Models
{
    public class Tweet : ITweet
    {

        public int Id { get; set; }

        public string Content { get; set; }

        public User Poster { get; set; }

        public virtual ICollection<ITweet> Replies { get; set; }

        public DateTime PostDate { get; set; }
    }
}