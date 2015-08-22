using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TestWebApi02.DataContracts;

namespace TestWebApi02.Entities
{
    public class Blogpost : IBlogpost
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime LastEditDate { get; set; }
        [MaxLength(2048), Required]
        public string Title { get; set; }
        [Column(TypeName = "ntext")]
        public string Body { get; set; }
    }
}
