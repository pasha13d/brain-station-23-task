using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SCP.Model
{
    public class Posts
    {
        public int Id { get; set; }
        public string PostTitle{ get; set; }

        public virtual List<PostDetails> PostDetails { get; set; }
    }
}
