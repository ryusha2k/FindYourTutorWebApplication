using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FindYourTutorWebApp.Models
{
    public class FakeTutorsRepository /*: ITutorsRepository*/
    {
        public IQueryable<Tutor> Tutors => new List<Tutor>
        {
            new Tutor{ Name = "Uebok", LastName = "Zalupin", MiddleName = "Petrovich", BirthDate = new DateTime(1990, 6, 4) },
            new Tutor{ Name = "Pupa", LastName = "Lupin", BirthDate = new DateTime(1989, 7, 3) },
            new Tutor{ Name = "Vasyan", LastName = "Erohin", MiddleName = "Vasyanovich", BirthDate = new DateTime(1992, 9, 10) }
        }.AsQueryable();
    }
}
