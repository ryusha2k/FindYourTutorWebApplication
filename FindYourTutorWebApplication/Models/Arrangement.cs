using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FindYourTutorWebApp.Models
{
    public class Arrangement
    {
        public int Id { get; set; }
        public Tutor Tutor { get; set; }
        public Student Student { get; set; }
        public bool Arranged { get; set; }
    }
}
