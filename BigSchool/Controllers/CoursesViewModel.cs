using System;
using System.Collections.Generic;
using BigSchool.Models;

namespace BigSchool.Controllers
{
    internal class CoursesViewModel
    {
        public List<Category> Categories { get; set; }
        public string Place { get; internal set; }

        internal DateTime getDateTime()
        {
            throw new NotImplementedException();
        }

        internal object Category()
        {
            throw new NotImplementedException();
        }
    }
}