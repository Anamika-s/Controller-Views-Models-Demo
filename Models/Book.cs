using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationMVCCore.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string BookName { get; set; }
        public string AuthorName { get; set; }

        public DateTime PublishDate { get; set; }
        public int Price { get; set; }
    }
}
