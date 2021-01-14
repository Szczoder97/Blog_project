using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Blog_project.Models
{
    public class Image
    {
        [Key]
        public int ImageId { get; set; }

        [DisplayName("Image path")]
        [Column(TypeName ="nvarchar(50)")]
        public string Title { get; set; }

        [NotMapped]
        [DisplayName("Upload image")]
        public IFormFile ImageFile { get; set; }
    }
}
