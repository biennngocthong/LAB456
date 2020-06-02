using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BigSchool.Models
{
    public class Course
    {
        public int Id { get; set; }
        public ApplicationUser Leturer { get; set; }
        public string LecturerId { get; set; }
        public string Place { get; set; }
        public DateTime DateTime { get; set; }
        public Category Category { get; set; }
        public byte CategoryID { get; set; }
        public object CategoryId { get; internal set; }
    }

}