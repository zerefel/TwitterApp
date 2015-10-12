using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Twitter.Models
{
    public class Message
    {
        public int Id { get; set; }
        public User From { get; set; }
        public User To { get; set; }
        public string Content { get; set; }
        public DateTime SentOn { get; set; }
    }
}
