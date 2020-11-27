using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SCP.ViewModels
{
    public class FeedbackCollectionViewModel
    {
        public int Id { get; set; }
        public string PostTitle { get; set; }

        public List<PostDetails> PostDetails { get; set; }
    }
    public class PostDetails
    {
        public int Id { get; set; }
        public string Admin { get; set; }
        public DateTime CommentDate { get; set; }
        public string Comments { get; set; }
    }
}
