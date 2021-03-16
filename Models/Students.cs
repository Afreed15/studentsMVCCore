using System;
using System.Collections.Generic;

namespace WebCoreDbfirst.Models
{
    public partial class Students
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Course { get; set; }
        public string Email { get; set; }
        public string Contact { get; set; }
    }
}
