using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Blog
    {
        public int Id { get; set; }

        public string PostTitle { get; set; }

        public string PostImage { get; set; }

        public string PostDescription { get; set; }

        public string PostContent { get; set; }

        public DateTime PostDate{ get; set; }
    }
}