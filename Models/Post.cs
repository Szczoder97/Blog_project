using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Blog_project.Models
{
    public class Post
    {
        public int id { get; set; }
        public int userId { get; set; }
        public string title { get; set;}
        public string text { get; set; }
        [DataType(DataType.Date)]
        public DateTime publishedDate { get; set; }
    }
}
