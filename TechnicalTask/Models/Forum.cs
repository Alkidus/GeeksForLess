using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TechnicalTask.Models
{
    public class Forum
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Created { get; set; }

        public virtual IEnumerable<Post> Post { get; set; }

    }
}