using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Twitter.Models
{
    public interface ITweet
    {
        int Id { get; set; }
        string Content { get; set; }
        User Poster { get; set; }
        ICollection<ITweet> Replies { get; set; }
        DateTime PostDate { get; set; }
    }
}
