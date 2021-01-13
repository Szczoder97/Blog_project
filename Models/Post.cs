using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Blog_project.Models
{
    public class Post
    {
        public int id { get; set; }
        public string userId { get; set; }
        public string title { get; set;}
        public string subtitle { get; set; }
        public string text { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0: dd-MMM-yyyy", ApplyFormatInEditMode =true)]
        [DisplayName("Published on:")]
        public DateTime publishedDate { get; set; }

        public  string tag { get; set; }

        public byte[] image { get; set; }

        public virtual ICollection<Comment>Comments { get; set; }
    }
}
