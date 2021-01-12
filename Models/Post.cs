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

        [DisplayName("User name:")]
        [RegularExpression(@"^[a-zA-Z0-9''-'\s]*$", ErrorMessage = "Username cannot include special characters")]//+ co najmniej jedna z duzej ^od tego sie zaczyna $koniec
        [Required]
        public string userName { get; set; }

        //public int userId { get; set; }
        [DisplayName("Title:")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Title of the post must have at least 3 characters")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9''-'\s]*$", ErrorMessage = "Title of the post cannot include special characters and must begin with capital letter")]//+ co najmniej jedna z duzej ^od tego sie zaczyna $koniec
        [Required]
        public string title { get; set;}

        [DisplayName("Post content:")]
        public string text { get; set; }

        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString ="{0: dd-MMM-yyyy}", ApplyFormatInEditMode =true)]
        [DisplayName("Published on:")]
        public DateTime publishedDate { get; set; }
    }
}
