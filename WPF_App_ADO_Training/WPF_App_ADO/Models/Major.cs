using System;
using System.Collections.Generic;

namespace WPF_App_ADO.Models
{
    public partial class Major
    {
        public Major()
        {
            Students = new HashSet<Student>();
        }

        public int Id { get; set; }
        public string Major1 { get; set; }

        public virtual ICollection<Student> Students { get; set; }
    }
}
