using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FindYourTutorWebApp.Models
{
    public class Tutor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string? MiddleName { get; set; }
        public DateTime BirthDate { get; set; }
        public ICollection<Arrangement> Arrangements { get; set; }
        public ICollection<Subject> Subjects { get; set; }
    }
}
