
namespace Twitter.Data
{
    using System;
    using System.Data.Entity;
    using Twitter.Models;
    using System.Linq;

    public class TwitterEntities : DbContext
    {
        // Your context has been configured to use a 'TwitterEntities' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'Twitter.Data.TwitterEntities' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'TwitterEntities' 
        // connection string in the application configuration file.
        public TwitterEntities()
            : base("TwitterEntities")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Tweet> Tweets { get; set; }
        public virtual DbSet<Message> Messages { get; set; }
        public virtual DbSet<TweetReply> TweetReplies { get; set; } 

    }
}