using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog_project.Models
{
    public class Comment
    {
        public int id { get; set; }

        public string userId { get; set; }

        public int postId { get; set; }

        public string text { get; set; }
    }
}
