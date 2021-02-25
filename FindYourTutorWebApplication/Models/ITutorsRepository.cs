using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FindYourTutorWebApp.Models
{
    public interface ITutorsRepository
    {
        IQueryable<Tutor> Tutors { get; }
        IQueryable<Subject> Subjects { get; }
    }
}
