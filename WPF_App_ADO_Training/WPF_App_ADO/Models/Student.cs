using System;
using System.Collections.Generic;

namespace WPF_App_ADO.Models
{
    public partial class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public DateTime? Dob { get; set; }
        public string Address { get; set; }
        public int? MajorId { get; set; }
        public bool? Married { get; set; }

        public virtual Major Major { get; set; }
    }
}
