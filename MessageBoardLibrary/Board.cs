using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageBoardLibrary
{
    public class Board
    {
        List<Post> posts;

        public Board()
        {
            this.posts = new List<Post>();
        }
    }
}
