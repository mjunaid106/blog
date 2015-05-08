using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Services.Models
{
    public class Post
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public string PostedOn { get; set; }
    }
}
