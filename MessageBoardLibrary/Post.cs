using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageBoardLibrary
{
    public class Post
    {
        public User Author { get; private set; }
        public string Message { get; private set; }
        private DateTime CreatedAt { get; set; }

        public Post(string message, User author = null)
        {
            this.Message = message;
            this.Author = author;
            this.CreatedAt = DateTime.Now;
        }

        public override string ToString()
        {
            string authorStr = this.Author == null ? "Anonymous" : this.Author.FullName;
            string postStr = $"{this.Message} \nBy {authorStr} : {this.CreatedAt.ToString()}";
            return postStr;
        }
    }
}
