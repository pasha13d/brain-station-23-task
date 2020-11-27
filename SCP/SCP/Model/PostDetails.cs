using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SCP.Model
{
    public class PostDetails
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        [Key]
        [Column(Order = 1)]
        public int PostsId { get; set; }
        public string Admin { get; set; }
        public DateTime CommentDate { get; set; }
        public string Comments { get; set; }

        public virtual Posts Posts { get; set; }
    }
}
