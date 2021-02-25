using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FindYourTutorWebApp.Models
{
    public class Subject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string category { get; set; }
        public ICollection<Tutor> Tutors { get; set; }
    }
}
