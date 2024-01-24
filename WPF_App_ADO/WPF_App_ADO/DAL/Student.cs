using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_App_ADO.DAL
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Gender { get; set; }
        public DateTime? Dob {  get; set; }
        public string? Address { get; set; }
        public int? MajorId { get; set; }
        public bool? Married { get; set; }
    }
}
